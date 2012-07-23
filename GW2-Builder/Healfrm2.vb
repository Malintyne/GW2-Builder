Public Class Healfrm2
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
        cls.SfrmLoad()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Mainfrm.PictureBox14.Image = PictureBox1.Image
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Mainfrm.PictureBox14.Image = PictureBox2.Image
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Mainfrm.PictureBox14.Image = PictureBox3.Image
        Me.Close()
    End Sub
End Class