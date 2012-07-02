Public Class Mainfrm
    Dim cls As New RCls
    Dim x, y As Integer
    Dim newPoint As New Point()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls.MfrmLoad()
    End Sub

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

    Private Sub Label6_DoubleClick(sender As Object, e As MouseEventArgs) Handles Label6.DoubleClick
        cls.LblClick()
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
        Label9.Text = "g"
        PictureBox1.Image = My.Resources.guardian
        PictureBox2.Image = My.Resources.warrior_off
        PictureBox3.Image = My.Resources.engineer_off
        PictureBox4.Image = My.Resources.ranger_off
        PictureBox5.Image = My.Resources.thief_off
        PictureBox6.Image = My.Resources.elementalist_off
        PictureBox7.Image = My.Resources.mesmer_off
        PictureBox8.Image = My.Resources.necromancer_off

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Hammer") 'Hammer - Two Hand #1
        ComboBox1.Items.Insert(1, "Staff") 'Staff - Two Hand #1
        ComboBox1.Items.Insert(2, "Greatsword") 'Greatsword - Two Hand #1
        ComboBox1.Items.Insert(3, "Sword") 'Sword - One Hand #1
        ComboBox1.Items.Insert(4, "Scepter") 'Scepter - One Hand #1
        ComboBox1.Items.Insert(5, "Mace") 'Mace - One Hand #1

        ComboBox2.Items.Insert(0, "Hammer") 'Hammer - Two Hand #2
        ComboBox2.Items.Insert(1, "Staff") 'Staff - Two Hand #2
        ComboBox2.Items.Insert(2, "Greatsword") 'Greatsword - Two Hand #2
        ComboBox2.Items.Insert(3, "Sword") 'Sword - One Hand #
        ComboBox2.Items.Insert(4, "Scepter") 'Scepter - One Hand #2
        ComboBox2.Items.Insert(5, "Mace") 'Mace - One Hand #2

        ComboBox3.Items.Insert(0, "Shield") 'Shield - Off Hand #3
        ComboBox3.Items.Insert(1, "Focus") 'Focus - Off Hand #3
        ComboBox3.Items.Insert(2, "Torch") 'Torch - Off Hand #3

        ComboBox4.Items.Insert(0, "Shield") 'Shield - Off Hand #4
        ComboBox4.Items.Insert(1, "Focus") 'Focus - Off Hand #4
        ComboBox4.Items.Insert(2, "Torch") 'Torch - Off Hand #4
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Label9.Text = "w"
        PictureBox1.Image = My.Resources.guardian_off
        PictureBox2.Image = My.Resources.warrior
        PictureBox3.Image = My.Resources.engineer_off
        PictureBox4.Image = My.Resources.ranger_off
        PictureBox5.Image = My.Resources.thief_off
        PictureBox6.Image = My.Resources.elementalist_off
        PictureBox7.Image = My.Resources.mesmer_off
        PictureBox8.Image = My.Resources.necromancer_off

        cls.ResetImage()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Hammer") 'Hammer - Two Hand #1
        ComboBox1.Items.Insert(1, "Greatsword") 'Greatsword - Two Hand #1
        ComboBox1.Items.Insert(2, "Longbow") 'Longbow - Two Hand #1
        ComboBox1.Items.Insert(3, "Rifle") 'Rifle - Two Hand #1
        ComboBox1.Items.Insert(4, "Axe") 'Axe - One Hand #1
        ComboBox1.Items.Insert(5, "Sword") 'Sword - One Hand #1
        ComboBox1.Items.Insert(6, "Mace") 'Mace - One Hand #1

        ComboBox2.Items.Insert(0, "Hammer") 'Hammer - Two Hand #2
        ComboBox2.Items.Insert(1, "Greatsword") 'Greatsword - Two Hand #2
        ComboBox2.Items.Insert(2, "Longbow") 'Longbow - Two Hand #2
        ComboBox2.Items.Insert(3, "Rifle") 'Rifle - Two Hand #2
        ComboBox2.Items.Insert(4, "Sword") 'Sword - One Hand #2
        ComboBox2.Items.Insert(5, "Axe") 'Axe - One Hand #2
        ComboBox2.Items.Insert(6, "Mace") 'Mace - One Hand #2

        ComboBox3.Items.Insert(0, "Sword") 'Sword - One Hand #3
        ComboBox3.Items.Insert(1, "Shield") 'Shield - Off Hand #3
        ComboBox3.Items.Insert(2, "Axe") 'Axe - One Hand #3
        ComboBox3.Items.Insert(3, "Warhorn") 'Warhorn - Off Hand #3
        ComboBox3.Items.Insert(4, "Mace") 'Mace - One Hand #3

        ComboBox4.Items.Insert(0, "Sword") 'Sword - One Hand #4
        ComboBox4.Items.Insert(1, "Shield") 'Shield - Off Hand #4
        ComboBox4.Items.Insert(2, "Axe") 'Axe - One Hand #4
        ComboBox4.Items.Insert(3, "Warhorn") 'Warhorn - Off Hand #4
        ComboBox4.Items.Insert(4, "Mace") 'Mace - One Hand #4
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Label9.Text = "en"
        PictureBox1.Image = My.Resources.guardian_off
        PictureBox2.Image = My.Resources.warrior_off
        PictureBox3.Image = My.Resources.engineer
        PictureBox4.Image = My.Resources.ranger_off
        PictureBox5.Image = My.Resources.thief_off
        PictureBox6.Image = My.Resources.elementalist_off
        PictureBox7.Image = My.Resources.mesmer_off
        PictureBox8.Image = My.Resources.necromancer_off

        cls.ResetImage()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Rifle") 'Rifle - Two Hand #1
        ComboBox1.Items.Insert(1, "Pistol") 'Pistol - One Hand #1

        ComboBox2.Items.Insert(0, "Rifle") 'Rifle - Two Hand #2
        ComboBox2.Items.Insert(1, "Pistol") 'Pistol - One Hand #2

        ComboBox3.Items.Insert(0, "Shield") 'Shield - One Hand #3
        ComboBox3.Items.Insert(1, "Pistol") 'Pistol - One Hand #3

        ComboBox4.Items.Insert(0, "Shield") 'Shield - One Hand #4
        ComboBox4.Items.Insert(1, "Pistol") 'Pistol - One Hand #4
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Label9.Text = "r"
        PictureBox1.Image = My.Resources.guardian_off
        PictureBox2.Image = My.Resources.warrior_off
        PictureBox3.Image = My.Resources.engineer_off
        PictureBox4.Image = My.Resources.ranger
        PictureBox5.Image = My.Resources.thief_off
        PictureBox6.Image = My.Resources.elementalist_off
        PictureBox7.Image = My.Resources.mesmer_off
        PictureBox8.Image = My.Resources.necromancer_off

        cls.ResetImage()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #1
        ComboBox1.Items.Insert(1, "Longbow") 'Longbow - Two Hand #1
        ComboBox1.Items.Insert(2, "Shortbow") 'Shortbow - Two Hand #1
        ComboBox1.Items.Insert(3, "Sword") 'Sword - One Hand #1
        ComboBox1.Items.Insert(4, "Axe") 'Axe - One Hand #1

        ComboBox2.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #2
        ComboBox2.Items.Insert(1, "Longbow") 'Longbow - Two Hand #2
        ComboBox2.Items.Insert(2, "Shortbow") 'Shortbow - Two Hand #2
        ComboBox2.Items.Insert(3, "Sword") 'Sword - One Hand #2
        ComboBox2.Items.Insert(4, "Axe") 'Axe - One Hand #2

        ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        ComboBox3.Items.Insert(1, "Axe") 'Axe - One Hand #3
        ComboBox3.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #3
        ComboBox3.Items.Insert(3, "Torch") 'Torch - One Hand #3

        ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        ComboBox4.Items.Insert(1, "Axe") 'Axe - One Hand #4
        ComboBox4.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #4
        ComboBox4.Items.Insert(3, "Torch") 'Torch - One Hand #4
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Label9.Text = "t"
        PictureBox1.Image = My.Resources.guardian_off
        PictureBox2.Image = My.Resources.warrior_off
        PictureBox3.Image = My.Resources.engineer_off
        PictureBox4.Image = My.Resources.ranger_off
        PictureBox5.Image = My.Resources.thief
        PictureBox6.Image = My.Resources.elementalist_off
        PictureBox7.Image = My.Resources.mesmer_off
        PictureBox8.Image = My.Resources.necromancer_off

        cls.ResetImage()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Shortbow") 'Shortbow - Two Hand #1
        ComboBox1.Items.Insert(1, "Sword") 'Sword - One Hand #1
        ComboBox1.Items.Insert(2, "Dagger") 'Dagger - One Hand #1
        ComboBox1.Items.Insert(3, "Pistol") 'Pistol - One Hand #1

        ComboBox2.Items.Insert(0, "Shortbow") 'Shortbow - Two Hand #2
        ComboBox2.Items.Insert(1, "Sword") 'Sword - One Hand #2
        ComboBox2.Items.Insert(2, "Dagger") 'Dagger - One Hand #2
        ComboBox2.Items.Insert(3, "Pistol") 'Pistol - One Hand #2

        ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        ComboBox3.Items.Insert(1, "Pistol") 'Pistol - One Hand #3

        ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        ComboBox4.Items.Insert(1, "Pistol") 'Pistol - One Hand #4
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Label9.Text = "el"
        PictureBox1.Image = My.Resources.guardian_off
        PictureBox2.Image = My.Resources.warrior_off
        PictureBox3.Image = My.Resources.engineer_off
        PictureBox4.Image = My.Resources.ranger_off
        PictureBox5.Image = My.Resources.thief_off
        PictureBox6.Image = My.Resources.elementalist
        PictureBox7.Image = My.Resources.mesmer_off
        PictureBox8.Image = My.Resources.necromancer_off

        cls.ResetImage()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Staff") 'Staff - Two Hand #1
        ComboBox1.Items.Insert(1, "Dagger") 'Dagger - One Hand #1
        ComboBox1.Items.Insert(2, "Scepter") 'Scepter - One Hand #1

        ComboBox2.Items.Insert(0, "Staff") 'Staff - Two Hand #2
        ComboBox2.Items.Insert(1, "Dagger") 'Dagger - One Hand #2
        ComboBox2.Items.Insert(2, "Scepter") 'Scepter - One Hand #2

        ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        ComboBox3.Items.Insert(1, "Focus") 'Focus - One Hand #3

        ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        ComboBox4.Items.Insert(1, "Focus") 'Focus - One Hand #4
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Label9.Text = "m"
        PictureBox1.Image = My.Resources.guardian_off
        PictureBox2.Image = My.Resources.warrior_off
        PictureBox3.Image = My.Resources.engineer_off
        PictureBox4.Image = My.Resources.ranger_off
        PictureBox5.Image = My.Resources.thief_off
        PictureBox6.Image = My.Resources.elementalist_off
        PictureBox7.Image = My.Resources.mesmer
        PictureBox8.Image = My.Resources.necromancer_off

        cls.ResetImage()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #1
        ComboBox1.Items.Insert(1, "Staff") 'Staff - Two Hand #1
        ComboBox1.Items.Insert(2, "Sword") 'Sword - One Hand #1
        ComboBox1.Items.Insert(3, "Scepter") 'Scepter - One Hand #1

        ComboBox2.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #2
        ComboBox2.Items.Insert(1, "Staff") 'Staff - Two Hand #2
        ComboBox2.Items.Insert(2, "Sword") 'Sword - One Hand #2
        ComboBox2.Items.Insert(3, "Scepter") 'Scepter - One Hand #2

        ComboBox3.Items.Insert(0, "Sword") 'Sword - One Hand #3
        ComboBox3.Items.Insert(1, "Focus") 'Focus - One Hand #3
        ComboBox3.Items.Insert(2, "Pistol") 'Pistol - One Hand #3
        ComboBox3.Items.Insert(3, "Torch") 'Torch - One Hand #3

        ComboBox4.Items.Insert(0, "Sword") 'Sword - One Hand #4
        ComboBox4.Items.Insert(1, "Focus") 'Focus - One Hand #4
        ComboBox4.Items.Insert(2, "Pistol") 'Pistol - One Hand #4
        ComboBox4.Items.Insert(3, "Torch") 'Torch - One Hand #4
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Label9.Text = "n"
        PictureBox1.Image = My.Resources.guardian_off
        PictureBox2.Image = My.Resources.warrior_off
        PictureBox3.Image = My.Resources.engineer_off
        PictureBox4.Image = My.Resources.ranger_off
        PictureBox5.Image = My.Resources.thief_off
        PictureBox6.Image = My.Resources.elementalist_off
        PictureBox7.Image = My.Resources.mesmer_off
        PictureBox8.Image = My.Resources.necromancer

        cls.ResetImage()

        ComboBox1.Items.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.Items.Clear()
        ComboBox4.Items.Clear()

        ComboBox1.Enabled = True
        ComboBox2.Enabled = True
        ComboBox3.Enabled = False
        ComboBox4.Enabled = False

        ComboBox1.Text = "Main Hand"
        ComboBox2.Text = "Main Hand"
        ComboBox3.Text = "Off Hand"
        ComboBox4.Text = "Off Hand"

        ComboBox1.Items.Insert(0, "Staff") 'Staff - Two Hand #1
        ComboBox1.Items.Insert(1, "Dagger") 'Dagger - One Hand #1
        ComboBox1.Items.Insert(2, "Axe") 'Axe - One Hand #1
        ComboBox1.Items.Insert(3, "Scepter") 'Scepter - One Hand #1

        ComboBox2.Items.Insert(0, "Staff") 'Staff - Two Hand #2
        ComboBox2.Items.Insert(1, "Dagger") 'Dagger - One Hand #2
        ComboBox2.Items.Insert(2, "Axe") 'Axe - One Hand #2
        ComboBox2.Items.Insert(3, "Scepter") 'Scepter - One Hand #2

        ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        ComboBox3.Items.Insert(1, "Focus") 'Focus - One Hand #3
        ComboBox3.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #3

        ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        ComboBox4.Items.Insert(1, "Focus") 'Focus - One Hand #4
        ComboBox4.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #4
    End Sub
End Class
