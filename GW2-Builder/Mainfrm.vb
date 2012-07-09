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

        cls.ResetImage()

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox40.Visible = True
        PictureBox41.Visible = True
        PictureBox42.Visible = True
        PictureBox43.Visible = False
        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

        PictureBox40.Image = My.Resources.Virtue_of_Justice
        PictureBox41.Image = My.Resources.Virtue_of_Resolve
        PictureBox42.Image = My.Resources.Virtue_of_Courage
        PictureBox44.Image = My.Resources.Zeal___Guardian
        PictureBox45.Image = My.Resources.Radiance___Guardian
        PictureBox46.Image = My.Resources.Valor___Guardian
        PictureBox47.Image = My.Resources.Honor___Guardian
        PictureBox48.Image = My.Resources.Virtues___Guardian

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Concentration
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Expertise
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Prowess
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Compassion
        PictureBox68.Image = My.Resources.Malice
        PictureBox67.Image = My.Resources.Willpower

        ToolTip2.SetToolTipTitle(PictureBox40, "Virtue of Justice")
        ToolTip2.SetToolTipTitle(PictureBox41, "Virtue of Resolve")
        ToolTip2.SetToolTipTitle(PictureBox42, "Virtue of Courage")

        ToolTip2.SetToolTipImage(PictureBox40, PictureBox40.Image)
        ToolTip2.SetToolTipImage(PictureBox41, PictureBox41.Image)
        ToolTip2.SetToolTipImage(PictureBox42, PictureBox42.Image)

        ToolTip2.SetToolTip(PictureBox40, "Virtue: Burn foes with every fifth attacks." & vbCrLf & "Activate: Grant Burning to you and nearby allies next attack." _
                            & vbCrLf & "Burning (passive effect)(1s): 4 damage" & vbCrLf & "Burning (active effect)(5s): 4 damage")
        ToolTip2.SetToolTip(PictureBox41, "Virtue: Regenerate health." & vbCrLf & "Activate: Heal yourself and nearby allies." _
                            & vbCrLf & "Passive Renegeration: 3 seconds" & vbCrLf & "Healing: 25")
        ToolTip2.SetToolTip(PictureBox42, "Virtue: Grants Aegis every 40 seconds." & vbCrLf & "Activate: Grant Aegis to yourself and nearby allies." _
                            & vbCrLf & "Aegis(5s): Block the next incoming attack")

        ToolTip2.SetToolTip(PictureBox1, "Click to reset the traits")
        ToolTip2.SetToolTip(PictureBox2, vbNullString)
        ToolTip2.SetToolTip(PictureBox3, vbNullString)
        ToolTip2.SetToolTip(PictureBox4, vbNullString)
        ToolTip2.SetToolTip(PictureBox5, vbNullString)
        ToolTip2.SetToolTip(PictureBox6, vbNullString)
        ToolTip2.SetToolTip(PictureBox7, vbNullString)
        ToolTip2.SetToolTip(PictureBox8, vbNullString)

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        ToolTip2.SetToolTip(PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        ToolTip2.SetToolTip(PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Virtues Recharge rate by 1%")
        ToolTip2.SetToolTip(PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases Virtues Recharge rate by 1%")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(PictureBox68, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(PictureBox67, "Increases Virtues Recharge rate by " + Label29.Text + "%")

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(Label28, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(Label29, "Increases Virtues Recharge rate by " + Label29.Text + "%")

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

        Label10.Text = "Zeal"
        Label11.Text = "Radiance"
        Label12.Text = "Valor"
        Label13.Text = "Honor"
        Label14.Text = "Virtues"
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

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

        PictureBox44.Image = My.Resources.Strength___Warrior
        PictureBox45.Image = My.Resources.Arms___Warrior
        PictureBox46.Image = My.Resources.Defense___Warrior
        PictureBox47.Image = My.Resources.Tactics___Warrior
        PictureBox48.Image = My.Resources.Discipline___Warrior

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Expertise
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Malice
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Compassion
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Concentration
        PictureBox68.Image = My.Resources.Prowess
        PictureBox67.Image = My.Resources.Brawn

        ToolTip2.SetToolTip(PictureBox1, vbNullString)
        ToolTip2.SetToolTip(PictureBox2, "Click to reset the traits")
        ToolTip2.SetToolTip(PictureBox3, vbNullString)
        ToolTip2.SetToolTip(PictureBox4, vbNullString)
        ToolTip2.SetToolTip(PictureBox5, vbNullString)
        ToolTip2.SetToolTip(PictureBox6, vbNullString)
        ToolTip2.SetToolTip(PictureBox7, vbNullString)
        ToolTip2.SetToolTip(PictureBox8, vbNullString)

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases Burst Skill damage by 1")
        ToolTip2.SetToolTip(PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases Burst Skill damage by 1")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition duration by " + Label21.Text + "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases condition damage by " + Label23.Text + "%")
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases healing by " + Label25.Text)
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases boon duration by " + Label27.Text + "%")
        ToolTip2.SetToolTip(PictureBox68, "Increases critical damage by " + Label28.Text)
        ToolTip2.SetToolTip(PictureBox67, "Increases Burst Skill damage by " + Label29.Text)

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " + Label21.Text + "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition damage by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases healing by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases boon duration by " + Label27.Text + "%")
        ToolTip2.SetToolTip(Label28, "Increases critical damage by " + Label28.Text)
        ToolTip2.SetToolTip(Label29, "Increases Burst Skill damage by " + Label29.Text)

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

        Label10.Text = "Strength"
        Label11.Text = "Arms"
        Label12.Text = "Defense"
        Label13.Text = "Tactics"
        Label14.Text = "Discipline"
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

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

        PictureBox44.Image = My.Resources.Explosives___Engineer
        PictureBox45.Image = My.Resources.Firearms___Engineer
        PictureBox46.Image = My.Resources.Inventions___Engineer
        PictureBox47.Image = My.Resources.Alchemy___Engineer
        PictureBox48.Image = My.Resources.Tools___Engineer

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Expertise
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Malice
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Compassion
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Concentration
        PictureBox68.Image = My.Resources.Prowess
        PictureBox67.Image = My.Resources.Ingenuity

        ToolTip2.SetToolTip(PictureBox1, vbNullString)
        ToolTip2.SetToolTip(PictureBox2, vbNullString)
        ToolTip2.SetToolTip(PictureBox3, "Click to reset the traits")
        ToolTip2.SetToolTip(PictureBox4, vbNullString)
        ToolTip2.SetToolTip(PictureBox5, vbNullString)
        ToolTip2.SetToolTip(PictureBox6, vbNullString)
        ToolTip2.SetToolTip(PictureBox7, vbNullString)
        ToolTip2.SetToolTip(PictureBox8, vbNullString)

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases recharge rate of Tool Belt skills by 1%")
        ToolTip2.SetToolTip(PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases recharge rate of Tool Belt skills by 1%")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition duration by " + Label21.Text + "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases condition damage by " + Label23.Text + "%")
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases healing by " + Label25.Text)
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases boon duration by " + Label27.Text + "%")
        ToolTip2.SetToolTip(PictureBox68, "Increases critical damage by " + Label28.Text)
        ToolTip2.SetToolTip(PictureBox67, "Increases recharge rate of Tool Belt skills by " + Label29.Text + "%")

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(Label28, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(Label29, "Increases Virtues Recharge rate by " + Label29.Text + "%")

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

        Label10.Text = "Explosives"
        Label11.Text = "Firearms"
        Label12.Text = "Inventions"
        Label13.Text = "Alchemy"
        Label14.Text = "Tools"
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

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

        PictureBox44.Image = My.Resources.Markmanship___Ranger
        PictureBox45.Image = My.Resources.Skirmishing___Ranger
        PictureBox46.Image = My.Resources.Wildnerness___Ranger
        PictureBox47.Image = My.Resources.Nature___Ranger
        PictureBox48.Image = My.Resources.Beastmastery___Ranger	

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Expertise
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Concentration
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Malice
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Concentration
        PictureBox68.Image = My.Resources.Compassion
        PictureBox67.Image = My.Resources.Empathy

        ToolTip2.SetToolTip(PictureBox1, vbNullString)
        ToolTip2.SetToolTip(PictureBox2, vbNullString)
        ToolTip2.SetToolTip(PictureBox3, vbNullString)
        ToolTip2.SetToolTip(PictureBox4, "Click to reset the traits")
        ToolTip2.SetToolTip(PictureBox5, vbNullString)
        ToolTip2.SetToolTip(PictureBox6, vbNullString)
        ToolTip2.SetToolTip(PictureBox7, vbNullString)
        ToolTip2.SetToolTip(PictureBox8, vbNullString)

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox58, "Increases healing by 10" & vbCrLf & "Increases Pet Attributes by 1%")
        ToolTip2.SetToolTip(PictureBox57, "Decreases healing by 10" & vbCrLf & "Decreases Pet Attributes by 1%")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition duration by " + Label21.Text + "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases critical damage by " + Label23.Text)
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases condition damage by " + Label25.Text + "%")
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases boon duration by " + Label27.Text + "%")
        ToolTip2.SetToolTip(PictureBox68, "Increases healing by " + Label28.Text)
        ToolTip2.SetToolTip(PictureBox67, "Increases Pet Attributes by " + Label29.Text + "%")

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(Label28, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(Label29, "Increases Virtues Recharge rate by " + Label29.Text + "%")

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

        Label10.Text = "Marksmanship"
        Label11.Text = "Skirmishing"
        Label12.Text = "Wilderness Survival"
        Label13.Text = "Nature Magic"
        Label14.Text = "Beastmastery"

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

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

		PictureBox44.Image = My.Resources.Deadly___Thief
        PictureBox45.Image = My.Resources.Critical___Thief
        PictureBox46.Image = My.Resources.Shadow__Thief
        PictureBox47.Image = My.Resources.Acrobatics___Thief
        PictureBox48.Image = My.Resources.Trickery___Thief	

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Expertise
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Prowess
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Compassion
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Concentration
        PictureBox68.Image = My.Resources.Malice
        PictureBox67.Image = My.Resources.Cunning

        ToolTip2.SetToolTip(PictureBox1, vbNullString)
        ToolTip2.SetToolTip(PictureBox2, vbNullString)
        ToolTip2.SetToolTip(PictureBox3, vbNullString)
        ToolTip2.SetToolTip(PictureBox4, vbNullString)
        ToolTip2.SetToolTip(PictureBox5, "Click to reset the traits")
        ToolTip2.SetToolTip(PictureBox6, vbNullString)
        ToolTip2.SetToolTip(PictureBox7, vbNullString)
        ToolTip2.SetToolTip(PictureBox8, vbNullString)

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox55, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Steal recharge rate by 1%")
        ToolTip2.SetToolTip(PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases Steal recharge rate by 1%")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition damage by " + Label21.Text + "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases critical damage by " + Label23.Text)
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases healing by " + Label25.Text)
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases boon duration by " + Label27.Text + "%")
        ToolTip2.SetToolTip(PictureBox68, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(PictureBox67, "Increases Steal recharge rate by " + Label29.Text + "%")

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(Label28, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(Label29, "Increases Virtues Recharge rate by " + Label29.Text + "%")

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

        Label10.Text = "Deadly Arts"
        Label11.Text = "Critical Strikes"
        Label12.Text = "Shadow Arts"
        Label13.Text = "Acrobatics"
        Label14.Text = "Trickery"

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

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox40.Visible = True
        PictureBox41.Visible = True
        PictureBox42.Visible = True
        PictureBox43.Visible = True
        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

        PictureBox40.Image = My.Resources.Fire
        PictureBox41.Image = My.Resources.Water
        PictureBox42.Image = My.Resources.Air
        PictureBox43.Image = My.Resources.Earth

		PictureBox44.Image = My.Resources.Fire___Elementalist
        PictureBox45.Image = My.Resources.Air___Elementalist
        PictureBox46.Image = My.Resources.Earth___Elementalist
        PictureBox47.Image = My.Resources.Water___Elementalist
        PictureBox48.Image = My.Resources.Arcane___Elementalist	

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Expertise
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Prowess
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Malice
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Compassion
        PictureBox68.Image = My.Resources.Concentration
        PictureBox67.Image = My.Resources.Intelligence

        ToolTip2.SetToolTipTitle(PictureBox40, "Fire Attunement")
        ToolTip2.SetToolTipTitle(PictureBox41, "Water Attunement")
        ToolTip2.SetToolTipTitle(PictureBox42, "Air Attunement")
        ToolTip2.SetToolTipTitle(PictureBox43, "Earth Attunement")

        ToolTip2.SetToolTipImage(PictureBox40, PictureBox40.Image)
        ToolTip2.SetToolTipImage(PictureBox41, PictureBox41.Image)
        ToolTip2.SetToolTipImage(PictureBox42, PictureBox42.Image)
        ToolTip2.SetToolTipImage(PictureBox43, PictureBox43.Image)

        ToolTip2.SetToolTip(PictureBox40, "Attune to fire, gaining heavy damage and Burning abilities.")
        ToolTip2.SetToolTip(PictureBox41, "Attune to water, gaining superior support and healing abilities.")
        ToolTip2.SetToolTip(PictureBox42, "Attune to air, gaining heavy damage and control abilities.")
        ToolTip2.SetToolTip(PictureBox43, "Attune to earth, gaining superior damage over time and defensive abilities.")

        ToolTip2.SetToolTip(PictureBox1, vbNullString)
        ToolTip2.SetToolTip(PictureBox2, vbNullString)
        ToolTip2.SetToolTip(PictureBox3, vbNullString)
        ToolTip2.SetToolTip(PictureBox4, vbNullString)
        ToolTip2.SetToolTip(PictureBox5, vbNullString)
        ToolTip2.SetToolTip(PictureBox6, "Click to reset the traits")
        ToolTip2.SetToolTip(PictureBox7, vbNullString)
        ToolTip2.SetToolTip(PictureBox8, vbNullString)

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        ToolTip2.SetToolTip(PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        ToolTip2.SetToolTip(PictureBox58, "Increases boon duration by 1%" & vbCrLf & "Increases Attunement recharge rate by 1%")
        ToolTip2.SetToolTip(PictureBox57, "Decreases boon duration by 1%" & vbCrLf & "Decreases Attunement recharge rate by 1%")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition duration by " + Label21.Text + "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases critical damage by " + Label23.Text)
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases condition damage by " + Label25.Text + "%")
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(PictureBox68, "Increases boon duration by " + Label28.Text + "%")
        ToolTip2.SetToolTip(PictureBox67, "Increases Attunement recharge rate by " + Label29.Text + "%")

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(Label28, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(Label29, "Increases Virtues Recharge rate by " + Label29.Text + "%")

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

        Label10.Text = "Fire Magic"
        Label11.Text = "Air Magic"
        Label12.Text = "Earth Magic"
        Label13.Text = "Water Magic"
        Label14.Text = "Arcane Power"

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

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

		PictureBox44.Image = My.Resources.Domination___Mesmer
        PictureBox45.Image = My.Resources.Dueling___Mesmer
        PictureBox46.Image = My.Resources.Chaos___Mesmer
        PictureBox47.Image = My.Resources.Inspiration___Mesmer
        PictureBox48.Image = My.Resources.Illusions___Mesmer

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Expertise
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Prowess
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Concentration
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Compassion
        PictureBox68.Image = My.Resources.Malice
        PictureBox67.Image = My.Resources.Guile

        ToolTip2.SetToolTip(PictureBox1, vbNullString)
        ToolTip2.SetToolTip(PictureBox2, vbNullString)
        ToolTip2.SetToolTip(PictureBox3, vbNullString)
        ToolTip2.SetToolTip(PictureBox4, vbNullString)
        ToolTip2.SetToolTip(PictureBox5, vbNullString)
        ToolTip2.SetToolTip(PictureBox6, vbNullString)
        ToolTip2.SetToolTip(PictureBox7, "Click to reset the traits")
        ToolTip2.SetToolTip(PictureBox8, vbNullString)

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        ToolTip2.SetToolTip(PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        ToolTip2.SetToolTip(PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases the recharge rate of Shatter skills by 1%")
        ToolTip2.SetToolTip(PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases the recharge rate of Shatter skills by 1%")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition duration by " + Label21.Text + "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases critical damage by " + Label23.Text)
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases boon duration by " + Label25.Text + "%")
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases healing by " + Label27.Text + "%")
        ToolTip2.SetToolTip(PictureBox68, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(PictureBox67, "Increases the recharge rate of Shutter skills by " + Label29.Text + "%")

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(Label28, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(Label29, "Increases Virtues Recharge rate by " + Label29.Text + "%")

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

        Label10.Text = "Domination"
        Label11.Text = "Dueling"
        Label12.Text = "Chaos"
        Label13.Text = "Inspiration"
        Label14.Text = "Illusions"

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

        Label10.Visible = True
        Label11.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True

        PictureBox40.Visible = True
        PictureBox41.Visible = True
        PictureBox42.Visible = False
        PictureBox43.Visible = False
        PictureBox49.Visible = True
        PictureBox49.Visible = True
        PictureBox50.Visible = True
        PictureBox51.Visible = True
        PictureBox52.Visible = True
        PictureBox53.Visible = True
        PictureBox54.Visible = True
        PictureBox55.Visible = True
        PictureBox56.Visible = True
        PictureBox57.Visible = True
        PictureBox58.Visible = True
        PictureBox59.Visible = True
        PictureBox60.Visible = True
        PictureBox61.Visible = True
        PictureBox62.Visible = True
        PictureBox63.Visible = True
        PictureBox64.Visible = True
        PictureBox65.Visible = True
        PictureBox66.Visible = True
        PictureBox67.Visible = True
        PictureBox68.Visible = True

        PictureBox40.Image = My.Resources.Death_Shroud
        PictureBox41.Image = My.Resources.End_Death_Shroud
        PictureBox44.Image = My.Resources.Spite___Necromancer
        PictureBox45.Image = My.Resources.Curses___Necromancer
        PictureBox46.Image = My.Resources.Death___Necromancer
        PictureBox47.Image = My.Resources.Blood___Necromancer
        PictureBox48.Image = My.Resources.Soul___Necromancer

        PictureBox59.Image = My.Resources.Power
        PictureBox60.Image = My.Resources.Expertise
        PictureBox62.Image = My.Resources.Precision
        PictureBox61.Image = My.Resources.Malice
        PictureBox64.Image = My.Resources.Toughness
        PictureBox63.Image = My.Resources.Concentration
        PictureBox66.Image = My.Resources.Vitality
        PictureBox65.Image = My.Resources.Compassion
        PictureBox68.Image = My.Resources.Prowess
        PictureBox67.Image = My.Resources.Hunger

        ToolTip2.SetToolTip(PictureBox1, vbNullString)
        ToolTip2.SetToolTip(PictureBox2, vbNullString)
        ToolTip2.SetToolTip(PictureBox3, vbNullString)
        ToolTip2.SetToolTip(PictureBox4, vbNullString)
        ToolTip2.SetToolTip(PictureBox5, vbNullString)
        ToolTip2.SetToolTip(PictureBox6, vbNullString)
        ToolTip2.SetToolTip(PictureBox7, vbNullString)
        ToolTip2.SetToolTip(PictureBox8, "Click to reset the traits")

        Label15.Text = "0"
        Label16.Text = "0"
        Label17.Text = "0"
        Label18.Text = "0"
        Label19.Text = "0"
        Label20.Text = "0"
        Label21.Text = "0"
        Label22.Text = "0"
        Label23.Text = "0"
        Label24.Text = "0"
        Label25.Text = "0"
        Label26.Text = "0"
        Label27.Text = "0"
        Label28.Text = "0"
        Label29.Text = "0"

        ToolTip2.SetToolTipTitle(PictureBox40, "Death Shroud")
        ToolTip2.SetToolTipTitle(PictureBox41, "End Death Shroud")

        ToolTip2.SetToolTipImage(PictureBox40, PictureBox40.Image)
        ToolTip2.SetToolTipImage(PictureBox41, PictureBox41.Image)

        ToolTip2.SetToolTip(PictureBox40, "Chain: Assume a spectral form and gain new skills, turning your life force into health." & vbCrLf & "Skill Chain:" _
                            & vbCrLf & "Death Shroud > End Death Shroud")
        ToolTip2.SetToolTip(PictureBox41, "Chain: Leave Death Shroud and return to your normal form.")

        ToolTip2.SetToolTipTitle(PictureBox49, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox52, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox54, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox56, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox58, "Add Point")
        ToolTip2.SetToolTipTitle(PictureBox50, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox51, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox53, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox55, "Remove Point")
        ToolTip2.SetToolTipTitle(PictureBox57, "Remove Point")

        ToolTip2.SetToolTip(PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        ToolTip2.SetToolTip(PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox51, "Decreases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        ToolTip2.SetToolTip(PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases boon duration by 1%")
        ToolTip2.SetToolTip(PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        ToolTip2.SetToolTip(PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        ToolTip2.SetToolTip(PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases the size of your Life Force pool by 1")
        ToolTip2.SetToolTip(PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases the size of your Life Force pool by 1")

        ToolTip2.SetToolTip(PictureBox59, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(PictureBox60, "Increases condition duration by " + Label21.Text + "%")
        ToolTip2.SetToolTip(PictureBox62, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(PictureBox61, "Increases condition damage by " + Label23.Text + "%")
        ToolTip2.SetToolTip(PictureBox64, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(PictureBox63, "Increases boon duration by " + Label25.Text + "%")
        ToolTip2.SetToolTip(PictureBox66, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(PictureBox65, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(PictureBox68, "Increases critical damage by " + Label28.Text)
        ToolTip2.SetToolTip(PictureBox67, "Increases the size of your Life Force pool by " + Label29.Text)

        ToolTip2.SetToolTip(Label20, "Increases power by " & Label20.Text)
        ToolTip2.SetToolTip(Label21, "Increases condition duration by " & Label21.Text & "%")
        ToolTip2.SetToolTip(Label22, "Increases precision by " + Label22.Text)
        ToolTip2.SetToolTip(Label23, "Increases condition duration by " + Label23.Text + "%")
        ToolTip2.SetToolTip(Label24, "Increases toughness by " + Label24.Text)
        ToolTip2.SetToolTip(Label25, "Increases critical damage by " + Label25.Text)
        ToolTip2.SetToolTip(Label26, "Increases vitality by " + Label26.Text)
        ToolTip2.SetToolTip(Label27, "Increases healing by " + Label27.Text)
        ToolTip2.SetToolTip(Label28, "Increases condition damage by " + Label28.Text + "%")
        ToolTip2.SetToolTip(Label29, "Increases Virtues Recharge rate by " + Label29.Text + "%")

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

        Label10.Text = "Spite"
        Label11.Text = "Curses"
        Label12.Text = "Death Magic"
        Label13.Text = "Blood Magic"
        Label14.Text = "Soul Reaping"
    End Sub

    Private Sub PictureBox19_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox19.Click

    End Sub

    Private Sub PictureBox49_Click(sender As Object, e As EventArgs) Handles PictureBox49.Click
        cls.AddPnt1()
    End Sub

    Private Sub PictureBox50_Click(sender As Object, e As EventArgs) Handles PictureBox50.Click
        cls.RmvPnt1()
    End Sub

    Private Sub PictureBox52_Click(sender As Object, e As EventArgs) Handles PictureBox52.Click
        cls.AddPnt2()
    End Sub

    Private Sub PictureBox51_Click(sender As Object, e As EventArgs) Handles PictureBox51.Click
        cls.RmvPnt2()
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs) Handles PictureBox54.Click
        cls.AddPnt3()
    End Sub

    Private Sub PictureBox53_Click(sender As Object, e As EventArgs) Handles PictureBox53.Click
        cls.RmvPnt3()
    End Sub

    Private Sub PictureBox56_Click(sender As Object, e As EventArgs) Handles PictureBox56.Click
        cls.AddPnt4()
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        cls.RmvPnt4()
    End Sub

    Private Sub PictureBox58_Click(sender As Object, e As EventArgs) Handles PictureBox58.Click
        cls.AddPnt5()
    End Sub

    Private Sub PictureBox57_Click(sender As Object, e As EventArgs) Handles PictureBox57.Click
        cls.RmvPnt5()
    End Sub

    Private Sub Label15_DoubleClick(sender As Object, e As EventArgs) Handles Label15.DoubleClick
        If Label15.Text > 0 Then
            ToolTip2.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset1()
        End If
    End Sub

    Private Sub Label16_DoubleClick(sender As Object, e As EventArgs) Handles Label16.DoubleClick
        If Label16.Text > 0 Then
            ToolTip2.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset2()
        End If
    End Sub

    Private Sub Label17_DoubleClick(sender As Object, e As EventArgs) Handles Label17.DoubleClick
        If Label17.Text > 0 Then
            ToolTip2.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset3()
        End If
    End Sub

    Private Sub Label18_DoubleClick(sender As Object, e As EventArgs) Handles Label18.DoubleClick
        If Label18.Text > 0 Then
            ToolTip2.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset4()
        End If
    End Sub

    Private Sub Label19_DoubleClick(sender As Object, e As EventArgs) Handles Label19.DoubleClick
        If Label19.Text > 0 Then
            ToolTip2.SetToolTip(Label15, "Double Click for reset only this row")
            cls.SingleReset5()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        cls.Heal1()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        cls.Heal2()
    End Sub
End Class
