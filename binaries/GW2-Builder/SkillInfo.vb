Public Class SkillInfo
    Dim cls As New RCls

    'All the Skill Info Subroutines is based on the mouse hover
    'of a picturebox, example: SkillInfo1 is based on mouse hover of
    'PictureBox9 of the Mainfrm and only for the first weapon skill of all classes
    'List of the PictureBox:
    'PictureBox9 - PictureBox10 - PictureBox11 - PictureBox12 - PictureBox 13 and
    'the sub PictureBox for chained skills is: PictureBox30 & 31 for PictureBox9,
    'PictureBox36 for PictureBox10, PictureBox38 for PictureBox12 and PictureBox34
    'for PictureBox 13. This is only for first rows, the main action bar.

#Region "Skill Information"
    Public Sub SkillInfo1() '#PictureBox9
        cls.ResetSkillInfo()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Hammer" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Hammer Swing"
            Mainfrm.Label35.Text = "Chain. Strike your foe."
            Mainfrm.Label36.Text = "Damage: 368"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Staff" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Wave of Wrath"
            Mainfrm.Label35.Text = "Send out a powerful shockwave, hitting up to five enemies."
            Mainfrm.Label36.Text = "Damage: 276"
            Mainfrm.Label37.Text = "Range: 600"
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Strike"
            Mainfrm.Label35.Text = "Chain. Strike your foe."
            Mainfrm.Label36.Text = "Damage: 334"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Hammer" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Hammer Swing"
            Mainfrm.Label35.Text = "Chain. Bash your foe."
            Mainfrm.Label36.Text = "Damage: 586"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.vulnerability
            Mainfrm.PictureBox76.Image = My.Resources.range
            Mainfrm.Label34.Text = "Greatsword Swing"
            Mainfrm.Label35.Text = "Chain. Slash your foe."
            Mainfrm.Label36.Text = "Damage: 373"
            Mainfrm.Label37.Text = "Vulnerability(8s): -30 defense"
            Mainfrm.Label38.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.combo
            Mainfrm.PictureBox76.Image = My.Resources.range
            Mainfrm.Label34.Text = "Dual Shot"
            Mainfrm.Label35.Text = "Shot a pair of arrows at your foe."
            Mainfrm.Label36.Text = "Damage: 284"
            Mainfrm.Label37.Text = "Combo Finisher: Projectile (20% chance)"
            Mainfrm.Label38.Text = "Range: 900"
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = True
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = True
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.bleeding
            Mainfrm.PictureBox76.Image = My.Resources.combo
            Mainfrm.PictureBox77.Image = My.Resources.range
            Mainfrm.Label34.Text = "Bleeding Shot"
            Mainfrm.Label35.Text = "Fire a shot that Bleeds your target."
            Mainfrm.Label36.Text = "Damage: 213"
            Mainfrm.Label37.Text = "Bleeding(6s): -270 damage over time"
            Mainfrm.Label38.Text = "Combo Finisher: Projectile (20% chance)"
            Mainfrm.Label39.Text = "Range: 1200"
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.combo
            Mainfrm.PictureBox76.Image = My.Resources.range
            Mainfrm.Label34.Text = "Hip Shot"
            Mainfrm.Label35.Text = "Deliver a quick rifle shot from the hip."
            Mainfrm.Label36.Text = "Damage: 155"
            Mainfrm.Label37.Text = "Combo Finisher: Physical Projectile (20% chance)"
            Mainfrm.Label38.Text = "Range: 1000"
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Slash"
            Mainfrm.Label35.Text = "Slash your foe."
            Mainfrm.Label36.Text = "Damage: 503"
            Mainfrm.Label37.Text = "Range: 150"
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = True
            Mainfrm.PictureBox78.Visible = True
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = True
            Mainfrm.Label40.Visible = True
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.damage
            Mainfrm.PictureBox76.Image = My.Resources.damage
            Mainfrm.PictureBox77.Image = My.Resources.combo
            Mainfrm.PictureBox78.Image = My.Resources.range
            Mainfrm.Label34.Text = "Long Range Shot"
            Mainfrm.Label35.Text = "Shot your foe with a long range arrow. The farther the arrows flies, the more damage it does."
            Mainfrm.Label36.Text = "1000+ Range: 509"
            Mainfrm.Label37.Text = "500-1000 range: 183"
            Mainfrm.Label38.Text = "0-500 range: 122"
            Mainfrm.Label39.Text = "Combo Finisher: Physical Projectile (20% chance)"
            Mainfrm.Label40.Text = "Range: 1200"
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Shortbow" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = True
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = True
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.bleeding
            Mainfrm.PictureBox76.Image = My.Resources.combo
            Mainfrm.PictureBox77.Image = My.Resources.range
            Mainfrm.Label34.Text = "Cross Fire"
            Mainfrm.Label35.Text = "Fire an arrow that bleeds your target if it hits your foe from behind or the side."
            Mainfrm.Label36.Text = "Damage: 204"
            Mainfrm.Label37.Text = "Bleeding(3s): -144 damage over time"
            Mainfrm.Label38.Text = "Combo Finisher: Physical Projectile (20% chance)"
            Mainfrm.Label39.Text = "Range: 1200"
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = False
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = False
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.range
            Mainfrm.Label34.Text = "Spartial Surge"
            Mainfrm.Label35.Text = "Shoot a beam at your foe. The farther away they are, the more damage you deal."
            Mainfrm.Label36.Text = "Range: 1200"
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Sword of Wrath"
            Mainfrm.Label35.Text = "Chain. Slash your foe once."
            Mainfrm.Label36.Text = "Damage: 376"
            Mainfrm.Label37.Text = "Range: 150"
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Orb of Wrath"
            Mainfrm.Label35.Text = "Fire a slow-moving orb at your foe."
            Mainfrm.Label36.Text = "Damage: 355"
            Mainfrm.Label37.Text = "Range: 900"
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "True Strike"
            Mainfrm.Label35.Text = "Chain. Smash your foe."
            Mainfrm.Label36.Text = "Damage: 334"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.bleeding
            Mainfrm.PictureBox76.Image = My.Resources.range
            Mainfrm.Label34.Text = "Sever Array"
            Mainfrm.Label35.Text = "Chain. Bleed your foe with a slash."
            Mainfrm.Label36.Text = "Damage: 320"
            Mainfrm.Label37.Text = "Bleedind(8s): -360 damage over time"
            Mainfrm.Label38.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Chop"
            Mainfrm.Label35.Text = "Chain. Chop your foe."
            Mainfrm.Label36.Text = "Damage: 453"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Mace Smash"
            Mainfrm.Label35.Text = "Chain. Smash your foe."
            Mainfrm.Label36.Text = "Damage: 448"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = True
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = True
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.bleeding
            Mainfrm.PictureBox76.Image = My.Resources.combo
            Mainfrm.PictureBox77.Image = My.Resources.range
            Mainfrm.Label34.Text = "Explosive Shot"
            Mainfrm.Label35.Text = "Fire a shot that explode on impact, Bleeding nearby foes."
            Mainfrm.Label36.Text = "Damage: 108"
            Mainfrm.Label37.Text = "Bleeding(4s): -192 damage over time"
            Mainfrm.Label38.Text = "Combo Finisher: Physical Projectile (20% chance)"
            Mainfrm.Label39.Text = "Range: 900"
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Slash"
            Mainfrm.Label35.Text = "Chain. Slash your foe."
            Mainfrm.Label36.Text = "Damage: 105"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.combo
            Mainfrm.PictureBox76.Image = My.Resources.range
            Mainfrm.Label34.Text = "Ricochet"
            Mainfrm.Label35.Text = "Bounce your axe off multiple foes."
            Mainfrm.Label36.Text = "Damage: 356"
            Mainfrm.Label37.Text = "Combo Finisher: Physical Projectile (20% chance)"
            Mainfrm.Label38.Text = "Range: 900"
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Slice"
            Mainfrm.Label35.Text = "Chain. Slice your foe."
            Mainfrm.Label36.Text = "Damage: 394"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Dagger" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = False
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = False
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.range
            Mainfrm.Label34.Text = "Double Strike"
            Mainfrm.Label35.Text = "Chain. Strike your foe twice."
            Mainfrm.Label36.Text = "Damage: 279"
            Mainfrm.Label37.Text = "Range: 130"
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = True
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = True
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.bleeding
            Mainfrm.PictureBox76.Image = My.Resources.combo
            Mainfrm.PictureBox77.Image = My.Resources.range
            Mainfrm.Label34.Text = "Vital Shoy"
            Mainfrm.Label35.Text = "Bleed your foe with a shot to the vitals."
            Mainfrm.Label36.Text = "Damage: 179"
            Mainfrm.Label37.Text = "Bleeding(3s): -192 damage over time"
            Mainfrm.Label38.Text = "Combo Finisher: Physical Projectile (20% chance)"
            Mainfrm.Label39.Text = "Range: 900"
        End If
    End Sub

    Public Sub SkillInfo2() '#PictureBox10
        cls.ResetSkillInfo()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Hammer" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = False
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = False
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.combo
            Mainfrm.PictureBox76.Image = My.Resources.range
            Mainfrm.Label34.Text = "Mighty Blow"
            Mainfrm.Label35.Text = "Damages neabry foes with mighty ground slam."
            Mainfrm.Label36.Text = "Damage: 321"
            Mainfrm.Label37.Text = "Combo Finisher: Blast"
            Mainfrm.Label38.Text = "Range: 180"
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Staff" Then '#two hand
            Mainfrm.PictureBox19.Visible = True
            Mainfrm.PictureBox74.Visible = True
            Mainfrm.PictureBox75.Visible = True
            Mainfrm.PictureBox76.Visible = True
            Mainfrm.PictureBox77.Visible = True
            Mainfrm.PictureBox78.Visible = False
            Mainfrm.Label34.Visible = True
            Mainfrm.Label35.Visible = True
            Mainfrm.Label36.Visible = True
            Mainfrm.Label37.Visible = True
            Mainfrm.Label38.Visible = True
            Mainfrm.Label39.Visible = True
            Mainfrm.Label40.Visible = False
            Mainfrm.PictureBox19.Image = Mainfrm.PictureBox9.Image
            Mainfrm.PictureBox74.Image = My.Resources.damage
            Mainfrm.PictureBox75.Image = My.Resources.healing
            Mainfrm.PictureBox76.Image = My.Resources.damage
            Mainfrm.PictureBox77.Image = My.Resources.range
            Mainfrm.Label34.Text = "Orb of Light"
            Mainfrm.Label35.Text = "Fire a slow-moving orb of light that can be detonated to Heal allies."
            Mainfrm.Label36.Text = "Damage: 321"
            Mainfrm.Label37.Text = "Health: 1302"
            Mainfrm.Label38.Text = "Detonate Damage: 161"
            Mainfrm.Label39.Text = "Range: 1200"
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Hammer" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Shortbow" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand

        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Dagger" Then '#one hand

        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand

        End If
    End Sub
#End Region
End Class
