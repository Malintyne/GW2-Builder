Public Class Mainfrm
    Dim cls As New RCls
    Dim sinfo As New SkillInfo
    Dim x, y As Integer
    Dim newPoint As New Point()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls.MfrmLoad()
        cls.CheckVer()
    End Sub

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
            Me.Cursor = Cursors.SizeAll
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Label6_DoubleClick(sender As Object, e As MouseEventArgs) Handles Label6.DoubleClick
        cls.LblDClick()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        About.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        cls.CmbBox1()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        cls.CmbBox2()
    End Sub

    Private Sub ComboBox3_SeletedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        cls.CmbBox3()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        cls.CmbBox4()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cls.Guardian()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        cls.Warrior()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        cls.Enginner()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        cls.Ranger()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        cls.Thief()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        cls.Elementalist()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        cls.Mesmer()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        cls.Necromancer()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cls.AddPnt1()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cls.RmvPnt1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cls.AddPnt2()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        cls.RmvPnt2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cls.AddPnt3()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        cls.RmvPnt3()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cls.AddPnt4()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        cls.RmvPnt4()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cls.AddPnt5()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        cls.RmvPnt5()
    End Sub

    Private Sub PictureBox82_Click(sender As Object, e As EventArgs) Handles PictureBox82.Click
        Updater.ShowDialog()
    End Sub

    Private Sub Label15_DoubleClick(sender As Object, e As EventArgs) Handles Label15.DoubleClick
        If Label15.Text > 0 Then
            ToolTip1.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset1()
        End If
    End Sub

    Private Sub Label16_DoubleClick(sender As Object, e As EventArgs) Handles Label16.DoubleClick
        If Label16.Text > 0 Then
            ToolTip1.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset2()
        End If
    End Sub

    Private Sub Label17_DoubleClick(sender As Object, e As EventArgs) Handles Label17.DoubleClick
        If Label17.Text > 0 Then
            ToolTip1.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset3()
        End If
    End Sub

    Private Sub Label18_DoubleClick(sender As Object, e As EventArgs) Handles Label18.DoubleClick
        If Label18.Text > 0 Then
            ToolTip1.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset4()
        End If
    End Sub

    Private Sub Label19_DoubleClick(sender As Object, e As EventArgs) Handles Label19.DoubleClick
        If Label19.Text > 0 Then
            ToolTip1.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset5()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        cls.Heal1()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        cls.Heal2()
    End Sub

    Private Sub PictureBox9_MouseHover(sender As Object, e As EventArgs) Handles PictureBox9.MouseHover
        sinfo.SkillInfo9()
    End Sub

    Private Sub PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles PictureBox10.MouseHover
        sinfo.SkillInfo10()
    End Sub

    Private Sub PictureBox29_MouseHover(sender As Object, e As EventArgs) Handles PictureBox29.MouseHover
        sinfo.SkillInfo29()
    End Sub

    Private Sub PictureBox28_MouseHover(sender As Object, e As EventArgs) Handles PictureBox28.MouseHover
        sinfo.SkillInfo28()
    End Sub

    Private Sub PictureBox40_MouseHover(sender As Object, e As EventArgs) Handles PictureBox40.MouseHover
        sinfo.SkillInfo40()
    End Sub

    Private Sub PictureBox14_MouseHover(sender As Object, e As EventArgs) Handles PictureBox14.MouseHover
        sinfo.SkillInfo14()
    End Sub

    Private Sub PictureBox24_MouseHover(sender As Object, e As EventArgs) Handles PictureBox24.MouseHover
        sinfo.SkillInfo24()
    End Sub

    Private Sub PictureBox40_Click(sender As Object, e As EventArgs) Handles PictureBox40.Click
        If Label9.Text = "el" Then
            cls.ResetAttunementChange()
            Label41.Text = "f"
        End If
    End Sub

    Private Sub PictureBox41_Click(sender As Object, e As EventArgs) Handles PictureBox41.Click
        If Label9.Text = "el" Then
            cls.ResetAttunementChange()
            Label41.Text = "w"
        End If
    End Sub

    Private Sub PictureBox42_Click(sender As Object, e As EventArgs) Handles PictureBox42.Click
        If Label9.Text = "el" Then
            cls.ResetAttunementChange()
            Label41.Text = "a"
        End If
    End Sub

    Private Sub PictureBox43_Click(sender As Object, e As EventArgs) Handles PictureBox43.Click
        If Label9.Text = "el" Then
            cls.ResetAttunementChange()
            Label41.Text = "e"
        End If
    End Sub
End Class
