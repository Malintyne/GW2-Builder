Imports System.Drawing
Imports System.Drawing.Drawing2D
''' <summary>
''' Class for rendering column header.
''' </summary>
Public Class Column
#Region "Color Blend"
    ''' <summary>
    ''' Represent a color blend for a normal column.
    ''' </summary>
    ''' <param name="theme">Theme used to paint.</param>
    ''' <return>ColorBlend</return>
    Public Shared ReadOnly Property NormalBlend(Optional ByVal theme As Drawing.ColorTheme = Drawing.ColorTheme.Blue) _
        As ColorBlend
        Get
            Dim colors(0 To 3) As Color
            Dim pos(0 To 3) As Single
            Dim blend As ColorBlend = New ColorBlend
            pos(0) = 0.0F
            pos(1) = 0.4F
            pos(2) = 0.4F
            pos(3) = 1.0F
            Select Case theme
                Case Drawing.ColorTheme.Blue
                    colors(0) = Color.FromArgb(255, 255, 255)
                    colors(1) = Color.FromArgb(255, 255, 255)
                    colors(2) = Color.FromArgb(246, 247, 249)
                    colors(3) = Color.FromArgb(241, 242, 244)
            End Select
            blend.Colors = colors
            blend.Positions = pos
            Return blend
        End Get
    End Property
    ''' <summary>
    ''' Represent a color blend for a selected column.
    ''' </summary>
    ''' <param name="theme">Theme used to paint.</param>
    ''' <return>ColorBlend</return>
    Public Shared ReadOnly Property SelectedBlend(Optional ByVal theme As Drawing.ColorTheme = Drawing.ColorTheme.Blue) _
        As ColorBlend
        Get
            Dim colors(0 To 3) As Color
            Dim pos(0 To 3) As Single
            Dim blend As ColorBlend = New ColorBlend
            pos(0) = 0.0F
            pos(1) = 0.4F
            pos(2) = 0.4F
            pos(3) = 1.0F
            Select Case theme
                Case Drawing.ColorTheme.Blue
                    colors(0) = Color.FromArgb(242, 249, 252)
                    colors(1) = Color.FromArgb(242, 249, 252)
                    colors(2) = Color.FromArgb(225, 241, 249)
                    colors(3) = Color.FromArgb(216, 236, 246)
            End Select
            blend.Colors = colors
            blend.Positions = pos
            Return blend
        End Get
    End Property
    ''' <summary>
    ''' Represent a color blend for a highlited column.
    ''' </summary>
    ''' <param name="theme">Theme used to paint.</param>
    ''' <return>ColorBlend</return>
    Public Shared ReadOnly Property HLitedBlend(Optional ByVal theme As Drawing.ColorTheme = Drawing.ColorTheme.Blue) _
        As ColorBlend
        Get
            Dim colors(0 To 3) As Color
            Dim pos(0 To 3) As Single
            Dim blend As ColorBlend = New ColorBlend
            pos(0) = 0.0F
            pos(1) = 0.4F
            pos(2) = 0.4F
            pos(3) = 1.0F
            Select Case theme
                Case Drawing.ColorTheme.Blue
                    colors(0) = Color.FromArgb(227, 247, 255)
                    colors(1) = Color.FromArgb(227, 247, 255)
                    colors(2) = Color.FromArgb(189, 237, 255)
                    colors(3) = Color.FromArgb(183, 231, 251)
            End Select
            blend.Colors = colors
            blend.Positions = pos
            Return blend
        End Get
    End Property
    ''' <summary>
    ''' Represent a color blend for a highlited column's dropdown.
    ''' </summary>
    ''' <param name="theme">Theme used to paint.</param>
    ''' <return>ColorBlend</return>
    Public Shared ReadOnly Property HLitedDropDownBlend(Optional ByVal theme As Drawing.ColorTheme = Drawing.ColorTheme.Blue) _
        As ColorBlend
        Get
            Dim colors(0 To 3) As Color
            Dim pos(0 To 3) As Single
            Dim blend As ColorBlend = New ColorBlend
            pos(0) = 0.0F
            pos(1) = 0.4F
            pos(2) = 0.4F
            pos(3) = 1.0F
            Select Case theme
                Case Drawing.ColorTheme.Blue
                    colors(0) = Color.FromArgb(228, 243, 251)
                    colors(1) = Color.FromArgb(186, 224, 244)
                    colors(2) = Color.FromArgb(152, 209, 239)
                    colors(3) = Color.FromArgb(108, 180, 219)
            End Select
            blend.Colors = colors
            blend.Positions = pos
            Return blend
        End Get
    End Property
    ''' <summary>
    ''' Represent a color blend for a pressed column.
    ''' </summary>
    ''' <param name="theme">Theme used to paint.</param>
    ''' <return>ColorBlend</return>
    Public Shared ReadOnly Property PressedBlend(Optional ByVal theme As Drawing.ColorTheme = Drawing.ColorTheme.Blue) _
        As ColorBlend
        Get
            Dim colors(0 To 3) As Color
            Dim pos(0 To 3) As Single
            Dim blend As ColorBlend = New ColorBlend
            pos(0) = 0.0F
            pos(1) = 0.4F
            pos(2) = 0.4F
            pos(3) = 1.0F
            Select Case theme
                Case Drawing.ColorTheme.Blue
                    colors(0) = Color.FromArgb(229, 244, 252)
                    colors(1) = Color.FromArgb(196, 229, 246)
                    colors(2) = Color.FromArgb(152, 209, 239)
                    colors(3) = Color.FromArgb(104, 179, 219)
            End Select
            blend.Colors = colors
            blend.Positions = pos
            Return blend
        End Get
    End Property
#End Region
#Region "Border Pen"
    ''' <summary>
    ''' Represent a pen for a normal column border.
    ''' </summary>
    ''' <param name="theme">Theme used to paint.</param>
    ''' <returns>Pen</returns>
    Public Shared ReadOnly Property NormalBorderPen(Optional ByVal theme As Drawing.ColorTheme = Drawing.ColorTheme.Blue) _
        As Pen
        Get
            Select Case theme
                Case Drawing.ColorTheme.Blue
                    Return New Pen(Color.FromArgb(213, 213, 213))
            End Select
            Return Pens.Black
        End Get
    End Property
    ''' <summary>
    ''' Represent a pen for an active column border.
    ''' </summary>
    ''' <param name="theme">Theme used to paint.</param>
    ''' <returns>Pen</returns>
    Public Shared ReadOnly Property ActiveBorderPen(Optional ByVal theme As Drawing.ColorTheme = Drawing.ColorTheme.Blue) _
        As Pen
        Get
            Select Case theme
                Case Drawing.ColorTheme.Blue
                    Return New Pen(Color.FromArgb(147, 201, 227))
            End Select
            Return Pens.Black
        End Get
    End Property
#End Region
End Class