Public Class Selectfrm2
    Dim cls As New RCls
    Dim x, y As Integer
    Dim newPoint As New Point()

    Private Sub xy_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub xy_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - x
            newPoint.Y = newPoint.Y - y
            Me.Location = newPoint
        End If
    End Sub

    Private Sub Selectfrm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mainfrm.Label9.Text = "g" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "w" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "en" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "r" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "t" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "el" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "m" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "n" Then
            Dim x As Integer = Mainfrm.PictureBox24.Width + 661
            Dim y As Integer = Mainfrm.PictureBox24.Height + 520
            Me.Location = New Point(x, y)
            Size = New Size(221, 103)
            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            Label1.Location = New Point(194, 9)
            PictureBox1.Location = New Point(12, 39)
            PictureBox2.Location = New Point(84, 39)
            PictureBox3.Location = New Point(155, 39)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub
End Class