Public Class RCls
#Region "Main Form"
    Dim ver As String = "GW2 Builder - " + Application.ProductVersion

    Public Sub MfrmLoad()
        ResetImage()
        Mainfrm.Text = ver
        Mainfrm.TopMost = False
        Mainfrm.Label6.Text = ver
        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"
        Mainfrm.ComboBox1.Enabled = False
        Mainfrm.ComboBox2.Enabled = False
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False
        Mainfrm.PictureBox30.Visible = False
        Mainfrm.PictureBox31.Visible = False
        Mainfrm.PictureBox32.Visible = False
        Mainfrm.PictureBox33.Visible = False
        Mainfrm.PictureBox34.Visible = False
        Mainfrm.PictureBox35.Visible = False
        Mainfrm.PictureBox36.Visible = False
        Mainfrm.PictureBox37.Visible = False
        Mainfrm.PictureBox38.Visible = False
        Mainfrm.PictureBox39.Visible = False
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.Label8, "Information")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.Label2, "Minimize")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.Label1, "Close")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.Label6, "Double click to enable always on top")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox1, "Guardian")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox2, "Warrior")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox3, "Engineer")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox4, "Ranger")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox5, "Thief")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox6, "Elementalist")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox7, "Mesmer")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox8, "Necromancer")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox19, "Click to swap weapon set")
    End Sub

    Public Sub ResetImage()
        Mainfrm.PictureBox30.Visible = False
        Mainfrm.PictureBox31.Visible = False
        Mainfrm.PictureBox32.Visible = False
        Mainfrm.PictureBox33.Visible = False
        Mainfrm.PictureBox34.Visible = False
        Mainfrm.PictureBox35.Visible = False
        Mainfrm.PictureBox36.Visible = False
        Mainfrm.PictureBox37.Visible = False
        Mainfrm.PictureBox38.Visible = False
        Mainfrm.PictureBox39.Visible = False
        Mainfrm.PictureBox9.Image = My.Resources.Unknown
        Mainfrm.PictureBox10.Image = My.Resources.Unknown
        Mainfrm.PictureBox11.Image = My.Resources.Unknown
        Mainfrm.PictureBox12.Image = My.Resources.Unknown
        Mainfrm.PictureBox13.Image = My.Resources.Unknown
        Mainfrm.PictureBox29.Image = My.Resources.Unknown
        Mainfrm.PictureBox28.Image = My.Resources.Unknown
        Mainfrm.PictureBox27.Image = My.Resources.Unknown
        Mainfrm.PictureBox26.Image = My.Resources.Unknown
        Mainfrm.PictureBox25.Image = My.Resources.Unknown
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a one hand or a two hand weapon first")
    End Sub

    Public Sub LblClick()
        If Mainfrm.TopMost = True Then
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.Label6, "Double click to enable always on top")
            Mainfrm.TopMost = False
            Mainfrm.Label6.Text = ver
        ElseIf Mainfrm.TopMost = False Then
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.Label6, "Double click to disable always on top")
            Mainfrm.TopMost = True
            Mainfrm.Label6.Text = ver + " - On Top"
        End If
    End Sub
#End Region

#Region "ComboBox1"
    Public Sub CmbBox1()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Hammer" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Hammer_Swing
            Mainfrm.PictureBox30.Image = My.Resources.Hammer_Bash
            Mainfrm.PictureBox31.Image = My.Resources.Symbol_of_Protection
            Mainfrm.PictureBox10.Image = My.Resources.Mighty_Blow
            Mainfrm.PictureBox11.Image = My.Resources.Zealot_s_Embrace
            Mainfrm.PictureBox12.Image = My.Resources.Banish
            Mainfrm.PictureBox13.Image = My.Resources.Ring_of_Warding
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Hammer Swing")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Hammer Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Symbol of Protection")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Mighty Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Zealot's Embrace")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Banish")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Ring of Warding")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Strike your foe." & vbCrLf & "Damage: 368" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Symbol of Protection")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe." & vbCrLf & "Damage: 413" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Create a symbol that gives Protection to you and your allies." _
                                & vbCrLf & "Damage: 920" & vbCrLf & "Protection(1s): 33% damage reduction" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Damage nearby foes with a mighty ground slam." & vbCrLf & "Damage: 551" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Send a wave toward your foe that immobilizes enemies in a line." _
                                & vbCrLf & "Damage: 368" & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Launch your foe with a powerful smash." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Launch: 900" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Create a ring around you that foes cannot cross. Trapped enemies cannot exit the ring while it is active." _
                                & vbCrLf & "Duration: 5 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Wave_of_Wrath
            Mainfrm.PictureBox10.Image = My.Resources.Orb_of_Light
            Mainfrm.PictureBox36.Image = My.Resources.Flash_of_Light
            Mainfrm.PictureBox11.Image = My.Resources.Symbol_of_Swiftness
            Mainfrm.PictureBox12.Image = My.Resources.Line_of_Warding
            Mainfrm.PictureBox13.Image = My.Resources.Martyr
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Wave of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Orb of Light")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox36, "Flash of Light")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Symbol of Swiftness")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Line of Warding")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Martyr")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox36, Mainfrm.PictureBox36.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Send out a powerful shockwave, hitting up to five enemies." _
                                & vbCrLf & "Damage: 276" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Chain. Fire a slow-moving orb of light that can be detonated to Heal allies." _
                                & vbCrLf & "Damage: 551" & vbCrLf & "Healing: 1372" & vbCrLf & "Detonate Damage: 276" & vbCrLf & "Range: 1200" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Orb of Light > Flash of Light")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox36, "Chain. Detonate the orb to Heal nearby allies. Recharge on Orb of Light is set to 4 times" _
                                        & "it's basic recharge." & vbCrLf & "Damage: 276" & vbCrLf & "Healing: 803" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Sear a mystic symbol into the target area, damaging foes and granting Swiftness to allies." _
                                & vbCrLf & "Damage: 230" & vbCrLf & "Swiftness(2s): +33% movement speed" _
                                & vbCrLf & "Symbol radius: 180" & vbCrLf & "Symbol duration: 4 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Create a line in front of you that foes cannot cross." & vbCrLf & "Duration: 5 seconds")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Draw conditions from nearby allies to yourself. Gain multiple boons for a short duration." _
                                & vbCrLf & "Fury(5s): +20% critical" & vbCrLf & "Vigor(5s): +100% endurance regen" _
                                & vbCrLf & "Might(5s): +5-35 Power" & vbCrLf & "Protection(5s): 33% damage reduction" & vbCrLf & "Regen(5s): +445 health regen" _
                                & vbCrLf & "Swiftness(5s): +33% movement speed" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Strike
            Mainfrm.PictureBox30.Image = My.Resources.Vengeful_Strike
            Mainfrm.PictureBox31.Image = My.Resources.Wrathful_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Symbol_of_Wrath
            Mainfrm.PictureBox11.Image = My.Resources.Whirling_Wrath
            Mainfrm.PictureBox12.Image = My.Resources.Leap_of_Faith
            Mainfrm.PictureBox13.Image = My.Resources.Binding_Blade
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Vengeful Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Wrathful Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Symbol of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Whirling Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Leap of Faith")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Binding Blade")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Strike your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Strike > Vengeful Strike > Wrathful Strike")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Strike your foe again." & vbCrLf & "Damage: 376" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Attack your foe with a wrathful strike." _
                                & vbCrLf & "Damage: 459" & vbCrLf & "Might(3s): +5-35 Power" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Pierce the ground with a mystic symbol that damages and Burns foes while " _
                                & "granting Retaliation to allies." & vbCrLf & "Damage: 230" & vbCrLf _
                                & "Retaliation(2s): Reflect incoming damage back to it's source" & vbCrLf & "Combo Field: Light")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Spin in place and swing your greatword while hurling powerful projectiles." _
                                & vbCrLf & "Damage: 1413" & vbCrLf & "Projectile Damage: 1412" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Leap at your foe. On hit, blind nearby foes." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Throw blades at your foes, causing damage over time. Bounds foe can be " _
                                & "Pulled to you. The effect end when a foe moves out of range" & vbCrLf & "Maximum blade duration: 10 seconds" _
                                & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 600")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Hammer" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Hammer_Swing1
            Mainfrm.PictureBox30.Image = My.Resources.Hammer_Bash1
            Mainfrm.PictureBox31.Image = My.Resources.Hammer_Smash
            Mainfrm.PictureBox10.Image = My.Resources.Fierce_Blow
            Mainfrm.PictureBox11.Image = My.Resources.Hammer_Shock
            Mainfrm.PictureBox12.Image = My.Resources.Staggering_Blow
            Mainfrm.PictureBox13.Image = My.Resources.Backbreaker
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Hammer Swing")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Hammer Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Hammer Smash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Fierce Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Hammer Shock")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Staggering Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Backbreaker")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Bash your foe." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Hammer Blow")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe again." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Smash the ground and damage nearby foes." _
                                & vbCrLf & "Damage: 821" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Weaken your foe with a fierce blow." & vbCrLf & "Damage: 645" & vbCrLf _
                                & "Weakness(8s): -50% Endurance Regeneration, 50% Fumble" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Smash the ground and send out a Crippling wave." _
                                & vbCrLf & "Damage: 410" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Push back nearby foes with a stuggering blow." & vbCrLf & "Damage: 703" & vbCrLf _
                                & "Knockback: 180" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Knock down your target foe." & vbCrLf & "Damage: 879" _
                                & vbCrLf & "Knockdown: 2 seconds" & vbCrLf & "Range: 130")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Greatsword_Swing
            Mainfrm.PictureBox30.Image = My.Resources.Greatsword_Slice
            Mainfrm.PictureBox31.Image = My.Resources.Brutal_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Hundred_Blades
            Mainfrm.PictureBox11.Image = My.Resources.Whirlwind_Attack
            Mainfrm.PictureBox12.Image = My.Resources.Bladetrail
            Mainfrm.PictureBox13.Image = My.Resources.Rush
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Greatsword Swing")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Greatsword Slice")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Brutal Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Hundred Blades")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Whirlwind Attack")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Bladetrail")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Rush")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Greatsword Swing > Greatosword Slice > Brutal Strike")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Slice your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Hit your foes with a final brutal strike." _
                                & vbCrLf & "Damage: 480" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Repeatedly strike multiple foes. The last stike does extra damage." & vbCrLf & "Damage: 2756" & vbCrLf _
                                & "Final Strike Damage: 644" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Whirl in a target's direction, slashing foes along your path." _
                                & vbCrLf & "Damage: 373" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Throw your greatsword at your foe. It travels to your target and returns to you." _
                                & "Cripplings foes along your path." & vbCrLf & "Damage: 469" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Charge your foe." & vbCrLf & "Damage: 146" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Dual_Shot_png
            Mainfrm.PictureBox10.Image = My.Resources.Fan_of_Fire_png
            Mainfrm.PictureBox11.Image = My.Resources.Arcing_Arrow_png
            Mainfrm.PictureBox12.Image = My.Resources.Smoldering_Arrow_png
            Mainfrm.PictureBox13.Image = My.Resources.Pin_Down_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Dual Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Fan of Fire")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Arcing Arrow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Smoldering Arrow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Pin Down")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Shot a pair of arrows at your foe." & vbCrLf & "Damage: 284" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Fire a spread of three flaming arrows, Burning foes." & vbCrLf & "Damage: 168" _
                                & vbCrLf & "Burning(2s): -690 health" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Shot a slow, arcing arrow that explodes on impact." & vbCrLf & "Damage: 814" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Shot an arrow that explodes on impact. Blinding foes." _
                                & vbCrLf & "Damage: 112" & vbCrLf & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Fire an arrow that Immobilizes the target." & vbCrLf & "Damage: 234" _
                                & vbCrLf & "Immobilize(3s): Unable to move" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Bleeding_Shot_png
            Mainfrm.PictureBox10.Image = My.Resources.Aimed_Shot_png
            Mainfrm.PictureBox11.Image = My.Resources.Volley_png
            Mainfrm.PictureBox12.Image = My.Resources.Brutal_Shot_png
            Mainfrm.PictureBox13.Image = My.Resources.Rifle_Butt_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Bleeding Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Aimed Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Volley")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Brutal Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Rifle Butt")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Fire a shot that Bleeds your target." & vbCrLf & "Damage: 213" _
                                & vbCrLf & "Bleeding(6s): -270 damage over time" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Fire a precise shot that Cripples your foe." & vbCrLf & "Damage: 186" _
                                & vbCrLf & "Cripple(5s): -50% Speed" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Fire a volley of shots at your foe." & vbCrLf & "Damage: 376" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Shot your foes and make them Vulnerable." _
                                & vbCrLf & "Damage: 306" & vbCrLf & "Vulnerability(10s): -30 defence" & vbCrLf & "Combo Finisher: Physical Projectile" _
                                & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Push your foe back with your rifle butt." & vbCrLf & "Damage: 568" _
                                & vbCrLf & "Knockback: 450" & vbCrLf & "Range: 130")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Hip_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Net_Shot
            Mainfrm.PictureBox11.Image = My.Resources.Blunderbuss
            Mainfrm.PictureBox12.Image = My.Resources.Overcharged_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Jump_Shot
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Hip Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Net Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Blunderbuss")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Overcharged Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Jump Shot")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Deliver a quick rifle shot from the hip." & vbCrLf & "Damage: 155" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Immobilizie foes with a net shot." & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Fire a cloud of sharpnel that causes more damage the closer you are to foes." _
                                & vbCrLf & "Within 8 fett: 621" & vbCrLf & "Within 16 feet: 563" & vbCrLf & "Within 24 feet: 466" _
                                & vbCrLf & "Within 32 feet: 388" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Fire a blast so strong it Launches your foe as you fall backward." _
                                & vbCrLf & "Damage: 388" & vbCrLf & "Enemy launch distance: 450" & vbCrLf & "Self knockback distance: 350" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Blast the ground, damaging nearby foes and leaping to your target." _
                                & vbCrLf & "Leap Damage: 466" & vbCrLf & "Landing Damage: 456" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 700")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = True
            Mainfrm.PictureBox9.Image = My.Resources.Slash
            Mainfrm.PictureBox30.Image = My.Resources.Slice
            Mainfrm.PictureBox31.Image = My.Resources.Power_Stab
            Mainfrm.PictureBox10.Image = My.Resources.Maul
            Mainfrm.PictureBox11.Image = My.Resources.Swoop
            Mainfrm.PictureBox12.Image = My.Resources.Counterattack
            Mainfrm.PictureBox38.Image = My.Resources.Crippling_Throw
            Mainfrm.PictureBox13.Image = My.Resources.Hilt_Bash
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Slash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Slice")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Power Stab")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Maul")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Swoop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Counterattack")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox38, "Crippling Throw")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Hilt Bash")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox38, Mainfrm.PictureBox38.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Slice > Power Stab")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Slice your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Stab your foe and Evade attacks." & vbCrLf & "Damage: 671" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Bleed your foe four times with a mauling strike." & vbCrLf & "Damage: 280" & vbCrLf _
                                & "Bleeding(4s): -1546 damage over time" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Run and leap at your foe, hitting them and nearby foes." _
                                & vbCrLf & "Damage: 783" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 770")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Chain. Block and counter an attack with a kick that pushes foes back." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Counterattack > Crippling Throw")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox38, "Chain. Throw your Greatsword, Crippling your foe." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Daze your foe with a hilt bash. Stun them if you hit from behind. Your pet's" _
                                & "next attack does 50% more damage." & vbCrLf & "Damage: 420" & vbCrLf & "Daze(1s): Unable to use skills" _
                                & vbCrLf & "Stun(1s): Unable to use skills or move" & vbCrLf & "Range: 300")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Long_Range_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Rapid_Fire
            Mainfrm.PictureBox11.Image = My.Resources.Hunter_s_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Point_Blank_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Barrage
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Long Range Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Rapid Fire")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Hunter's Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Point Blank Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Barrage")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Shot your foe with a long range arrow. The farther the arrows flies, the more damage it does." _
                                & vbCrLf & "1000+ Range: 509" & vbCrLf & "500-1000 Range: 382" & vbCrLf & "0-500 Range: 254" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Fire multiple arrows at your foe." & vbCrLf & "Damage: 2040" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20& chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Fire an arrow to make your foe Vulnerability. Your pet gains Swiftness." & vbCrLf & "Damage: 267" _
                                & vbCrLf & "Vulnerability(10s): -30 defense" & vbCrLf & "Pet Swiftness(10s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Push back your foe with a point-blank shot. The closer they are, the farther it knocks back." _
                                & vbCrLf & "Damage: 539" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Barrage the target area with a hail of arrows that Cripple." & vbCrLf & "Damage: 1836" _
                                & vbCrLf & "Cripple(3s): -50% Speed" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Shortbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Cross_Fire
            Mainfrm.PictureBox10.Image = My.Resources.Poison_Volley
            Mainfrm.PictureBox11.Image = My.Resources.Quick_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Crippling_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Concussion_Shot
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Cross Fire")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Poison Volley")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Quick Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Crippling Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Concussion Shot")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Fire an arrow that bleeds your target if it hits your foe from behind or the side." _
                                & vbCrLf & "Damage: 204" & vbCrLf & "Bleeding(3s): -144 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Fire a spread of 5 poison arrows." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Poison(2s): -194 health, -33% reduce healing" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Fire a quick shot in an Evasive retreat. Gain Swiftness if the shot hits." _
                                & "This can be used while retreating." & vbCrLf & "Damage: 178" & vbCrLf & "Swiftness(3s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Shatter your foe's dreams of becoming an adventurer with a single arrow to the knee." _
                                & "Your pet's next three attacks inflict Bleeding." & vbCrLf & "Damage: 178" & vbCrLf & "Cripple(3s): -50% Speed" _
                                & vbCrLf & "Bleeding(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Daze your foe with an arrow. Stun them if you hit from behind or from the side." & vbCrLf & "Damage: 178" _
                                & vbCrLf & "Daze: 1 second" & vbCrLf & "Stun: 1 second" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Sword_of_Wrath
            Mainfrm.PictureBox30.Image = My.Resources.Sword_Arc
            Mainfrm.PictureBox31.Image = My.Resources.Sword_Wave
            Mainfrm.PictureBox10.Image = My.Resources.Flashing_Blade
            Mainfrm.PictureBox11.Image = My.Resources.Zealot_s_Defense
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Sword of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Sword Arc")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Sword Wave")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Flashing Blade")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Zealot's Defence")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe once." & vbCrLf & "Damage: 376" & vbCrLf _
                                & "Range: 150" & vbCrLf & "Skill Chain:" & vbCrLf & "Sword of Wrath > Sword Arc > Sword Wave")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Slash your foe again." & vbCrLf & "Damage: 459" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Send out a cone attack, striking up to three enemies." & vbCrLf & "Damage: 543" & vbCrLf _
                                & "Range: 280")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Teleport to your target, striking them and Blinding nearby foes." & vbCrLf _
                                & "Damage: 84" & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Block ranged attacks while throwing magical projectiles." & vbCrLf _
                                & "Damage: 1104" & vbCrLf & "Block Duration: 3 seconds" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Orb_of_Wrath_png
            Mainfrm.PictureBox10.Image = My.Resources.Smite_png
            Mainfrm.PictureBox11.Image = My.Resources.Chains_of_Light_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Orb of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Smite")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Chains of Light")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Fire a slow-moving orb at your foe." & vbCrLf & "Damage: 355" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Strike foes in the target area repeatedly." & vbCrLf & "Damage: 2070" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Immobilize your foe with ethereal chains." & vbCrLf & "Immobilize(2s): Unable to move" _
                                & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.True_Strike
            Mainfrm.PictureBox30.Image = My.Resources.Pure_Strike
            Mainfrm.PictureBox31.Image = My.Resources.Faithful_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Symbol_of_Faith
            Mainfrm.PictureBox11.Image = My.Resources.Protector_s_Strike
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "True Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Pure Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Faithful Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Symbol of Faith")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Protector's Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Smash your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "True Strike > Pure Strike > Faithful Strike")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe." & vbCrLf & "Damage: 470" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Hit your fow with a final strike and heal your neabry allies." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Healing: 534" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Smash a mystic symbol onto the ground that damages foes and regenerates allies." _
                                & vbCrLf & "Damage: 209" & vbCrLf & "Regen(1s): +356 health regen" & vbCrLf & "Symbol Duration: 4 seconds" _
                                & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 120")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Surround yourself and nearby allies with a shield. Knock back enemies that strike protected allies." _
                                & " Grant Protection to yourself and nearby allies if you are not struck." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Protection(5s): 33% damage reduction" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Sever_Artery_png
            Mainfrm.PictureBox30.Image = My.Resources.Gash_png
            Mainfrm.PictureBox31.Image = My.Resources.Final_Thrust_png
            Mainfrm.PictureBox10.Image = My.Resources.Savage_Leap_png
            Mainfrm.PictureBox11.Image = My.Resources.Hamstring_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Sever Artery")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Gash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Final Thrust")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Savage Leap")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Hamstring")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Bleed your foe with a slash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Sever Artery > Gash > Final Thrust")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Bleed your foe with a gash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Strike your foe with a final powerful thrust." & vbCrLf & "Damage: 693" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Lunge at your foe, striking them with your sword." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Cripple your foe with a precise slash." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Chop_png
            Mainfrm.PictureBox30.Image = My.Resources.Double_Chop_png
            Mainfrm.PictureBox31.Image = My.Resources.Triple_Chop_png
            Mainfrm.PictureBox10.Image = My.Resources.Cyclone_Axe_png
            Mainfrm.PictureBox11.Image = My.Resources.Throw_Axe_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Chop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Double Chop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Triple Chop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Cyclone Ace")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Throw Axe")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Chop your foe." & vbCrLf & "Damage: 453" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Chop > Double Chop > Triple Chop")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Chop your foe twice." & vbCrLf & "Damage: 906" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Deliver three final chop at your foe." & vbCrLf & "Damage: 1359" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Spin around and attack all nearby foes." & vbCrLf & "Damage: 399" _
                                & vbCrLf & "Vulnerability(8s): -30 defence" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Throw an axe that Cripples enemies." & vbCrLf & "Damage: 357" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox30.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox31.Image = My.Resources.Pulverize_png
            Mainfrm.PictureBox10.Image = My.Resources.Counter_Blow_png
            Mainfrm.PictureBox11.Image = My.Resources.Pommel_Bash_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Mace Smash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Mace Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Pulverize")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Counter Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Pommel Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Smash your foe." & vbCrLf & "Damage: 448" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Mace Smash > Mace Bash > Pulverize")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe." & vbCrLf & "Damage: 426" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Trash your foe, leaving them weakened." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Weakness(5s): -50% Endurance Regen, 50% Fumble" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Block the next attack. Counter with an attack if you are in melee range. Gain adrenaline if not attacked." _
                                & vbCrLf & "Damage: 532")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Daze your foe with a brutal pommel bash." & vbCrLf & "Damage: 224" & vbCrLf & "Daze: 1 second" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Explosive_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Poison_Dart_Volley
            Mainfrm.PictureBox11.Image = My.Resources.Static_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Explosive Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Symbol of Faith")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Protector's Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Fire a shot that explode on impact, Bleeding nearby foes." _
                                & vbCrLf & "Damage: 108" & vbCrLf & "Bleeding(4s): -192 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Fire a volley of darts that poison foes." _
                                & vbCrLf & "Damage: 89" & vbCrLf & "Poison(2s): -192 health, -33% reduce healing" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Discharge a lightning shot that bounces Blind and Confusion to multiple enemies." _
                                & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Confusion(3s): -77 health per skill used" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Slash
            Mainfrm.PictureBox30.Image = My.Resources.Kick
            Mainfrm.PictureBox31.Image = My.Resources.Pounce
            Mainfrm.PictureBox10.Image = My.Resources.Hornet_Sting
            Mainfrm.PictureBox36.Image = My.Resources.Monarch_s_Leap
            Mainfrm.PictureBox11.Image = My.Resources.Serpent_s_Strike
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Slash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox30, "Kick")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox31, "Pounce")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Hornet Sting")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox36, "Monarch's Leap")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Serpent's Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox36, Mainfrm.PictureBox36.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe." & vbCrLf & "Damage: 305" & vbCrLf _
                                & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Kick > Pounce")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox30, "Chain. Kick your foe causing a short Cripple." & vbCrLf & "Damage: 305" _
                                & vbCrLf & "Cripple(2s): -50% Movement Speed" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox31, "Chain. Leap at target foe, striking them. Your pet gain Might." & vbCrLf & "Damage: 509" & vbCrLf _
                                & vbCrLf & "Might(5s): +5-35 Power" & "Range: 430")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Chain. Stab your foe, then Evade backward." & vbCrLf & "Damage: 662" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hornet Sting > Monarch's Leap")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox36, "Chain. Leap back into the fight. Crippling your foe." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Cripple(3s): -50% Movement Speed" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Do an Evasive roll around your target, striking them and poisoning them." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Poison(6s): -582 health, -33% reduce healing" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Ricochet
            Mainfrm.PictureBox10.Image = My.Resources.Splitblade
            Mainfrm.PictureBox11.Image = My.Resources.Winter_s_Bite
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox9, "Ricochet")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox10, "Splitblade")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox11, "Winter's Bite")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox9, "Bounce your axe off multiple foes." & vbCrLf & "Damage: 356" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox10, "Throw a spread pattern of 5 whirling axes that Bleeds foes." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Bleed(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox11, "Throw an axe to Chill your foe. Your pet's next attacks inflicts Weakness." & vbCrLf & "Damage: 254" _
                                & vbCrLf & "Chilled(3s): -66% speed/recharge" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        End If
    End Sub
#End Region

#Region "ComboBox2"
    Public Sub CmbBox2()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Hammer" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Hammer_Swing
            Mainfrm.PictureBox32.Image = My.Resources.Hammer_Bash
            Mainfrm.PictureBox33.Image = My.Resources.Symbol_of_Protection
            Mainfrm.PictureBox28.Image = My.Resources.Mighty_Blow
            Mainfrm.PictureBox27.Image = My.Resources.Zealot_s_Embrace
            Mainfrm.PictureBox26.Image = My.Resources.Banish
            Mainfrm.PictureBox25.Image = My.Resources.Ring_of_Warding
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Hammer Swing")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Hammer Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Symbol of Protection")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Mighty Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Zealot's Embrace")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Banish")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Ring of Warding")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Strike your foe." & vbCrLf & "Damage: 368" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Symbol of Protection")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe." & vbCrLf & "Damage: 413" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Create a symbol that gives Protection to you and your allies." _
                                & vbCrLf & "Damage: 920" & vbCrLf & "Protection(1s): 33% damage reduction" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Damage nearby foes with a mighty ground slam." & vbCrLf & "Damage: 551" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Send a wave toward your foe that immobilizes enemies in a line." _
                                & vbCrLf & "Damage: 368" & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Launch your foe with a powerful smash." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Launch: 900" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Create a ring around you that foes cannot cross. Trapped enemies cannot exit the ring while it is active." _
                                & vbCrLf & "Duration: 5 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = True
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Wave_of_Wrath
            Mainfrm.PictureBox32.Image = My.Resources.Orb_of_Light
            Mainfrm.PictureBox37.Image = My.Resources.Flash_of_Light
            Mainfrm.PictureBox27.Image = My.Resources.Symbol_of_Swiftness
            Mainfrm.PictureBox26.Image = My.Resources.Line_of_Warding
            Mainfrm.PictureBox25.Image = My.Resources.Martyr
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Wave of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Orb of Light")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox37, "Flash of Light")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Symbol of Swiftness")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Line of Warding")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Martyr")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox37, Mainfrm.PictureBox37.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Send out a powerful shockwave, hitting up to five enemies." _
                                & vbCrLf & "Damage: 276" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Fire a slow-moving orb of light that can be detonated to Heal allies." _
                                & vbCrLf & "Damage: 551" & vbCrLf & "Healing: 1372" & vbCrLf & "Detonate Damage: 276" & vbCrLf & "Range: 1200" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Orb of Light > Flash of Light")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox37, "Chain. Detonate the orb to Heal nearby allies. Recharge on Orb of Light is set to 4" _
                                & "times it's basic recharge." & vbCrLf & "Damage: 276" & vbCrLf & "Healing: 803" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Sear a mystic symbol into the target area, damaging foes and granting" _
                                & vbCrLf & "Swiftness to allies." & vbCrLf & "Damage: 230" & vbCrLf & "Swiftness(2s): +33% movement speed" _
                                & vbCrLf & "Symbol radius: 180" & vbCrLf & "Symbol duration: 4 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Create a line in front of you that foes cannot cross." & vbCrLf & "Duration: 5 seconds")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Draw conditions from nearby allies to yourself. Gain multiple boons for a short" _
                                & "duration." & vbCrLf & "Fury(5s): +20% critical" & vbCrLf & "Vigor(5s): +100% endurance regen" _
                                & vbCrLf & "Might(5s): +5-35 Power" & vbCrLf & "Protection(5s): 33% damage reduction" & vbCrLf & "Regen(5s): +445 health regen" _
                                & vbCrLf & "Swiftness(5s): +33% movement speed" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Strike
            Mainfrm.PictureBox32.Image = My.Resources.Vengeful_Strike
            Mainfrm.PictureBox33.Image = My.Resources.Wrathful_Strike
            Mainfrm.PictureBox28.Image = My.Resources.Symbol_of_Wrath
            Mainfrm.PictureBox27.Image = My.Resources.Whirling_Wrath
            Mainfrm.PictureBox26.Image = My.Resources.Leap_of_Faith
            Mainfrm.PictureBox25.Image = My.Resources.Binding_Blade
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Vengeful Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Wrathful Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Symbol of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Whirling Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Leap of Faith")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Bindind Blade")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Strike your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Strike > Vengeful Strike > Wrathful Strike")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Strike your foe again." & vbCrLf & "Damage: 376" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Attack your foe with a wrathful strike." _
                                & vbCrLf & "Damage: 459" & vbCrLf & "Might(3s): +5-35 Power" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Pierce the ground with a mystic symbol that damages and Burns foes while" _
                                & "granting Retaliation to allies." & vbCrLf & "Damage: 230" & vbCrLf _
                                & "Retaliation(2s): Reflect incoming damage back to it's source" & vbCrLf & "Combo Field: Light")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Spin in place and swing your greatword while hurling powerful projectiles." _
                                & vbCrLf & "Damage: 1413" & vbCrLf & "Projectile Damage: 1412" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Leap at your foe. On hit, blind nearby foes." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Throw blades at your foes, causing damage over time. Bounds foe can be" _
                                & "Pulled to you. The effect end when a foe moves out of range" & vbCrLf & "Maximum blade duration: 10 seconds" _
                                & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 600")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Hammer" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Hammer_Swing1
            Mainfrm.PictureBox32.Image = My.Resources.Hammer_Bash1
            Mainfrm.PictureBox33.Image = My.Resources.Hammer_Smash
            Mainfrm.PictureBox28.Image = My.Resources.Fierce_Blow
            Mainfrm.PictureBox27.Image = My.Resources.Hammer_Shock
            Mainfrm.PictureBox26.Image = My.Resources.Staggering_Blow
            Mainfrm.PictureBox25.Image = My.Resources.Backbreaker
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Hammer Swing")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Hammer Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Hammer Smash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Fierce Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Hammer Shock")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Staggering Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Backbreaker")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Bash your foe." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Hammer Blow")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe again." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Smash the ground and damage nearby foes." _
                                & vbCrLf & "Damage: 821" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Weaken your foe with a fierce blow." & vbCrLf & "Damage: 645" & vbCrLf _
                                & "Weakness(8s): -50% Endurance Regeneration, 50% Fumble" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Smash the ground and send out a Crippling wave." _
                                & vbCrLf & "Damage: 410" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Push back nearby foes with a stuggering blow." & vbCrLf & "Damage: 703" & vbCrLf _
                                & "Knockback: 180" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Knock down your target foe." & vbCrLf & "Damage: 879" _
                                & vbCrLf & "Knockdown: 2 seconds" & vbCrLf & "Range: 130")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Greatsword_Swing
            Mainfrm.PictureBox32.Image = My.Resources.Greatsword_Slice
            Mainfrm.PictureBox33.Image = My.Resources.Brutal_Strike
            Mainfrm.PictureBox28.Image = My.Resources.Hundred_Blades
            Mainfrm.PictureBox27.Image = My.Resources.Whirlwind_Attack
            Mainfrm.PictureBox26.Image = My.Resources.Bladetrail
            Mainfrm.PictureBox25.Image = My.Resources.Rush
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Greatsword Swing")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Greatsword Slice")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Brutal Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Hundred Blades")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Whirlwind Attack")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Bladetrail")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Rush")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Greatsword Swing > Greatosword Slice > Brutal Strike")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Slice your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Hit your foes with a final brutal strike." _
                                & vbCrLf & "Damage: 480" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Repeatedly strike multiple foes. The last stike does extra damage." & vbCrLf & "Damage: 2756" & vbCrLf _
                                & "Final Strike Damage: 644" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Whirl in a target's direction, slashing foes along your path." _
                                & vbCrLf & "Damage: 373" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Throw your greatsword at your foe. It travels to your target and returns to you." _
                                & "Cripplings foes along your path." & vbCrLf & "Damage: 469" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Charge your foe." & vbCrLf & "Damage: 146" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Longbow" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Dual_Shot_png
            Mainfrm.PictureBox28.Image = My.Resources.Fan_of_Fire_png
            Mainfrm.PictureBox27.Image = My.Resources.Arcing_Arrow_png
            Mainfrm.PictureBox26.Image = My.Resources.Smoldering_Arrow_png
            Mainfrm.PictureBox25.Image = My.Resources.Pin_Down_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Dual Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Fan of Fire")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Arcing Arrow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Smoldering Arrow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Pin Down")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Shot a pair of arrows at your foe." & vbCrLf & "Damage: 284" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Fire a spread of three flaming arrows, Burning foes." & vbCrLf & "Damage: 168" _
                                & vbCrLf & "Burning(2s): -690 health" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Shot a slow, arcing arrow that explodes on impact." & vbCrLf & "Damage: 814" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Shot an arrow that explodes on impact. Blinding foes." _
                                & vbCrLf & "Damage: 112" & vbCrLf & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Fire an arrow that Immobilizes the target." & vbCrLf & "Damage: 234" _
                                & vbCrLf & "Immobilize(3s): Unable to move" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Rifle" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Bleeding_Shot_png
            Mainfrm.PictureBox28.Image = My.Resources.Aimed_Shot_png
            Mainfrm.PictureBox27.Image = My.Resources.Volley_png
            Mainfrm.PictureBox26.Image = My.Resources.Brutal_Shot_png
            Mainfrm.PictureBox25.Image = My.Resources.Rifle_Butt_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Bleeding Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Aimed Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Volley")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Brutal Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Rifle Butt")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Fire a shot that Bleeds your target." & vbCrLf & "Damage: 213" _
                                & vbCrLf & "Bleeding(6s): -270 damage over time" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Fire a precise shot that Cripples your foe." & vbCrLf & "Damage: 186" _
                                & vbCrLf & "Cripple(5s): -50% Speed" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Fire a volley of shots at your foe." & vbCrLf & "Damage: 376" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Shot your foes and make them Vulnerable." _
                                & vbCrLf & "Damage: 306" & vbCrLf & "Vulnerability(10s): -30 defence" & vbCrLf & "Combo Finisher: Physical Projectile" _
                                & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Push your foe back with your rifle butt." & vbCrLf & "Damage: 568" _
                                & vbCrLf & "Knockback: 450" & vbCrLf & "Range: 130")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox2.Text = "Rifle" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Hip_Shot
            Mainfrm.PictureBox28.Image = My.Resources.Net_Shot
            Mainfrm.PictureBox27.Image = My.Resources.Blunderbuss
            Mainfrm.PictureBox26.Image = My.Resources.Overcharged_Shot
            Mainfrm.PictureBox25.Image = My.Resources.Jump_Shot
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Hip Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Net Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Blunderbuss")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Overcharged Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Jump Shot")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Deliver a quick rifle shot from the hip." & vbCrLf & "Damage: 155" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Immobilizie foes with a net shot." & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Fire a cloud of sharpnel that causes more damage the closer you are to foes." _
                                & vbCrLf & "Within 8 fett: 621" & vbCrLf & "Within 16 feet: 563" & vbCrLf & "Within 24 feet: 466" _
                                & vbCrLf & "Within 32 feet: 388" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Fire a blast so strong it Launches your foe as you fall backward." _
                                & vbCrLf & "Damage: 388" & vbCrLf & "Enemy launch distance: 450" & vbCrLf & "Self knockback distance: 350" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Blast the ground, damaging nearby foes and leaping to your target." _
                                & vbCrLf & "Leap Damage: 466" & vbCrLf & "Landing Damage: 456" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 700")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox2.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = True
            Mainfrm.PictureBox29.Image = My.Resources.Slash
            Mainfrm.PictureBox32.Image = My.Resources.Slice
            Mainfrm.PictureBox33.Image = My.Resources.Power_Stab
            Mainfrm.PictureBox28.Image = My.Resources.Maul
            Mainfrm.PictureBox27.Image = My.Resources.Swoop
            Mainfrm.PictureBox26.Image = My.Resources.Counterattack
            Mainfrm.PictureBox39.Image = My.Resources.Crippling_Throw
            Mainfrm.PictureBox25.Image = My.Resources.Hilt_Bash
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Slash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Slice")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Power Stab")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Maul")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Swoop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Counterattack")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox39, "Crippling Throw")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Hilt Bash")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox39, Mainfrm.PictureBox39.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Slice > Power Stab")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Slice your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Stab your foe and Evade attacks." & vbCrLf & "Damage: 671" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Bleed your foe four times with a mauling strike." & vbCrLf & "Damage: 280" & vbCrLf _
                                & "Bleeding(4s): -1546 damage over time" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Run and leap at your foe, hitting them and nearby foes." _
                                & vbCrLf & "Damage: 783" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 770")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Chain. Block and counter an attack with a kick that pushes foes back." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Counterattack > Crippling Throw")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox39, "Chain. Throw your Greatsword, Crippling your foe." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Daze your foe with a hilt bash. Stun them if you hit from behind. Your pet's" _
                                & "next attack does 50% more damage." & vbCrLf & "Damage: 420" & vbCrLf & "Daze(1s): Unable to use skills" _
                                & vbCrLf & "Stun(1s): Unable to use skills or move" & vbCrLf & "Range: 300")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox2.Text = "Longbow" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Long_Range_Shot
            Mainfrm.PictureBox28.Image = My.Resources.Rapid_Fire
            Mainfrm.PictureBox27.Image = My.Resources.Hunter_s_Shot
            Mainfrm.PictureBox26.Image = My.Resources.Point_Blank_Shot
            Mainfrm.PictureBox25.Image = My.Resources.Barrage
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Long Range Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Rapid Fire")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Hunter's Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Point Blank Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Barrage")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Shot your foe with a long range arrow. The farther the arrows flies, the more damage it does." _
                                & vbCrLf & "1000+ Range: 509" & vbCrLf & "500-1000 Range: 382" & vbCrLf & "0-500 Range: 254" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Fire multiple arrows at your foe." & vbCrLf & "Damage: 2040" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20& chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Fire an arrow to make your foe Vulnerability. Your pet gains Swiftness." & vbCrLf & "Damage: 267" _
                                & vbCrLf & "Vulnerability(10s): -30 defense" & vbCrLf & "Pet Swiftness(10s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Push back your foe with a point-blank shot. The closer they are, the farther it knocks back." _
                                & vbCrLf & "Damage: 539" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Barrage the target area with a hail of arrows that Cripple." & vbCrLf & "Damage: 1836" _
                                & vbCrLf & "Cripple(3s): -50% Speed" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox2.Text = "Shortbow" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Cross_Fire
            Mainfrm.PictureBox28.Image = My.Resources.Poison_Volley
            Mainfrm.PictureBox27.Image = My.Resources.Quick_Shot
            Mainfrm.PictureBox26.Image = My.Resources.Crippling_Shot
            Mainfrm.PictureBox25.Image = My.Resources.Concussion_Shot
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Cross Fire")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Poison Volley")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Quick Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Crippling Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Concussion Shot")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Fire an arrow that bleeds your target if it hits your foe from behind or the side." _
                                & vbCrLf & "Damage: 204" & vbCrLf & "Bleeding(3s): -144 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Fire a spread of 5 poison arrows." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Poison(2s): -194 health, -33% reduce healing" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Fire a quick shot in an Evasive retreat. Gain Swiftness if the shot hits." _
                                & "This can be used while retreating." & vbCrLf & "Damage: 178" & vbCrLf & "Swiftness(3s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Shatter your foe's dreams of becoming an adventurer with a single arrow to the knee." _
                                & "Your pet's next three attacks inflict Bleeding." & vbCrLf & "Damage: 178" & vbCrLf & "Cripple(3s): -50% Speed" _
                                & vbCrLf & "Bleeding(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Daze your foe with an arrow. Stun them if you hit from behind or from the side." & vbCrLf & "Damage: 178" _
                                & vbCrLf & "Daze: 1 second" & vbCrLf & "Stun: 1 second" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Sword_of_Wrath
            Mainfrm.PictureBox32.Image = My.Resources.Sword_Arc
            Mainfrm.PictureBox33.Image = My.Resources.Sword_Wave
            Mainfrm.PictureBox28.Image = My.Resources.Flashing_Blade
            Mainfrm.PictureBox27.Image = My.Resources.Zealot_s_Defense
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Sword of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Sword Arc")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Sword Wave")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Flashing Blade")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Zealot's Defence")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe once." & vbCrLf & "Damage: 376" & vbCrLf _
                                & "Range: 150" & vbCrLf & "Skill Chain:" & vbCrLf & "Sword of Wrath > Sword Arc > Sword Wave")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Slash your foe again." & vbCrLf & "Damage: 459" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Send out a cone attack, striking up to three enemies." & vbCrLf & "Damage: 543" & vbCrLf _
                                & "Range: 280")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Teleport to your target, striking them and Blinding nearby foes." & vbCrLf _
                                & "Damage: 84" & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Block ranged attacks while throwing magical projectiles." & vbCrLf _
                                & "Damage: 1104" & vbCrLf & "Block Duration: 3 seconds" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Orb_of_Wrath_png
            Mainfrm.PictureBox28.Image = My.Resources.Smite_png
            Mainfrm.PictureBox27.Image = My.Resources.Chains_of_Light_png
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Orb of Wrath")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Smite")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Chains of Light")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Fire a slow-moving orb at your foe." & vbCrLf & "Damage: 355" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Strike foes in the target area repeatedly." & vbCrLf & "Damage: 2070" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Immobilize your foe with ethereal chains." & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.True_Strike
            Mainfrm.PictureBox32.Image = My.Resources.Pure_Strike
            Mainfrm.PictureBox33.Image = My.Resources.Faithful_Strike
            Mainfrm.PictureBox28.Image = My.Resources.Symbol_of_Faith
            Mainfrm.PictureBox27.Image = My.Resources.Protector_s_Strike
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "True Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Pure Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Faithful Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Symbol of Faith")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Protector's Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Smash your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "True Strike > Pure Strike > Faithful Strike")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe." & vbCrLf & "Damage: 470" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Hit your fow with a final strike and heal your neabry allies." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Healing: 534" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Smash a mystic symbol onto the ground that damages foes and regenerates allies." _
                                & vbCrLf & "Damage: 209" & vbCrLf & "Regen(1s): +356 health regen" & vbCrLf & "Symbol Duration: 4 seconds" _
                                & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 120")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Surround yourself and nearby allies with a shield. Knock back enemies that" _
                                & "strike protected allies. Grant Protection to yourself and nearby allies if you are" & "not struck." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Protection(5s): 33% damage reduction" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Sever_Artery_png
            Mainfrm.PictureBox32.Image = My.Resources.Gash_png
            Mainfrm.PictureBox33.Image = My.Resources.Final_Thrust_png
            Mainfrm.PictureBox28.Image = My.Resources.Savage_Leap_png
            Mainfrm.PictureBox27.Image = My.Resources.Hamstring_png
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Sever Artery")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Gash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Final Thrust")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Savage Leap")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Hamstring")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Bleed your foe with a slash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Sever Artery > Gash > Final Thrust")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Bleed your foe with a gash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Strike your foe with a final powerful thrust." & vbCrLf & "Damage: 693" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Lunge at your foe, striking them with your sword." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Cripple your foe with a precise slash." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Chop_png
            Mainfrm.PictureBox32.Image = My.Resources.Double_Chop_png
            Mainfrm.PictureBox33.Image = My.Resources.Triple_Chop_png
            Mainfrm.PictureBox28.Image = My.Resources.Cyclone_Axe_png
            Mainfrm.PictureBox27.Image = My.Resources.Throw_Axe_png
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Chop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Double Chop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Triple Chop")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Cyclone Ace")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Throw Axe")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Chop your foe." & vbCrLf & "Damage: 453" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Chop > Double Chop > Triple Chop")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Chop your foe twice." & vbCrLf & "Damage: 906" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Deliver three final chop at your foe." & vbCrLf & "Damage: 1359" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Spin around and attack all nearby foes." & vbCrLf & "Damage: 399" _
                                & vbCrLf & "Vulnerability(8s): -30 defence" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Throw an axe that Cripples enemies." & vbCrLf & "Damage: 357" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox32.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox33.Image = My.Resources.Pulverize_png
            Mainfrm.PictureBox28.Image = My.Resources.Counter_Blow_png
            Mainfrm.PictureBox27.Image = My.Resources.Pommel_Bash_png
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Mace Smash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Mace Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Pulverize")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Counter Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Pommel Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Smash your foe." & vbCrLf & "Damage: 448" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Mace Smash > Mace Bash > Pulverize")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe." & vbCrLf & "Damage: 426" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Trash your foe, leaving them weakened." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Weakness(5s): -50% Endurance Regen, 50% Fumble" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Block the next attack. Counter with an attack if you are in melee range. Gain adrenaline if not attacked." _
                                & vbCrLf & "Damage: 532")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Daze your foe with a brutal pommel bash." & vbCrLf & "Damage: 224" & vbCrLf & "Daze: 1 second" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox2.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Explosive_Shot
            Mainfrm.PictureBox28.Image = My.Resources.Poison_Dart_Volley
            Mainfrm.PictureBox27.Image = My.Resources.Static_Shot
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Explosive Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Poison Dart Volley")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Static Shot")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Fire a shot that explode on impact, Bleeding nearby foes." _
                                & vbCrLf & "Damage: 108" & vbCrLf & "Bleeding(4s): -192 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Fire a volley of darts that poison foes." _
                                & vbCrLf & "Damage: 89" & vbCrLf & "Poison(2s): -192 health, -33% reduce healing" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Discharge a lightning shot that bounces Blind and Confusion to multiple enemies." _
                                & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Confusion(3s): -77 health per skill used" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = True
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Slash
            Mainfrm.PictureBox32.Image = My.Resources.Kick
            Mainfrm.PictureBox33.Image = My.Resources.Pounce
            Mainfrm.PictureBox28.Image = My.Resources.Hornet_Sting
            Mainfrm.PictureBox37.Image = My.Resources.Monarch_s_Leap
            Mainfrm.PictureBox27.Image = My.Resources.Serpent_s_Strike
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Slash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox32, "Kick")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox33, "Pounce")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Hornet Sting")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox37, "Monarch's Leap")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Serpent's Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox37, Mainfrm.PictureBox37.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe." & vbCrLf & "Damage: 305" & vbCrLf _
                                & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Kick > Pounce")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox32, "Chain. Kick your foe causing a short Cripple." & vbCrLf & "Damage: 305" _
                                & vbCrLf & "Cripple(2s): -50% Movement Speed" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox33, "Chain. Leap at target foe, striking them. Your pet gain Might." & vbCrLf & "Damage: 509" & vbCrLf _
                                & vbCrLf & "Might(5s): +5-35 Power" & "Range: 430")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Chain. Stab your foe, then Evade backward." & vbCrLf & "Damage: 662" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hornet Sting > Monarch's Leap")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox37, "Chain. Leap back into the fight. Crippling your foe." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Cripple(3s): -50% Movement Speed" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Do an Evasive roll around your target, striking them and poisoning them." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Poison(6s): -582 health, -33% reduce healing" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox2.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Ricochet
            Mainfrm.PictureBox28.Image = My.Resources.Splitblade
            Mainfrm.PictureBox27.Image = My.Resources.Winter_s_Bite
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox29, "Ricochet")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox28, "Splitblade")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox27, "Winter's Bite")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox29, "Bounce your axe off multiple foes." & vbCrLf & "Damage: 356" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox28, "Throw a spread pattern of 5 whirling axes that Bleeds foes." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Bleed(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox27, "Throw an axe to Chill your foe. Your pet's next attacks inflicts Weakness." & vbCrLf & "Damage: 254" _
                                & vbCrLf & "Chilled(3s): -66% speed/recharge" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        End If
    End Sub
#End Region

#Region "ComboBox3"
    Public Sub CmbBox3()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Shield_of_Judgment_png
            Mainfrm.PictureBox13.Image = My.Resources.Shield_of_Absorption_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Shield of Judgment")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Shield of Absorption")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Create a shielding wave in front of you that damages foe and gives" _
                                & vbCrLf & "Protection to yourself and up to five allies." & vbCrLf & "Damage: 376" & vbCrLf & "Protection(5s): 33% damage reduction" _
                                & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Create a dome aroung you that Pushes foes back and Absorb projectiles." _
                                & vbCrLf & "KnockBack Distance: 320" & vbCrLf & "Shield duration: 4 seconds" & vbCrLf & "Combo Field: Light")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Focus" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Ray_of_Judgment
            Mainfrm.PictureBox13.Image = My.Resources.Shield_of_Wrath
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Ray of Judgment")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Shield of Wrath")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Pass a ray over foes and allies. Foes are damaged and Blinded. Allies gain" _
                                & "Regeneration and lose one condition." & vbCrLf & "Damage: 188" & vbCrLf & "Blindness(5s): Next outgoing attack misses" _
                                & vbCrLf & "Regen(5s): +455 health regen" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Create a shield to Block the next 3 attacks. If the shield is not destroyed, it" _
                                & "explodes, damaging nearby foes." & vbCrLf & "Damage: 1044" & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 255")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Torch" Then
            Mainfrm.PictureBox34.Visible = True
            Mainfrm.PictureBox12.Image = My.Resources.Cleansing_Flame_png
            Mainfrm.PictureBox13.Image = My.Resources.Zealot_s_Flame_png
            Mainfrm.PictureBox34.Image = My.Resources.Zealot_s_Fire
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Cleasing Flame")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Zealot's Flame")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox34, "Zealot's Fire")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox34, Mainfrm.PictureBox34.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Breathe magical flames than damages foes and remove condition from allies." _
                                & vbCrLf & "Damage: 94" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Chain. Set yourself alightm, preiodically Burning up to threee nearby foes." _
                                & vbCrLf & "Duration: 10 seconds" & vbCrLf & "Skill Chain:" & vbCrLf & "Zealot's Flame > Zealot's Fire")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox34, "Chain. Throw your Zealot's Flame at the targeted foe, damaging them" _
                                & "but increasing the skill's recharge time by 50%." & vbCrLf & "Damage: ???" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Sword" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Impale_png
            Mainfrm.PictureBox13.Image = My.Resources.Riposte_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Impale")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Risposte")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Throw our sword at your foe and apply multiple stacks of Bleeding over time." _
                                & vbCrLf & "Damage: 301" & vbCrLf & "Bleeding(12s): -2,160 damage over time" & vbCrLf & "Combo Finisher: Physical projectile" _
                                & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Block the next incoming attack. Risposte and Bleed your foe if you block a melee" _
                                & "attack. Gain adrenaline if your are not attacked." & vbCrLf & "Damage: 266" & vbCrLf & "Bleeding(12s): -2160 damage over time")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Shield_Bash_png
            Mainfrm.PictureBox13.Image = My.Resources.Shield_Stance_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Shield Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Shield Stance")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Bash your foe with your shield and Stun them." & vbCrLf & "Damage: 479" & vbCrLf & "Stun: 1 second" _
                                & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Block incoming attacks." & vbCrLf & "Duration: 3 seconds")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Axe" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Dual_Strike_png
            Mainfrm.PictureBox13.Image = My.Resources.Whirling_Axe_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Dual Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Whirling Axe")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Strike your foe with both axes. Gain Fury with each hit." & vbCrLf & "Damage: 638" _
                                & vbCrLf & "Fury(2s): +20% critical" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Spin and attacking nearby foes. You can move while spinning." & vbCrLf & "Damage: 1590" _
                                & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Warhorn" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Charge_png
            Mainfrm.PictureBox13.Image = My.Resources.Call_to_Arms_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Charge")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Call to Arms")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Grant swiftness to yourself and allies, while removing Chill, Cripple and Immobilize." _
                                & vbCrLf & "Swiftness(10s): +33% Movement Speed" & vbCrLf & "Removes Cripple: -50% Movement Speed" _
                                & vbCrLf & "Removes Immobilizes: Unable to move" & vbCrLf & "Removes Frozen: -66% Speed/Recharge" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Grant Vigor to yourself and allies, while Weakening nearby foes." _
                                & vbCrLf & "Vigor(10s): +100% Endurance regeneration" & vbCrLf & "Weakness(6s): -50% Endurance Regeneration, 50% Fumble" _
                                & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Mace" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Crushing_Blow
            Mainfrm.PictureBox13.Image = My.Resources.Tremor_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Crushing Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Tremor")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Crash your opponent's armor, leaving them Vulnerable." & vbCrLf & "Damage: 532" _
                                & vbCrLf & "Vulnerability(10s): -50 defence" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Send a wave toward your foe that knocks down enemies in a line." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Knockdown: 2 seconds" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox3.Text = "Pistol" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Blowtorch
            Mainfrm.PictureBox13.Image = My.Resources.Glue_Shot
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Blowtorch")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Glue Shot")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Unleash flame from your pistol to Burn foes." & vbCrLf & "Damage: 67" _
                                & vbCrLf & "Within 15 feet(9s): -3231 health" & vbCrLf & "Within 30 feet(6s): -2154 health" _
                                & vbCrLf & "Within 45 feet(3s): -1077 health" & vbCrLf & "Range: 550")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Coat the target area with a glue paddle that Immobilizes foes." _
                                & vbCrLf & "Immobilize(1s): Unable to move" & vbCrLf & "Glue paddle duration: 6 seconds" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Magnetic_Field
            Mainfrm.PictureBox13.Image = My.Resources.Static_Shield
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox12, "Magnetic Field")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox13, "Static Shield")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox12, "Create a magnetic field that Reflects projectiles and can be released to Push" _
                                & "back foes." & vbCrLf & "Damage: 61" & vbCrLf & "Knockback: 300")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox13, "Electrify your shield, preparing to throw it at foes. If you are hit, the shield" _
                                & "discharges, Stunning your nearby attacker." & vbCrLf & "Stun: 3 seconds")
        End If
    End Sub
#End Region

#Region "ComboBox4"
    Public Sub CmbBox4()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Shield_of_Judgment_png
            Mainfrm.PictureBox25.Image = My.Resources.Shield_of_Absorption_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Shield of Judgment")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Shield of Absorption")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Create a shielding wave in front of you that damages foe and gives" _
                                & "Protection to yourself and up to five allies." & vbCrLf & "Damage: 376" & vbCrLf & "Protection(5s): 33% damage reduction" _
                                & vbCrLf & "Range: 600")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Create a dome aroung you that Pushes foes back and Absorb projectiles." _
                                & vbCrLf & "KnockBack Distance: 320" & vbCrLf & "Shield duration: 4 seconds" & vbCrLf & "Combo Field: Light")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Focus" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Ray_of_Judgment
            Mainfrm.PictureBox25.Image = My.Resources.Shield_of_Wrath
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Ray of Judgment")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Shield of Wrath")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Pass a ray over foes and allies. Foes are damaged and Blinded. Allies gain" _
                                & "Regeneration and lose one condition." & vbCrLf & "Damage: 188" & vbCrLf & "Blindness(5s): Next outgoing attack misses" _
                                & vbCrLf & "Regen(5s): +455 health regen" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Create a shield to Block the next 3 attacks. If the shield is not destroyed, it" _
                                & "explodes, damaging nearby foes." & vbCrLf & "Damage: 1044" & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 255")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Torch" Then
            Mainfrm.PictureBox35.Visible = True
            Mainfrm.PictureBox26.Image = My.Resources.Cleansing_Flame_png
            Mainfrm.PictureBox25.Image = My.Resources.Zealot_s_Flame_png
            Mainfrm.PictureBox35.Image = My.Resources.Zealot_s_Fire
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Cleasing Flmae")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Zealot's Flame")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox35, "Zealot's Fire")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox35, Mainfrm.PictureBox35.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Breathe magical flames than damages foes and remove condition from allies." _
                                & vbCrLf & "Damage: 94" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Chain. Set yourself alightm, preiodically Burning up to threee nearby foes." _
                                & vbCrLf & "Duration: 10 seconds" & vbCrLf & "Skill Chain:" & vbCrLf & "Zealot's Flame > Zealot's Fire")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox35, "Chain. Throw your Zealot's Flame at the targeted foe, damaging them" _
                                & "but increasing the skill's recharge time by 50%." & vbCrLf & "Damage: ???" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Sword" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Impale_png
            Mainfrm.PictureBox25.Image = My.Resources.Riposte_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Impale")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Risposte")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Throw our sword at your foe and apply multiple stacks of Bleeding over time." _
                                & vbCrLf & "Damage: 301" & vbCrLf & "Bleeding(12s): -2,160 damage over time" & vbCrLf & "Combo Finisher: Physical projectile" _
                                & vbCrLf & "Range: 900")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Block the next incoming attack. Risposte and Bleed your foe if you block a melee" _
                                & "attack. Gain adrenaline if your are not attacked." & vbCrLf & "Damage: 266" & vbCrLf & "Bleeding(12s): -2160 damage over time")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Shield_Bash_png
            Mainfrm.PictureBox25.Image = My.Resources.Shield_Stance_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Shield Bash")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Shield Stance")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Bash your foe with your shield and Stun them." & vbCrLf & "Damage: 479" & vbCrLf & "Stun: 1 second" _
                                & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Block incoming attacks." & vbCrLf & "Duration: 3 seconds")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Axe" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Dual_Strike_png
            Mainfrm.PictureBox25.Image = My.Resources.Whirling_Axe_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Dual Strike")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Whirling Axe")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Strike your foe with both axes. Gain Fury with each hit." & vbCrLf & "Damage: 638" _
                                & vbCrLf & "Fury(2s): +20% critical" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Spin and attacking nearby foes. You can move while spinning." & vbCrLf & "Damage: 1590" _
                                & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Warhorn" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Charge_png
            Mainfrm.PictureBox25.Image = My.Resources.Call_to_Arms_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Charge")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Call to Arms")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Grant swiftness to yourself and allies, while removing Chill, Cripple and Immobilize." _
                                & vbCrLf & "Swiftness(10s): +33% Movement Speed" & vbCrLf & "Removes Cripple: -50% Movement Speed" _
                                & vbCrLf & "Removes Immobilizes: Unable to move" & vbCrLf & "Removes Frozen: -66% Speed/Recharge" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Grant Vigor to yourself and allies, while Weakening nearby foes." _
                                & vbCrLf & "Vigor(10s): +100% Endurance regeneration" & vbCrLf & "Weakness(6s): -50% Endurance Regeneration, 50% Fumble" _
                                & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Mace" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Crushing_Blow
            Mainfrm.PictureBox25.Image = My.Resources.Tremor_png
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Crushing Blow")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Tremor")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Crash your opponent's armor, leaving them Vulnerable." & vbCrLf & "Damage: 532" _
                                & vbCrLf & "Vulnerability(10s): -50 defence" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Send a wave toward your foe that knocks down enemies in a line." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Knockdown: 2 seconds" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox4.Text = "Pistol" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Blowtorch
            Mainfrm.PictureBox25.Image = My.Resources.Glue_Shot
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Blowtorch")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Glue Shot")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Unleash flame from your pistol to Burn foes." & vbCrLf & "Damage: 67" _
                                & vbCrLf & "Within 15 feet(9s): -3231 health" & vbCrLf & "Within 30 feet(6s): -2154 health" _
                                & vbCrLf & "Within 45 feet(3s): -1077 health" & vbCrLf & "Range: 550")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Coat the target area with a glue paddle that Immobilizes foes." _
                                & vbCrLf & "Immobilize(1s): Unable to move" & vbCrLf & "Glue paddle duration: 6 seconds" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Magnetic_Field
            Mainfrm.PictureBox25.Image = My.Resources.Static_Shield
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox26, "Magnetic Field")
            Mainfrm.ToolTip1.SetToolTipTitle(Mainfrm.PictureBox25, "Static Shield")
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip1.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox26, "Create a magnetic field that Reflects projectiles and can be released to Push" _
                                & "back foes." & vbCrLf & "Damage: 61" & vbCrLf & "Knockback: 300")
            Mainfrm.ToolTip1.SetToolTip(Mainfrm.PictureBox25, "Electrify your shield, preparing to throw it at foes. If you are hit, the shield" _
                                & "discharges, Stunning your nearby attacker." & vbCrLf & "Stun: 3 seconds")
        End If
    End Sub
#End Region
End Class
