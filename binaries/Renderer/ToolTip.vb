Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class ToolTip
    Public Shared TitleFont As Font = New Font("Segoe UI", 9, FontStyle.Bold Or FontStyle.Italic)
    Public Shared TextFont As Font = New Font("Segoe UI", 8, FontStyle.Bold)
#Region "Enumerations"
    ''' <summary>
    ''' Describing the content of a tooltip information.
    ''' Tooltip information has 3 component, title, text, and image.
    ''' </summary>
    Public Enum Content
        TitleOnly
        TitleAndText
        TitleAndImage
        All
        ImageOnly
        ImageAndText
        TextOnly
        Empty
    End Enum
#End Region
    ''' <summary>
    ''' A brush for drawing a string in tooltip.
    ''' </summary>
    ''' <returns>Brush.</returns>
    Public Shared ReadOnly Property TextBrush() As Brush
        Get
            Return New SolidBrush(Color.FromArgb(118, 118, 118))
        End Get
    End Property
    ''' <summary>
    ''' A pen for drawing line separator in tooltip.
    ''' </summary>
    ''' <returns>Pen.</returns>
    Public Shared ReadOnly Property SeparatorPen() As Pen
        Get
            Return New Pen(Color.FromArgb(158, 187, 221))
        End Get
    End Property
    ''' <summary>
    ''' Get the content of the tooltip information.
    ''' </summary>
    ''' <param name="title">Tooltip title.</param>
    ''' <param name="text">Tooltip text.</param>
    ''' <param name="image">Tooltip image.</param>
    ''' <returns><seealso cref="Content"/></returns>
    Public Shared Function getContent(ByVal title As String, ByVal text As String, ByVal image As Image) As Content
        If title <> "" And text <> "" And image IsNot Nothing Then
            Return Content.All
        Else
            If title <> "" Then
                If image IsNot Nothing Then
                    Return Content.TitleAndImage
                Else
                    If text <> "" Then
                        Return Content.TitleAndText
                    Else
                        Return Content.TitleOnly
                    End If
                End If
            Else
                If image IsNot Nothing Then
                    If text <> "" Then
                        Return Content.ImageAndText
                    Else
                        Return Content.ImageOnly
                    End If
                Else
                    If text <> "" Then
                        Return Content.TextOnly
                    End If
                End If
            End If
        End If
        Return Content.Empty
    End Function
    ''' <summary>
    ''' Determine if a tooltip information isnot empty.
    ''' </summary>
    ''' <param name="title">Tooltip title.</param>
    ''' <param name="text">Tooltip text.</param>
    ''' <param name="img">Tooltip image.</param>
    ''' <returns>Boolean.</returns>
    Public Shared Function containsToolTip(ByVal title As String, ByVal text As String, ByVal img As Image) As Boolean
        Return (title <> "") Or (text <> "") Or (img IsNot Nothing)
    End Function
    ''' <summary>
    ''' Measure the size of a tooltip based on its contents.
    ''' </summary>
    ''' <param name="title">Tooltip title.</param>
    ''' <param name="text">Tooltip text.</param>
    ''' <param name="img">Tooltip image.</param>
    ''' <returns>Size.</returns>
    Public Shared Function measureSize(ByVal title As String, ByVal text As String, ByVal img As Image) As Size
        Dim result As Size
        Dim lText As Integer = 0
        Dim tSize As Size = New Size(0, 0)
        Dim y As Integer
        Select Case getContent(title, text, img)
            Case Content.All
                tSize = TextRenderer.MeasureText(title, TitleFont)
                result.Width = tSize.Width + 8
                result.Height = tSize.Height + 16 + img.Height
                y = tSize.Height + 14 'default 12
                lText = img.Width + 8
                tSize = TextRenderer.MeasureText(text, TextFont)
                If result.Height < y + tSize.Height + 4 Then
                    result.Height = y + tSize.Height + 4
                End If
                If result.Width < lText + tSize.Width + 4 Then
                    result.Width = lText + tSize.Width + 4
                End If
            Case Content.TitleAndImage
                result.Height = img.Height + 8
                tSize = TextRenderer.MeasureText(title, TitleFont)
                If result.Height < tSize.Height + 8 Then
                    result.Height = tSize.Height + 8
                End If
                result.Width = 12 + img.Width + tSize.Width
            Case Content.TitleAndText
                tSize = TextRenderer.MeasureText(title, TitleFont)
                result.Height = tSize.Height + 12
                result.Width = tSize.Width + 8
                y = tSize.Height + 12
                tSize = TextRenderer.MeasureText(text, TextFont)
                If result.Width < tSize.Width + 8 Then
                    result.Width = tSize.Width + 8
                End If
                result.Height = y + tSize.Height + 4
            Case Content.TitleOnly
                tSize = TextRenderer.MeasureText(title, TitleFont)
                result.Height = tSize.Height + 8
                result.Width = tSize.Width + 8
            Case Content.ImageAndText
                result.Height = img.Height + 8
                tSize = TextRenderer.MeasureText(text, TextFont)
                If result.Height < tSize.Height + 8 Then
                    result.Height = tSize.Height + 8
                End If
                result.Width = 12 + img.Width + tSize.Width
            Case Content.ImageOnly
                result.Width = img.Width + 8
                result.Height = img.Height + 8
            Case Content.TextOnly
                tSize = TextRenderer.MeasureText(text, TextFont)
                result.Height = tSize.Height + 8
                result.Width = tSize.Width + 8
        End Select
        Return result
    End Function
    ''' <summary>
    ''' Draw tooltip information on a tooltip window.
    ''' </summary>
    ''' <param name="title">Tooltip title.</param>
    ''' <param name="text">Tooltip text.</param>
    ''' <param name="img">Tooltip image.</param>
    ''' <param name="g">Graphics object used to paint.</param>
    ''' <param name="rect">Bounding rectangle where tooltip information to be drawn.</param>
    Public Shared Sub drawToolTip(ByVal title As String, ByVal text As String, ByVal img As Image, ByVal g As Graphics, ByVal rect As Rectangle)
        Dim tSize As SizeF
        Dim y As Integer
        With rect
            Select Case getContent(title, text, img)
                Case Content.All
                    g.DrawString(title, TitleFont, TextBrush, .X + 4, .Y + 4)
                    tSize = g.MeasureString(title, TitleFont)
                    y = 8 + tSize.Height
                    g.DrawLine(SeparatorPen, .X + 4, y, .Right - 4, y)
                    g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), .X + 4, y + 1, .Right - 4, y + 1)
                    y = y + 4
                    g.DrawImage(img, .X + 4, y, img.Width, img.Height)
                    g.DrawString(text, TextFont, TextBrush, .X + img.Width + 8, y)
                Case Content.TitleAndImage
                    g.DrawImage(img, .X + 4, .Y + 4, img.Width, img.Height)
                    g.DrawString(title, TitleFont, TextBrush, .X + 8 + img.Width, .Y + 4)
                Case Content.TitleAndText
                    g.DrawString(title, TitleFont, TextBrush, .X + 4, .Y + 4)
                    tSize = g.MeasureString(title, TitleFont)
                    y = 8 + tSize.Height
                    g.DrawLine(SeparatorPen, .X + 4, y, .Right - 4, y)
                    g.DrawLine(New Pen(Color.FromArgb(255, 255, 255)), .X + 4, y + 1, .Right - 4, y + 1)
                    y = y + 4
                    g.DrawString(text, TextFont, TextBrush, .X + 4, y)
                Case Content.TitleOnly
                    g.DrawString(title, TitleFont, TextBrush, .X + 4, .Y + 4)
                Case Content.ImageAndText
                    g.DrawImage(img, .X + 4, .Y + 4, img.Width, img.Height)
                    g.DrawString(text, TextFont, TextBrush, .X + 8 + img.Width, .Y + 4)
                Case Content.ImageOnly
                    g.DrawImage(img, .X + 4, .Y + 4, img.Width, img.Height)
                Case Content.TextOnly
                    g.DrawString(text, TextFont, TextBrush, .X + 4, .Y + 4)
            End Select
        End With
    End Sub
End Class