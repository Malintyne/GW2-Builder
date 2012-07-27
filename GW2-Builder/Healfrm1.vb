Public Class Healfrm1
    Dim cls As New RCls
    Dim x, y As Integer
    Dim newPoint As New Point()

    Private Sub MyBase_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub MyBase_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - x
            newPoint.Y = newPoint.Y - y
            Me.Location = newPoint
        End If
    End Sub

    Private Sub Selectfrm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls.SfrmLoad()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Mainfrm.PictureBox14.Image = PictureBox1.Image
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.PictureBox14.Tag = "Shelter"
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.PictureBox14.Tag = "Healing Surge"
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.PictureBox14.Tag = "Healing Turret"
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.PictureBox14.Tag = "Healing Spring"
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.PictureBox14.Tag = "Signet of Malice"
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.PictureBox14.Tag = "Glyph of Elemental Harmony"
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.PictureBox14.Tag = "Mirror"
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.PictureBox14.Tag = "Summon Blood Fiend"
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Mainfrm.PictureBox14.Image = PictureBox2.Image
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.PictureBox14.Tag = "Signet of Resolve"
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.PictureBox14.Tag = "Mending"
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.PictureBox14.Tag = "Med Kit"
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.PictureBox14.Tag = "Troll Unguent"
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.PictureBox14.Tag = "Withdraw"
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.PictureBox14.Tag = "Signet of Restoration"
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.PictureBox14.Tag = "Mantra of Recovery"
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.PictureBox14.Tag = "Well of Blood"
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Mainfrm.PictureBox14.Image = PictureBox3.Image
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.PictureBox14.Tag = "Healing Breeze"
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.PictureBox14.Tag = "Signet of Resolve"
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.PictureBox14.Tag = "Elixir H"
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.PictureBox14.Tag = "Heal as One"
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.PictureBox14.Tag = "Hide in Shadows"
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.PictureBox14.Tag = "Ether Renewal"
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.PictureBox14.Tag = "Ether Feast"
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.PictureBox14.Tag = "Consume Conditions"
        End If
        Me.Close()
    End Sub
End Class