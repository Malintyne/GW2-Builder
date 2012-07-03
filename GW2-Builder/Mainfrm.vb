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

        PictureBox40.Visible = True
        PictureBox41.Visible = True
        PictureBox42.Visible = True
        PictureBox43.Visible = False

        PictureBox40.Image = My.Resources.Virtue_of_Justice
        PictureBox41.Image = My.Resources.Virtue_of_Resolve
        PictureBox42.Image = My.Resources.Virtue_of_Courage
        PictureBox44.Image = My.Resources.Zeal___Guardian
        PictureBox45.Image = My.Resources.Radiance___Guardian
        PictureBox46.Image = My.Resources.Valor___Guardian
        PictureBox47.Image = My.Resources.Honor___Guardian
        PictureBox48.Image = My.Resources.Virtues___Guardian

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

        PictureBox44.Image = My.Resources.Strength___Warrior
        PictureBox45.Image = My.Resources.Arms___Warrior
        PictureBox46.Image = My.Resources.Defense___Warrior
        PictureBox47.Image = My.Resources.Tactics___Warrior
        PictureBox48.Image = My.Resources.Discipline___Warrior

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

        PictureBox44.Image = My.Resources.Explosives___Engineer
        PictureBox45.Image = My.Resources.Firearms___Engineer
        PictureBox46.Image = My.Resources.Inventions___Engineer
        PictureBox47.Image = My.Resources.Alchemy___Engineer
        PictureBox48.Image = My.Resources.Tools___Engineer
		
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

        PictureBox44.Image = My.Resources.Markmanship___Ranger
        PictureBox45.Image = My.Resources.Skirmishing___Ranger
        PictureBox46.Image = My.Resources.Wildnerness___Ranger
        PictureBox47.Image = My.Resources.Nature___Ranger
        PictureBox48.Image = My.Resources.Beastmastery___Ranger	
		
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

		PictureBox44.Image = My.Resources.Deadly___Thief
        PictureBox45.Image = My.Resources.Critical___Thief
        PictureBox46.Image = My.Resources.Shadow__Thief
        PictureBox47.Image = My.Resources.Acrobatics___Thief
        PictureBox48.Image = My.Resources.Trickery___Thief	
		
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
		
        PictureBox40.Visible = True
        PictureBox41.Visible = True
        PictureBox42.Visible = True
        PictureBox43.Visible = True

        PictureBox40.Image = My.Resources.Fire
        PictureBox41.Image = My.Resources.Water
        PictureBox42.Image = My.Resources.Air
        PictureBox43.Image = My.Resources.Earth

		PictureBox44.Image = My.Resources.Fire___Elementalist
        PictureBox45.Image = My.Resources.Air___Elementalist
        PictureBox46.Image = My.Resources.Earth___Elementalist
        PictureBox47.Image = My.Resources.Water___Elementalist
        PictureBox48.Image = My.Resources.Arcane___Elementalist	
		
        ToolTip2.SetToolTipTitle(PictureBox40, "Fire")
        ToolTip2.SetToolTipTitle(PictureBox41, "Water")
        ToolTip2.SetToolTipTitle(PictureBox42, "Air")
        ToolTip2.SetToolTipTitle(PictureBox43, "Earth")

        ToolTip2.SetToolTipImage(PictureBox40, PictureBox40.Image)
        ToolTip2.SetToolTipImage(PictureBox41, PictureBox41.Image)
        ToolTip2.SetToolTipImage(PictureBox42, PictureBox42.Image)
        ToolTip2.SetToolTipImage(PictureBox43, PictureBox43.Image)

        ToolTip2.SetToolTip(PictureBox40, "Virtue: Burn foes with every fifth attacks." & vbCrLf & "Activate: Grant Burning to you and nearby allies next attack." _
                            & vbCrLf & "Burning (passive effect)(1s): 4 damage" & vbCrLf & "Burning (active effect)(5s): 4 damage")
        ToolTip2.SetToolTip(PictureBox41, "Virtue: Regenerate health." & vbCrLf & "Activate: Heal yourself and nearby allies." _
                            & vbCrLf & "Passive Renegeration: 3 seconds" & vbCrLf & "Healing: 25")
        ToolTip2.SetToolTip(PictureBox42, "Virtue: Grants Aegis every 40 seconds." & vbCrLf & "Activate: Grant Aegis to yourself and nearby allies." _
                            & vbCrLf & "Aegis(5s): Block the next incoming attack")

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

		PictureBox44.Image = My.Resources.Domination___Mesmer
        PictureBox45.Image = My.Resources.Dueling___Mesmer
        PictureBox46.Image = My.Resources.Chaos___Mesmer
        PictureBox47.Image = My.Resources.Inspiration___Mesmer
        PictureBox48.Image = My.Resources.Illusions___Mesmer
		
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

		PictureBox44.Image = My.Resources.Spite___Necromancer
        PictureBox45.Image = My.Resources.Curses___Necromancer
        PictureBox46.Image = My.Resources.Death___Necromancer
        PictureBox47.Image = My.Resources.Blood___Necromancer
        PictureBox48.Image = My.Resources.Soul___Necromancer
		
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

    Private Sub PictureBox19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox19.Click

    End Sub
End Class
