Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class CheckBox
    ''' <summary>
    ''' Draw a box of a checkbox on x, y coordinate.
    ''' </summary>
    ''' <param name="g">Graphics object where the box to be drawn.</param>
    ''' <param name="x">X location of the box.</param>
    ''' <param name="y">Y location of the box.</param>
    ''' <param name="size">Size of the box.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    ''' <param name="hLited">Determine whether checkbox is highlited.</param>
    Public Shared Sub drawBox(ByVal g As Graphics, ByVal x As Integer, ByVal y As Integer, _
        Optional ByVal size As Integer = 14, Optional ByVal enabled As Boolean = True, _
        Optional ByVal hLited As Boolean = False)
        If size > 0 Then
            Dim rectBox As Rectangle = New Rectangle(x, y, size, size)
            g.FillRectangle(Brushes.White, rectBox)
            If enabled And hLited Then
                g.DrawRectangle(New Pen(Color.FromArgb(62, 106, 170)), rectBox)
            Else
                g.DrawRectangle(New Pen(Color.FromArgb(142, 143, 143)), rectBox)
            End If
            If enabled And size > 6 Then
                Dim innerRect As Rectangle = New Rectangle(x + 2, y + 2, size - 4, size - 4)
                Dim brushRect As Rectangle = New Rectangle(x + 1, y + 1, size - 2, size - 2)
                Dim borderBrush As LinearGradientBrush = New LinearGradientBrush(brushRect, Color.FromArgb(174, 179, 185), _
                    Color.FromArgb(233, 233, 234), 45)
                Dim fillBrush As LinearGradientBrush = New LinearGradientBrush(brushRect, Color.Black, _
                    Color.White, 45)
                Dim fillColors(0 To 2) As Color
                Dim fillPos(0 To 2) As Single
                Dim fillBlend As ColorBlend = New ColorBlend
                If hLited Then
                    fillColors(0) = Color.Yellow
                    fillColors(1) = Color.FromArgb(232, 232, 232)
                Else
                    fillColors(0) = Color.FromArgb(203, 207, 213)
                    fillColors(1) = Color.FromArgb(232, 232, 232)
                End If
                fillColors(2) = Color.FromArgb(246, 246, 246)
                fillPos(0) = 0.0F
                fillPos(1) = 0.5F
                fillPos(2) = 1.0F
                fillBlend.Colors = fillColors
                fillBlend.Positions = fillPos
                fillBrush.InterpolationColors = fillBlend
                g.FillRectangle(fillBrush, innerRect)
                g.DrawRectangle(New Pen(borderBrush), innerRect)
                borderBrush.Dispose()
                fillBrush.Dispose()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Draw a box of a checkbox on p location.
    ''' </summary>
    ''' <param name="g">Graphics object where the box to be drawn.</param>
    ''' <param name="p">Location of the box.</param>
    ''' <param name="size">Size of the box.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    ''' <param name="hLited">Determine whether checkbox is highlited.</param>
    Public Shared Sub drawBox(ByVal g As Graphics, ByVal p As Point, _
        Optional ByVal size As Integer = 14, Optional ByVal enabled As Boolean = True, _
        Optional ByVal hLited As Boolean = False)
        drawBox(g, p.X, p.Y, size, enabled, hLited)
    End Sub
    ''' <summary>
    ''' Draw a box of a checkbox in the center of a rectangle.
    ''' </summary>
    ''' <param name="g">Graphics object where the box to be drawn.</param>
    ''' <param name="rect">Rectangle where the box to be drawn.</param>
    ''' <param name="size">Size of the box.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    ''' <param name="hLited">Determine whether checkbox is highlited.</param>
    Public Shared Sub drawBox(ByVal g As Graphics, ByVal rect As Rectangle, _
        Optional ByVal size As Integer = 14, Optional ByVal enabled As Boolean = True, _
        Optional ByVal hLited As Boolean = False)
        Dim x As Integer = rect.X + ((rect.Width - size) / 2)
        Dim y As Integer = rect.Y + ((rect.Height - size) / 2)
        drawBox(g, x, y, size, enabled, hLited)
    End Sub
    ''' <summary>
    ''' Draw a check of a checkbox on x, y coordinate.
    ''' </summary>
    ''' <param name="g">Graphics object where the check to be drawn.</param>
    ''' <param name="x">X location of the check.</param>
    ''' <param name="y">Y location of the check.</param>
    ''' <param name="state">State of the check.</param>
    ''' <param name="size">Size of the check.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    Public Shared Sub drawCheck(ByVal g As Graphics, ByVal x As Integer, ByVal y As Integer, _
        Optional ByVal state As CheckState = CheckState.Checked, _
        Optional ByVal size As Integer = 8, Optional ByVal enabled As Boolean = True)
        If size > 4 Then
            Select Case state
                Case CheckState.Checked
                    Dim points(0 To 2) As Point
                    points(0) = New Point(x + 1, y + (size / 2))
                    points(1) = New Point(x + (size / 2), y + size - 1)
                    points(2) = New Point(x + size - 1, y + 1)
                    If enabled Then
                        g.DrawLines(New Pen(Color.FromArgb(62, 106, 170), 2), points)
                    Else
                        g.DrawLines(New Pen(Color.DimGray, 2), points)
                    End If
                Case CheckState.Indeterminate
                    Dim innerRect As Rectangle = New Rectangle(x + 1, y + 1, size - 2, size - 2)
                    Dim brush As LinearGradientBrush
                    If enabled Then
                        brush = New LinearGradientBrush(innerRect, Color.Chartreuse, Color.Green, 45)
                    Else
                        brush = New LinearGradientBrush(innerRect, Color.Silver, Color.Gray, 45)
                    End If
                    g.FillRectangle(brush, innerRect)
                    brush.Dispose()
            End Select
        End If
    End Sub
    ''' <summary>
    ''' Draw a check of a checkbox on p location.
    ''' </summary>
    ''' <param name="g">Graphics object where the check to be drawn.</param>
    ''' <param name="p">P location of the check.</param>
    ''' <param name="state">State of the check.</param>
    ''' <param name="size">Size of the check.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    Public Shared Sub drawCheck(ByVal g As Graphics, ByVal p As Point, _
        Optional ByVal state As CheckState = CheckState.Checked, _
        Optional ByVal size As Integer = 8, Optional ByVal enabled As Boolean = True)
        drawCheck(g, p.X, p.Y, state, size, enabled)
    End Sub
    ''' <summary>
    ''' Draw a check of a checkbox inside a rectangle.
    ''' </summary>
    ''' <param name="g">Graphics object where the check to be drawn.</param>
    ''' <param name="rect">Rectangle where the check to be drawn.</param>
    ''' <param name="state">State of the check.</param>
    ''' <param name="size">Size of the check.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    Public Shared Sub drawCheck(ByVal g As Graphics, ByVal rect As Rectangle, _
        Optional ByVal state As CheckState = CheckState.Checked, _
        Optional ByVal size As Integer = 8, Optional ByVal enabled As Boolean = True)
        Dim x As Integer = rect.X + ((rect.Width - size) / 2)
        Dim y As Integer = rect.Y + ((rect.Y - size) / 2)
        drawCheck(g, x, y, state, size, enabled)
    End Sub
    ''' <summary>
    ''' Draw a CheckBox on x, y coordinate.
    ''' </summary>
    ''' <param name="g">Graphics object where the CheckBox to be drawn.</param>
    ''' <param name="x">X location of the CheckBox.</param>
    ''' <param name="y">Y location of the CheckBox.</param>
    ''' <param name="state">CheckState of the CheckBox.</param>
    ''' <param name="size">Size of the CheckBox.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    ''' <param name="hLited">Determine whether checkbox is highlited.</param>
    ''' <remarks>Minimum value of size is 8.</remarks>
    Public Shared Sub drawCheckBox(ByVal g As Graphics, ByVal x As Integer, ByVal y As Integer, _
        Optional ByVal state As CheckState = CheckState.Checked, _
        Optional ByVal size As Integer = 14, Optional ByVal enabled As Boolean = True, _
        Optional ByVal hLited As Boolean = False)
        If size > 8 Then
            drawBox(g, x, y, size, enabled, hLited)
            drawCheck(g, x + 2, y + 2, state, size - 4, enabled)
        End If
    End Sub
    ''' <summary>
    ''' Draw a CheckBox on p location.
    ''' </summary>
    ''' <param name="g">Graphics object where the CheckBox to be drawn.</param>
    ''' <param name="p">Location of the CheckBox.</param>
    ''' <param name="state">CheckState of the CheckBox.</param>
    ''' <param name="size">Size of the CheckBox.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    ''' <param name="hLited">Determine whether checkbox is highlited.</param>
    ''' <remarks>Minimum value of size is 8.</remarks>
    Public Shared Sub drawCheckBox(ByVal g As Graphics, ByVal p As Point, _
        Optional ByVal state As CheckState = CheckState.Checked, _
        Optional ByVal size As Integer = 14, Optional ByVal enabled As Boolean = True, _
        Optional ByVal hLited As Boolean = False)
        If size > 8 Then
            drawBox(g, p.X, p.Y, size, enabled, hLited)
            drawCheck(g, p.X + 2, p.Y + 2, state, size - 4, enabled)
        End If
    End Sub
    ''' <summary>
    ''' Draw a CheckBox inside a rectangle.
    ''' </summary>
    ''' <param name="g">Graphics object where the CheckBox to be drawn.</param>
    ''' <param name="rect">Rectangle where the CheckBox to be drawn.</param>
    ''' <param name="state">CheckState of the CheckBox.</param>
    ''' <param name="size">Size of the CheckBox.</param>
    ''' <param name="enabled">Determine whether checkbox is enabled.</param>
    ''' <param name="hLited">Determine whether checkbox is highlited.</param>
    ''' <remarks>Minimum value of size is 8.</remarks>
    Public Shared Sub drawCheckBox(ByVal g As Graphics, ByVal rect As Rectangle, _
        Optional ByVal state As CheckState = CheckState.Checked, _
        Optional ByVal size As Integer = 14, Optional ByVal enabled As Boolean = True, _
        Optional ByVal hLited As Boolean = False)
        If size > 8 Then
            Dim x As Integer = rect.X + ((rect.Width - size) / 2)
            Dim y As Integer = rect.Y + ((rect.Height - size) / 2)
            drawBox(g, x, y, size, enabled, hLited)
            drawCheck(g, x + 2, y + 2, state, size - 4, enabled)
        End If
    End Sub
End Class