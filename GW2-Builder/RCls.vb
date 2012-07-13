Public Class RCls
#Region "Forms Load"
    Dim ver As String = "GW2 Builder - " + Application.ProductVersion

    Public Sub MfrmLoad()
        ResetImage()

        Mainfrm.Text = ver
        Mainfrm.TopMost = False
        Mainfrm.Label6.Text = ver
        Mainfrm.Label32.Visible = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Enabled = False
        Mainfrm.ComboBox2.Enabled = False
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.Label10.Visible = False
        Mainfrm.Label11.Visible = False
        Mainfrm.Label12.Visible = False
        Mainfrm.Label13.Visible = False
        Mainfrm.Label14.Visible = False
        Mainfrm.Label15.Visible = False
        Mainfrm.Label16.Visible = False
        Mainfrm.Label17.Visible = False
        Mainfrm.Label18.Visible = False
        Mainfrm.Label19.Visible = False
        Mainfrm.Label20.Visible = False
        Mainfrm.Label21.Visible = False
        Mainfrm.Label22.Visible = False
        Mainfrm.Label23.Visible = False
        Mainfrm.Label24.Visible = False
        Mainfrm.Label25.Visible = False
        Mainfrm.Label26.Visible = False
        Mainfrm.Label27.Visible = False
        Mainfrm.Label28.Visible = False
        Mainfrm.Label29.Visible = False

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
        Mainfrm.PictureBox40.Visible = False
        Mainfrm.PictureBox41.Visible = False
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = False
        Mainfrm.PictureBox50.Visible = False
        Mainfrm.PictureBox51.Visible = False
        Mainfrm.PictureBox52.Visible = False
        Mainfrm.PictureBox53.Visible = False
        Mainfrm.PictureBox54.Visible = False
        Mainfrm.PictureBox55.Visible = False
        Mainfrm.PictureBox56.Visible = False
        Mainfrm.PictureBox57.Visible = False
        Mainfrm.PictureBox58.Visible = False
        Mainfrm.PictureBox59.Visible = False
        Mainfrm.PictureBox60.Visible = False
        Mainfrm.PictureBox61.Visible = False
        Mainfrm.PictureBox62.Visible = False
        Mainfrm.PictureBox63.Visible = False
        Mainfrm.PictureBox64.Visible = False
        Mainfrm.PictureBox65.Visible = False
        Mainfrm.PictureBox66.Visible = False
        Mainfrm.PictureBox67.Visible = False
        Mainfrm.PictureBox68.Visible = False
        Mainfrm.PictureBox74.Visible = False
        Mainfrm.PictureBox75.Visible = False
        Mainfrm.PictureBox76.Visible = False
        Mainfrm.PictureBox77.Visible = False
        Mainfrm.PictureBox78.Visible = False

        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"
        Mainfrm.Label30.Text = "70"

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label8, "Information")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label2, "Minimize")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label1, "Close")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label6, "Double click to enable always on top")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox1, "Guardian")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox2, "Warrior")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox3, "Engineer")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox4, "Ranger")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox5, "Thief")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox6, "Elementalist")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox7, "Mesmer")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox8, "Necromancer")
    End Sub

    Public Sub SfrmLoad()
        Selectfrm.ToolTip1.SetToolTip(Selectfrm.Label1, "Close")
        If Mainfrm.Label9.Text = "g" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "w" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "en" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "r" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "t" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "el" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "m" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        ElseIf Mainfrm.Label9.Text = "n" Then
            Selectfrm.Size = New Size(221, 103)
            Selectfrm.PictureBox1.Visible = True
            Selectfrm.PictureBox2.Visible = True
            Selectfrm.PictureBox3.Visible = True
            Selectfrm.Label1.Location = New Point(194, 9)
            Selectfrm.PictureBox1.Location = New Point(12, 39)
            Selectfrm.PictureBox2.Location = New Point(84, 39)
            Selectfrm.PictureBox3.Location = New Point(155, 39)
        End If
    End Sub

	Public Sub ResetSkillInfo()
	    Mainfrm.Label34.Visible = False
        Mainfrm.Label35.Visible = False
        Mainfrm.Label36.Visible = False
        Mainfrm.Label37.Visible = False
        Mainfrm.Label38.Visible = False
        Mainfrm.Label39.Visible = False
        Mainfrm.Label40.Visible = False
        Mainfrm.PictureBox19.Visible = False
        Mainfrm.PictureBox74.Visible = False
        Mainfrm.PictureBox75.Visible = False
        Mainfrm.PictureBox76.Visible = False
        Mainfrm.PictureBox77.Visible = False
        Mainfrm.PictureBox78.Visible = False
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
        Mainfrm.PictureBox40.Visible = False
        Mainfrm.PictureBox41.Visible = False
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False

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

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox1, "Guardian")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox2, "Warrior")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox3, "Engineer")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox4, "Ranger")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox5, "Thief")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox6, "Elementalist")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox7, "Mesmer")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox8, "Necromancer")

        If Mainfrm.Label9.Text = "Label9" Then
            Mainfrm.ToolTip3.OwnerDraw = False
            Mainfrm.ToolTip3.OwnerDrawBackground = False
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox9, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox10, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox11, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox12, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox13, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox29, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox28, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox27, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox26, "Select a one hand or a two hand weapon first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox25, "Select a one hand or a two hand weapon first")

            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox14, "Select a class first")
            Mainfrm.ToolTip3.SetToolTip(Mainfrm.PictureBox24, "Select a class first")
        Else
            Mainfrm.ToolTip3.Dispose()
            Mainfrm.ToolTip3.OwnerDraw = True
            Mainfrm.ToolTip3.OwnerDrawBackground = True
        End If
    End Sub

    Public Sub LblDClick()
        If Mainfrm.TopMost = True Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label6, "Double click to enable always on top")
            Mainfrm.TopMost = False
            Mainfrm.Label6.Text = ver
        ElseIf Mainfrm.TopMost = False Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label6, "Double click to disable always on top")
            Mainfrm.TopMost = True
            Mainfrm.Label6.Text = ver + " - On Top"
        End If
    End Sub
#End Region

#Region "Class Choise"
    Public Sub Guardian()
        Mainfrm.Label9.Text = "g"

        Mainfrm.PictureBox1.Image = My.Resources.guardian
        Mainfrm.PictureBox2.Image = My.Resources.warrior_off
        Mainfrm.PictureBox3.Image = My.Resources.engineer_off
        Mainfrm.PictureBox4.Image = My.Resources.ranger_off
        Mainfrm.PictureBox5.Image = My.Resources.thief_off
        Mainfrm.PictureBox6.Image = My.Resources.elementalist_off
        Mainfrm.PictureBox7.Image = My.Resources.mesmer_off
        Mainfrm.PictureBox8.Image = My.Resources.necromancer_off

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = True
        Mainfrm.PictureBox41.Visible = True
        Mainfrm.PictureBox42.Visible = True
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox40.Image = My.Resources.Virtue_of_Justice
        Mainfrm.PictureBox41.Image = My.Resources.Virtue_of_Resolve
        Mainfrm.PictureBox42.Image = My.Resources.Virtue_of_Courage
        Mainfrm.PictureBox44.Image = My.Resources.Zeal___Guardian
        Mainfrm.PictureBox45.Image = My.Resources.Radiance___Guardian
        Mainfrm.PictureBox46.Image = My.Resources.Valor___Guardian
        Mainfrm.PictureBox47.Image = My.Resources.Honor___Guardian
        Mainfrm.PictureBox48.Image = My.Resources.Virtues___Guardian

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Concentration
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Expertise
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Prowess
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Compassion
        Mainfrm.PictureBox68.Image = My.Resources.Malice
        Mainfrm.PictureBox67.Image = My.Resources.Willpower

        Mainfrm.Label32.Visible = True
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Virtue of Justice")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox41, "Virtue of Resolve")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox42, "Virtue of Courage")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, "Click to reset the traits")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, vbNullString)

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Virtues Recharge rate by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases Virtues Recharge rate by 1%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = True
        Mainfrm.ComboBox2.Enabled = True
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Hammer") 'Hammer - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Staff") 'Staff - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(2, "Greatsword") 'Greatsword - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(3, "Sword") 'Sword - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(4, "Scepter") 'Scepter - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(5, "Mace") 'Mace - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Hammer") 'Hammer - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Staff") 'Staff - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(2, "Greatsword") 'Greatsword - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(3, "Sword") 'Sword - One Hand #
        Mainfrm.ComboBox2.Items.Insert(4, "Scepter") 'Scepter - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(5, "Mace") 'Mace - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Shield") 'Shield - Off Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Focus") 'Focus - Off Hand #3
        Mainfrm.ComboBox3.Items.Insert(2, "Torch") 'Torch - Off Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Shield") 'Shield - Off Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Focus") 'Focus - Off Hand #4
        Mainfrm.ComboBox4.Items.Insert(2, "Torch") 'Torch - Off Hand #4

        Mainfrm.Label10.Text = "Zeal"
        Mainfrm.Label11.Text = "Radiance"
        Mainfrm.Label12.Text = "Valor"
        Mainfrm.Label13.Text = "Honor"
        Mainfrm.Label14.Text = "Virtues"
    End Sub

    Public Sub Warrior()
        Mainfrm.Label9.Text = "w"

        Mainfrm.PictureBox1.Image = My.Resources.guardian_off
        Mainfrm.PictureBox2.Image = My.Resources.warrior
        Mainfrm.PictureBox3.Image = My.Resources.engineer_off
        Mainfrm.PictureBox4.Image = My.Resources.ranger_off
        Mainfrm.PictureBox5.Image = My.Resources.thief_off
        Mainfrm.PictureBox6.Image = My.Resources.elementalist_off
        Mainfrm.PictureBox7.Image = My.Resources.mesmer_off
        Mainfrm.PictureBox8.Image = My.Resources.necromancer_off

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = False
        Mainfrm.PictureBox41.Visible = False
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox44.Image = My.Resources.Strength___Warrior
        Mainfrm.PictureBox45.Image = My.Resources.Arms___Warrior
        Mainfrm.PictureBox46.Image = My.Resources.Defense___Warrior
        Mainfrm.PictureBox47.Image = My.Resources.Tactics___Warrior
        Mainfrm.PictureBox48.Image = My.Resources.Discipline___Warrior

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Expertise
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Malice
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Compassion
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Concentration
        Mainfrm.PictureBox68.Image = My.Resources.Prowess
        Mainfrm.PictureBox67.Image = My.Resources.Brawn

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, "Click to reset the traits")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, vbNullString)

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases Burst Skill damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases Burst Skill damage by 1")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " + Mainfrm.Label27.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " + Mainfrm.Label28.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Burst Skill damage by " + Mainfrm.Label29.Text)

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " + Mainfrm.Label27.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " + Mainfrm.Label28.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Burst Skill damage by " + Mainfrm.Label29.Text)

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = True
        Mainfrm.ComboBox2.Enabled = True
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Hammer") 'Hammer - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Greatsword") 'Greatsword - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(2, "Longbow") 'Longbow - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(3, "Rifle") 'Rifle - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(4, "Axe") 'Axe - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(5, "Sword") 'Sword - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(6, "Mace") 'Mace - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Hammer") 'Hammer - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Greatsword") 'Greatsword - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(2, "Longbow") 'Longbow - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(3, "Rifle") 'Rifle - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(4, "Sword") 'Sword - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(5, "Axe") 'Axe - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(6, "Mace") 'Mace - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Sword") 'Sword - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Shield") 'Shield - Off Hand #3
        Mainfrm.ComboBox3.Items.Insert(2, "Axe") 'Axe - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(3, "Warhorn") 'Warhorn - Off Hand #3
        Mainfrm.ComboBox3.Items.Insert(4, "Mace") 'Mace - One Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Sword") 'Sword - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Shield") 'Shield - Off Hand #4
        Mainfrm.ComboBox4.Items.Insert(2, "Axe") 'Axe - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(3, "Warhorn") 'Warhorn - Off Hand #4
        Mainfrm.ComboBox4.Items.Insert(4, "Mace") 'Mace - One Hand #4

        Mainfrm.Label10.Text = "Strength"
        Mainfrm.Label11.Text = "Arms"
        Mainfrm.Label12.Text = "Defense"
        Mainfrm.Label13.Text = "Tactics"
        Mainfrm.Label14.Text = "Discipline"
    End Sub

    Public Sub Enginner()
        Mainfrm.Label9.Text = "en"

        Mainfrm.PictureBox1.Image = My.Resources.guardian_off
        Mainfrm.PictureBox2.Image = My.Resources.warrior_off
        Mainfrm.PictureBox3.Image = My.Resources.engineer
        Mainfrm.PictureBox4.Image = My.Resources.ranger_off
        Mainfrm.PictureBox5.Image = My.Resources.thief_off
        Mainfrm.PictureBox6.Image = My.Resources.elementalist_off
        Mainfrm.PictureBox7.Image = My.Resources.mesmer_off
        Mainfrm.PictureBox8.Image = My.Resources.necromancer_off

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = False
        Mainfrm.PictureBox41.Visible = False
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox44.Image = My.Resources.Explosives___Engineer
        Mainfrm.PictureBox45.Image = My.Resources.Firearms___Engineer
        Mainfrm.PictureBox46.Image = My.Resources.Inventions___Engineer
        Mainfrm.PictureBox47.Image = My.Resources.Alchemy___Engineer
        Mainfrm.PictureBox48.Image = My.Resources.Tools___Engineer

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Expertise
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Malice
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Compassion
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Concentration
        Mainfrm.PictureBox68.Image = My.Resources.Prowess
        Mainfrm.PictureBox67.Image = My.Resources.Ingenuity

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, "Click to reset the traits")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, vbNullString)

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases recharge rate of Tool Belt skills by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases recharge rate of Tool Belt skills by 1%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " + Mainfrm.Label27.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " + Mainfrm.Label28.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases recharge rate of Tool Belt skills by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = True
        Mainfrm.ComboBox2.Enabled = True
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Rifle") 'Rifle - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Pistol") 'Pistol - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Rifle") 'Rifle - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Pistol") 'Pistol - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Shield") 'Shield - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Pistol") 'Pistol - One Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Shield") 'Shield - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Pistol") 'Pistol - One Hand #4

        Mainfrm.Label10.Text = "Explosives"
        Mainfrm.Label11.Text = "Firearms"
        Mainfrm.Label12.Text = "Inventions"
        Mainfrm.Label13.Text = "Alchemy"
        Mainfrm.Label14.Text = "Tools"
    End Sub

    Public Sub Ranger()
        Mainfrm.Label9.Text = "r"

        Mainfrm.PictureBox1.Image = My.Resources.guardian_off
        Mainfrm.PictureBox2.Image = My.Resources.warrior_off
        Mainfrm.PictureBox3.Image = My.Resources.engineer_off
        Mainfrm.PictureBox4.Image = My.Resources.ranger
        Mainfrm.PictureBox5.Image = My.Resources.thief_off
        Mainfrm.PictureBox6.Image = My.Resources.elementalist_off
        Mainfrm.PictureBox7.Image = My.Resources.mesmer_off
        Mainfrm.PictureBox8.Image = My.Resources.necromancer_off

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = False
        Mainfrm.PictureBox41.Visible = False
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox44.Image = My.Resources.Markmanship___Ranger
        Mainfrm.PictureBox45.Image = My.Resources.Skirmishing___Ranger
        Mainfrm.PictureBox46.Image = My.Resources.Wildnerness___Ranger
        Mainfrm.PictureBox47.Image = My.Resources.Nature___Ranger
        Mainfrm.PictureBox48.Image = My.Resources.Beastmastery___Ranger

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Expertise
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Concentration
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Malice
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Concentration
        Mainfrm.PictureBox68.Image = My.Resources.Compassion
        Mainfrm.PictureBox67.Image = My.Resources.Empathy

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, "Click to reset the traits")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, vbNullString)

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases healing by 10" & vbCrLf & "Increases Pet Attributes by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases healing by 10" & vbCrLf & "Decreases Pet Attributes by 1%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " + Mainfrm.Label23.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condition damage by " + Mainfrm.Label25.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " + Mainfrm.Label27.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases healing by " + Mainfrm.Label28.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Pet Attributes by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = True
        Mainfrm.ComboBox2.Enabled = True
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Longbow") 'Longbow - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(2, "Shortbow") 'Shortbow - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(3, "Sword") 'Sword - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(4, "Axe") 'Axe - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Longbow") 'Longbow - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(2, "Shortbow") 'Shortbow - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(3, "Sword") 'Sword - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(4, "Axe") 'Axe - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Axe") 'Axe - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(3, "Torch") 'Torch - One Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Axe") 'Axe - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(3, "Torch") 'Torch - One Hand #4

        Mainfrm.Label10.Text = "Marksmanship"
        Mainfrm.Label11.Text = "Skirmishing"
        Mainfrm.Label12.Text = "Wilderness Survival"
        Mainfrm.Label13.Text = "Nature Magic"
        Mainfrm.Label14.Text = "Beastmastery"
    End Sub

    Public Sub Thief()
        Mainfrm.Label9.Text = "t"

        Mainfrm.PictureBox1.Image = My.Resources.guardian_off
        Mainfrm.PictureBox2.Image = My.Resources.warrior_off
        Mainfrm.PictureBox3.Image = My.Resources.engineer_off
        Mainfrm.PictureBox4.Image = My.Resources.ranger_off
        Mainfrm.PictureBox5.Image = My.Resources.thief
        Mainfrm.PictureBox6.Image = My.Resources.elementalist_off
        Mainfrm.PictureBox7.Image = My.Resources.mesmer_off
        Mainfrm.PictureBox8.Image = My.Resources.necromancer_off

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = False
        Mainfrm.PictureBox41.Visible = False
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox44.Image = My.Resources.Deadly___Thief
        Mainfrm.PictureBox45.Image = My.Resources.Critical___Thief
        Mainfrm.PictureBox46.Image = My.Resources.Shadow__Thief
        Mainfrm.PictureBox47.Image = My.Resources.Acrobatics___Thief
        Mainfrm.PictureBox48.Image = My.Resources.Trickery___Thief

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Expertise
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Prowess
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Compassion
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Concentration
        Mainfrm.PictureBox68.Image = My.Resources.Malice
        Mainfrm.PictureBox67.Image = My.Resources.Cunning

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, "Click to reset the traits")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, vbNullString)

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Steal recharge rate by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases Steal recharge rate by 1%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition damage by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " + Mainfrm.Label23.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " + Mainfrm.Label27.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Steal recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = True
        Mainfrm.ComboBox2.Enabled = True
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Shortbow") 'Shortbow - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Sword") 'Sword - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(2, "Dagger") 'Dagger - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(3, "Pistol") 'Pistol - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Shortbow") 'Shortbow - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Sword") 'Sword - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(2, "Dagger") 'Dagger - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(3, "Pistol") 'Pistol - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Pistol") 'Pistol - One Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Pistol") 'Pistol - One Hand #4

        Mainfrm.Label10.Text = "Deadly Arts"
        Mainfrm.Label11.Text = "Critical Strikes"
        Mainfrm.Label12.Text = "Shadow Arts"
        Mainfrm.Label13.Text = "Acrobatics"
        Mainfrm.Label14.Text = "Trickery"
    End Sub

    Public Sub Elementalist()
        Mainfrm.Label9.Text = "el"

        Mainfrm.PictureBox1.Image = My.Resources.guardian_off
        Mainfrm.PictureBox2.Image = My.Resources.warrior_off
        Mainfrm.PictureBox3.Image = My.Resources.engineer_off
        Mainfrm.PictureBox4.Image = My.Resources.ranger_off
        Mainfrm.PictureBox5.Image = My.Resources.thief_off
        Mainfrm.PictureBox6.Image = My.Resources.elementalist
        Mainfrm.PictureBox7.Image = My.Resources.mesmer_off
        Mainfrm.PictureBox8.Image = My.Resources.necromancer_off

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = True
        Mainfrm.PictureBox41.Visible = True
        Mainfrm.PictureBox42.Visible = True
        Mainfrm.PictureBox43.Visible = True
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox40.Image = My.Resources.Fire
        Mainfrm.PictureBox41.Image = My.Resources.Water
        Mainfrm.PictureBox42.Image = My.Resources.Air
        Mainfrm.PictureBox43.Image = My.Resources.Earth

        Mainfrm.PictureBox44.Image = My.Resources.Fire___Elementalist
        Mainfrm.PictureBox45.Image = My.Resources.Air___Elementalist
        Mainfrm.PictureBox46.Image = My.Resources.Earth___Elementalist
        Mainfrm.PictureBox47.Image = My.Resources.Water___Elementalist
        Mainfrm.PictureBox48.Image = My.Resources.Arcane___Elementalist

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Expertise
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Prowess
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Malice
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Compassion
        Mainfrm.PictureBox68.Image = My.Resources.Concentration
        Mainfrm.PictureBox67.Image = My.Resources.Intelligence

        Mainfrm.Label32.Visible = True
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Fire Attunement")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox41, "Water Attunement")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox42, "Air Attunement")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox43, "Earth Attunement")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, "Click to reset the traits")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, vbNullString)

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases boon duration by 1%" & vbCrLf & "Increases Attunement recharge rate by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases boon duration by 1%" & vbCrLf & "Decreases Attunement recharge rate by 1%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " + Mainfrm.Label23.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condition damage by " + Mainfrm.Label25.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases boon duration by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Attunement recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = False
        Mainfrm.ComboBox2.Enabled = False
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Staff") 'Staff - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Dagger") 'Dagger - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(2, "Scepter") 'Scepter - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Staff") 'Staff - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Dagger") 'Dagger - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(2, "Scepter") 'Scepter - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Focus") 'Focus - One Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Focus") 'Focus - One Hand #4

        Mainfrm.Label10.Text = "Fire Magic"
        Mainfrm.Label11.Text = "Air Magic"
        Mainfrm.Label12.Text = "Earth Magic"
        Mainfrm.Label13.Text = "Water Magic"
        Mainfrm.Label14.Text = "Arcane Power"
    End Sub

    Public Sub Mesmer()
        Mainfrm.Label9.Text = "m"

        Mainfrm.PictureBox1.Image = My.Resources.guardian_off
        Mainfrm.PictureBox2.Image = My.Resources.warrior_off
        Mainfrm.PictureBox3.Image = My.Resources.engineer_off
        Mainfrm.PictureBox4.Image = My.Resources.ranger_off
        Mainfrm.PictureBox5.Image = My.Resources.thief_off
        Mainfrm.PictureBox6.Image = My.Resources.elementalist_off
        Mainfrm.PictureBox7.Image = My.Resources.mesmer
        Mainfrm.PictureBox8.Image = My.Resources.necromancer_off

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = False
        Mainfrm.PictureBox41.Visible = False
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox44.Image = My.Resources.Domination___Mesmer
        Mainfrm.PictureBox45.Image = My.Resources.Dueling___Mesmer
        Mainfrm.PictureBox46.Image = My.Resources.Chaos___Mesmer
        Mainfrm.PictureBox47.Image = My.Resources.Inspiration___Mesmer
        Mainfrm.PictureBox48.Image = My.Resources.Illusions___Mesmer

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Expertise
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Prowess
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Concentration
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Compassion
        Mainfrm.PictureBox68.Image = My.Resources.Malice
        Mainfrm.PictureBox67.Image = My.Resources.Guile

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, "Click to reset the traits")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, vbNullString)

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases the recharge rate of Shatter skills by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases the recharge rate of Shatter skills by 1%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " + Mainfrm.Label23.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " + Mainfrm.Label25.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " + Mainfrm.Label27.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the recharge rate of Shutter skills by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = True
        Mainfrm.ComboBox2.Enabled = True
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Staff") 'Staff - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(2, "Sword") 'Sword - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(3, "Scepter") 'Scepter - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Greatsword") 'Greatsword - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Staff") 'Staff - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(2, "Sword") 'Sword - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(3, "Scepter") 'Scepter - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Sword") 'Sword - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Focus") 'Focus - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(2, "Pistol") 'Pistol - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(3, "Torch") 'Torch - One Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Sword") 'Sword - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Focus") 'Focus - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(2, "Pistol") 'Pistol - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(3, "Torch") 'Torch - One Hand #4

        Mainfrm.Label10.Text = "Domination"
        Mainfrm.Label11.Text = "Dueling"
        Mainfrm.Label12.Text = "Chaos"
        Mainfrm.Label13.Text = "Inspiration"
        Mainfrm.Label14.Text = "Illusions"
    End Sub

    Public Sub Necromancer()
        Mainfrm.Label9.Text = "n"

        Mainfrm.PictureBox1.Image = My.Resources.guardian_off
        Mainfrm.PictureBox2.Image = My.Resources.warrior_off
        Mainfrm.PictureBox3.Image = My.Resources.engineer_off
        Mainfrm.PictureBox4.Image = My.Resources.ranger_off
        Mainfrm.PictureBox5.Image = My.Resources.thief_off
        Mainfrm.PictureBox6.Image = My.Resources.elementalist_off
        Mainfrm.PictureBox7.Image = My.Resources.mesmer_off
        Mainfrm.PictureBox8.Image = My.Resources.necromancer

        ResetImage()

        Mainfrm.Label10.Visible = True
        Mainfrm.Label11.Visible = True
        Mainfrm.Label12.Visible = True
        Mainfrm.Label13.Visible = True
        Mainfrm.Label14.Visible = True
        Mainfrm.Label15.Visible = True
        Mainfrm.Label16.Visible = True
        Mainfrm.Label17.Visible = True
        Mainfrm.Label18.Visible = True
        Mainfrm.Label19.Visible = True
        Mainfrm.Label20.Visible = True
        Mainfrm.Label21.Visible = True
        Mainfrm.Label22.Visible = True
        Mainfrm.Label23.Visible = True
        Mainfrm.Label24.Visible = True
        Mainfrm.Label25.Visible = True
        Mainfrm.Label26.Visible = True
        Mainfrm.Label27.Visible = True
        Mainfrm.Label28.Visible = True
        Mainfrm.Label29.Visible = True

        Mainfrm.PictureBox40.Visible = True
        Mainfrm.PictureBox41.Visible = True
        Mainfrm.PictureBox42.Visible = False
        Mainfrm.PictureBox43.Visible = False
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox49.Visible = True
        Mainfrm.PictureBox50.Visible = True
        Mainfrm.PictureBox51.Visible = True
        Mainfrm.PictureBox52.Visible = True
        Mainfrm.PictureBox53.Visible = True
        Mainfrm.PictureBox54.Visible = True
        Mainfrm.PictureBox55.Visible = True
        Mainfrm.PictureBox56.Visible = True
        Mainfrm.PictureBox57.Visible = True
        Mainfrm.PictureBox58.Visible = True
        Mainfrm.PictureBox59.Visible = True
        Mainfrm.PictureBox60.Visible = True
        Mainfrm.PictureBox61.Visible = True
        Mainfrm.PictureBox62.Visible = True
        Mainfrm.PictureBox63.Visible = True
        Mainfrm.PictureBox64.Visible = True
        Mainfrm.PictureBox65.Visible = True
        Mainfrm.PictureBox66.Visible = True
        Mainfrm.PictureBox67.Visible = True
        Mainfrm.PictureBox68.Visible = True

        Mainfrm.PictureBox40.Image = My.Resources.Death_Shroud
        Mainfrm.PictureBox41.Image = My.Resources.End_Death_Shroud
        Mainfrm.PictureBox44.Image = My.Resources.Spite___Necromancer
        Mainfrm.PictureBox45.Image = My.Resources.Curses___Necromancer
        Mainfrm.PictureBox46.Image = My.Resources.Death___Necromancer
        Mainfrm.PictureBox47.Image = My.Resources.Blood___Necromancer
        Mainfrm.PictureBox48.Image = My.Resources.Soul___Necromancer

        Mainfrm.PictureBox59.Image = My.Resources.Power
        Mainfrm.PictureBox60.Image = My.Resources.Expertise
        Mainfrm.PictureBox62.Image = My.Resources.Precision
        Mainfrm.PictureBox61.Image = My.Resources.Malice
        Mainfrm.PictureBox64.Image = My.Resources.Toughness
        Mainfrm.PictureBox63.Image = My.Resources.Concentration
        Mainfrm.PictureBox66.Image = My.Resources.Vitality
        Mainfrm.PictureBox65.Image = My.Resources.Compassion
        Mainfrm.PictureBox68.Image = My.Resources.Prowess
        Mainfrm.PictureBox67.Image = My.Resources.Hunger

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox1, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox2, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox3, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox4, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox5, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox6, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox7, vbNullString)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox8, "Click to reset the traits")

        Mainfrm.Label15.Text = "0"
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"

        Mainfrm.Label32.Visible = True
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Death Shroud")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox41, "End Death Shroud")

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox53, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Increases condition damage by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox53, "Decreases toughness by 10" & vbCrLf & "Decreases boon duration by 1%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases the size of your Life Force pool by 1")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases the size of your Life Force pool by 1")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " + Mainfrm.Label25.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " + Mainfrm.Label28.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the size of your Life Force pool by " + Mainfrm.Label29.Text)

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " + Mainfrm.Label20.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " + Mainfrm.Label21.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " + Mainfrm.Label22.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition duration by " + Mainfrm.Label23.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " + Mainfrm.Label24.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " + Mainfrm.Label25.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " + Mainfrm.Label26.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " + Mainfrm.Label27.Text)
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " + Mainfrm.Label28.Text + "%")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " + Mainfrm.Label29.Text + "%")

        Mainfrm.ComboBox1.Items.Clear()
        Mainfrm.ComboBox2.Items.Clear()
        Mainfrm.ComboBox3.Items.Clear()
        Mainfrm.ComboBox4.Items.Clear()

        Mainfrm.ComboBox1.Enabled = True
        Mainfrm.ComboBox2.Enabled = True
        Mainfrm.ComboBox3.Enabled = False
        Mainfrm.ComboBox4.Enabled = False

        Mainfrm.ComboBox1.Text = "Main Hand"
        Mainfrm.ComboBox2.Text = "Main Hand"
        Mainfrm.ComboBox3.Text = "Off Hand"
        Mainfrm.ComboBox4.Text = "Off Hand"

        Mainfrm.ComboBox1.Items.Insert(0, "Staff") 'Staff - Two Hand #1
        Mainfrm.ComboBox1.Items.Insert(1, "Dagger") 'Dagger - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(2, "Axe") 'Axe - One Hand #1
        Mainfrm.ComboBox1.Items.Insert(3, "Scepter") 'Scepter - One Hand #1

        Mainfrm.ComboBox2.Items.Insert(0, "Staff") 'Staff - Two Hand #2
        Mainfrm.ComboBox2.Items.Insert(1, "Dagger") 'Dagger - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(2, "Axe") 'Axe - One Hand #2
        Mainfrm.ComboBox2.Items.Insert(3, "Scepter") 'Scepter - One Hand #2

        Mainfrm.ComboBox3.Items.Insert(0, "Dagger") 'Dagger - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(1, "Focus") 'Focus - One Hand #3
        Mainfrm.ComboBox3.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #3

        Mainfrm.ComboBox4.Items.Insert(0, "Dagger") 'Dagger - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(1, "Focus") 'Focus - One Hand #4
        Mainfrm.ComboBox4.Items.Insert(2, "Warhorn") 'Warhorn - One Hand #4

        Mainfrm.Label10.Text = "Spite"
        Mainfrm.Label11.Text = "Curses"
        Mainfrm.Label12.Text = "Death Magic"
        Mainfrm.Label13.Text = "Blood Magic"
        Mainfrm.Label14.Text = "Soul Reaping"
    End Sub
#End Region

#Region "Traits"
    Dim i, a, b, c As Integer
    Dim maxsingle As Integer = 30
    Dim minsingle As Integer = 0

    Public Sub SingleReset1()
        i = Mainfrm.Label15.Text
        a = Mainfrm.Label30.Text
        b = i + a
        Mainfrm.Label30.Text = b
        Mainfrm.Label15.Text = "0"
        Mainfrm.Label20.Text = "0"
        Mainfrm.Label21.Text = "0"
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
        End If
    End Sub

    Public Sub SingleReset2()
        i = Mainfrm.Label16.Text
        a = Mainfrm.Label30.Text
        b = i + a
        Mainfrm.Label30.Text = b
        Mainfrm.Label16.Text = "0"
        Mainfrm.Label22.Text = "0"
        Mainfrm.Label23.Text = "0"
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
        End If
    End Sub

    Public Sub SingleReset3()
        i = Mainfrm.Label17.Text
        a = Mainfrm.Label30.Text
        b = i + a
        Mainfrm.Label30.Text = b
        Mainfrm.Label17.Text = "0"
        Mainfrm.Label24.Text = "0"
        Mainfrm.Label25.Text = "0"
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases critical damage by " & Mainfrm.Label25.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " & Mainfrm.Label25.Text)
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condtion damage by " & Mainfrm.Label25.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condtion damage by " & Mainfrm.Label25.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
        End If
    End Sub

    Public Sub SingleReset4()
        i = Mainfrm.Label18.Text
        a = Mainfrm.Label30.Text
        b = i + a
        Mainfrm.Label30.Text = b
        Mainfrm.Label18.Text = "0"
        Mainfrm.Label26.Text = "0"
        Mainfrm.Label27.Text = "0"
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
        End If
    End Sub

    Public Sub SingleReset5()
        i = Mainfrm.Label19.Text
        a = Mainfrm.Label30.Text
        b = i + a
        Mainfrm.Label30.Text = b
        Mainfrm.Label19.Text = "0"
        Mainfrm.Label28.Text = "0"
        Mainfrm.Label29.Text = "0"
        If Mainfrm.Label9.Text = "g" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Virtues Recharge rate by " & Mainfrm.Label29.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " & Mainfrm.Label29.Text & "%")
        ElseIf Mainfrm.Label9.Text = "w" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Burst Skill damage by " & Mainfrm.Label29.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Burst Skill damage by " & Mainfrm.Label29.Text)
        ElseIf Mainfrm.Label9.Text = "en" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
        ElseIf Mainfrm.Label9.Text = "r" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases healing by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Pet Attributes by " & Mainfrm.Label29.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases healing by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Pet Attributes by " & Mainfrm.Label29.Text & "%")
        ElseIf Mainfrm.Label9.Text = "t" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
        ElseIf Mainfrm.Label9.Text = "el" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
        ElseIf Mainfrm.Label9.Text = "m" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
        ElseIf Mainfrm.Label9.Text = "n" Then
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
        End If
    End Sub

    Public Sub AddPnt1()
        i = Mainfrm.Label30.Text
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = maxsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        End If
    End Sub

    Public Sub AddPnt2()
        i = Mainfrm.Label30.Text
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = maxsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        End If
    End Sub

    Public Sub AddPnt3()
        i = Mainfrm.Label30.Text
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label25.Text
            c = Mainfrm.Label24.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases critical damage by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label25.Text
            c = Mainfrm.Label24.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condtion damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label25.Text
            c = Mainfrm.Label24.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condtion damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label25.Text
            c = Mainfrm.Label24.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label25.Text
            c = Mainfrm.Label24.Text
            If a = maxsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            End If
        End If
    End Sub

    Public Sub AddPnt4()
        i = Mainfrm.Label30.Text
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = maxsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        End If
    End Sub

    Public Sub AddPnt5()
        i = Mainfrm.Label30.Text
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 1
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Virtues Recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Virtues Recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 1
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases Burst Skill damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Burst Skill damage by " & Mainfrm.Label29.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Burst Skill damage by " & Mainfrm.Label29.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 1
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases recharge rate of Tool Belt skills by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 10
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases healing by 10" & vbCrLf & "Increases Pet Attributes by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases healing by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Pet Attributes by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases healing by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Pet Attributes by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 1
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Steal recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 1
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases boon duration by 1%" & vbCrLf & "Increases Attunement recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 1
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases the recharge rate of Shatter skills by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.Label30.Text > "0" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = maxsingle Then
                Mainfrm.Label19.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Max points reached")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Max points reached")
            ElseIf a <= maxsingle Then
                a += 1
                b += 1
                c += 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text -= 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases the size of your Life Force pool by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
            End If
        End If
    End Sub

    Public Sub RmvPnt1()
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
            a = Mainfrm.Label15.Text
            b = Mainfrm.Label20.Text
            c = Mainfrm.Label21.Text
            If a = minsingle Then
                Mainfrm.Label15.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label15.Text = a
                Mainfrm.Label20.Text = b
                Mainfrm.Label21.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox50, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox50, "Decreases power by 10" & vbCrLf & "Decreases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        End If
    End Sub

    Public Sub RmvPnt2()
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label22.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label22.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label22.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
            a = Mainfrm.Label16.Text
            b = Mainfrm.Label22.Text
            c = Mainfrm.Label23.Text
            If a = minsingle Then
                Mainfrm.Label16.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label22.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precisio by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label16.Text = a
                Mainfrm.Label22.Text = b
                Mainfrm.Label23.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox51, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox51, "Decreases precision by 10" & vbCrLf & "Decreases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        End If
    End Sub

    Public Sub RmvPnt3()
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases critical damage by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " & Mainfrm.Label25.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases critical damage by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
            a = Mainfrm.Label17.Text
            b = Mainfrm.Label24.Text
            c = Mainfrm.Label25.Text
            If a = minsingle Then
                Mainfrm.Label17.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label17.Text = a
                Mainfrm.Label24.Text = b
                Mainfrm.Label25.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases toughness by 10" & vbCrLf & "Decreases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            End If
        End If
    End Sub

    Public Sub RmvPnt4()
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
            a = Mainfrm.Label18.Text
            b = Mainfrm.Label26.Text
            c = Mainfrm.Label27.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label18.Text = a
                Mainfrm.Label26.Text = b
                Mainfrm.Label27.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        End If
    End Sub

    Public Sub RmvPnt5()
        If Mainfrm.Label30.Text = "0" Then
        ElseIf Mainfrm.Label9.Text = "g" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Virtues Recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Virtues Recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " & Mainfrm.Label29.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 1
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases Virtues Recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Burst skill by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Virtues Recharge rate by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 10" & vbCrLf & "Increases Burst Skill damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Burst skill damage by " & Mainfrm.Label29.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Burst Skill damage by " & Mainfrm.Label29.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases critical damage by 10" & vbCrLf & "Decreases Burst Skill damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Burst skill by " & Mainfrm.Label29.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Burst Skill damage by " & Mainfrm.Label29.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases recharge rate of Tool Belt skills by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 1
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases recharge rate of Tool Belt skills by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases recharge rate of Tool Belt skills by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases healing by 10" & vbCrLf & "Increases Pet Attributes by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases healing by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Pet Attributes by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases healing by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Pet Attributes by " & Mainfrm.Label29.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 10
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases healing by 10" & vbCrLf & "Decreases Pet Attributes by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases healing by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Pet Attributes by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases healing by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Pet Attributes skills by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases Steal recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 1
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases Steal recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Steal recharge rate by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases boon duration by 1%" & vbCrLf & "Increases Attunement recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 1
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases boon duration by 1%" & vbCrLf & "Decreases Attunement recharge rate by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases boon duration by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases Attunement recharge rate by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases condition damage by 1%" & vbCrLf & "Increases the recharge rate of Shatter skills by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
            ElseIf a >= minsingle Then
                a -= 1
                b -= 1
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases condition damage by 1%" & vbCrLf & "Decreases the recharge rate of Shatter skills by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases condition damage by " & Mainfrm.Label28.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the recharge rate of Shatter skills by " & Mainfrm.Label29.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
            a = Mainfrm.Label19.Text
            b = Mainfrm.Label28.Text
            c = Mainfrm.Label29.Text
            If a = minsingle Then
                Mainfrm.Label18.Text = a
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox58, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox58, "Increases critical damage by 1" & vbCrLf & "Increases the size of your Life Force pool by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
            ElseIf a >= minsingle Then
                a -= 1
                b -= 1
                c -= 1
                Mainfrm.Label19.Text = a
                Mainfrm.Label28.Text = b
                Mainfrm.Label29.Text = c
                Mainfrm.Label30.Text += 1
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox57, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox57, "Decreases critical damage by 1" & vbCrLf & "Decreases the size of your Life Force pool by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox68, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox67, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label28, "Increases critical damage by " & Mainfrm.Label28.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label29, "Increases the size of your Life Force pool by " & Mainfrm.Label29.Text)
            End If
        End If
    End Sub
#End Region

#Region "Main Weapon Set 1"
    Public Sub CmbBox1()
        ResetSkillInfo()
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
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Hammer" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Earthshaker
            Mainfrm.PictureBox9.Image = My.Resources.Hammer_Swing1
            Mainfrm.PictureBox30.Image = My.Resources.Hammer_Bash1
            Mainfrm.PictureBox31.Image = My.Resources.Hammer_Smash
            Mainfrm.PictureBox10.Image = My.Resources.Fierce_Blow
            Mainfrm.PictureBox11.Image = My.Resources.Hammer_Shock
            Mainfrm.PictureBox12.Image = My.Resources.Staggering_Blow
            Mainfrm.PictureBox13.Image = My.Resources.Backbreaker
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Arcing_Slice
            Mainfrm.PictureBox9.Image = My.Resources.Greatsword_Swing
            Mainfrm.PictureBox30.Image = My.Resources.Greatsword_Slice
            Mainfrm.PictureBox31.Image = My.Resources.Brutal_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Hundred_Blades
            Mainfrm.PictureBox11.Image = My.Resources.Whirlwind_Attack
            Mainfrm.PictureBox12.Image = My.Resources.Bladetrail
            Mainfrm.PictureBox13.Image = My.Resources.Rush
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Combustive_Shot
            Mainfrm.PictureBox9.Image = My.Resources.Dual_Shot_png
            Mainfrm.PictureBox10.Image = My.Resources.Fan_of_Fire_png
            Mainfrm.PictureBox11.Image = My.Resources.Arcing_Arrow_png
            Mainfrm.PictureBox12.Image = My.Resources.Smoldering_Arrow_png
            Mainfrm.PictureBox13.Image = My.Resources.Pin_Down_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Kill_Shot
            Mainfrm.PictureBox9.Image = My.Resources.Bleeding_Shot_png
            Mainfrm.PictureBox10.Image = My.Resources.Aimed_Shot_png
            Mainfrm.PictureBox11.Image = My.Resources.Volley_png
            Mainfrm.PictureBox12.Image = My.Resources.Brutal_Shot_png
            Mainfrm.PictureBox13.Image = My.Resources.Rifle_Butt_png
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
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Shortbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Surprise_Shot
            Mainfrm.PictureBox9.Image = My.Resources.Trick_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Cluster_Bomb
            Mainfrm.PictureBox36.Image = My.Resources.Detonate_Cluster
            Mainfrm.PictureBox11.Image = My.Resources.Disabling_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Choking_Gas
            Mainfrm.PictureBox13.Image = My.Resources.Concussion_Shot
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox1.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = True
            Mainfrm.PictureBox42.Visible = True
            Mainfrm.PictureBox43.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Fire
            Mainfrm.PictureBox41.Image = My.Resources.Water
            Mainfrm.PictureBox42.Image = My.Resources.Air
            Mainfrm.PictureBox43.Image = My.Resources.Earth
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox9.Image = My.Resources.Fireball
                Mainfrm.PictureBox10.Image = My.Resources.Lava_Font
                Mainfrm.PictureBox11.Image = My.Resources.Flame_Burst
                Mainfrm.PictureBox12.Image = My.Resources.Burning_Retreat
                Mainfrm.PictureBox13.Image = My.Resources.Meteor_Shower
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox9.Image = My.Resources.Water_Blast
                Mainfrm.PictureBox10.Image = My.Resources.Ice_Spike
                Mainfrm.PictureBox11.Image = My.Resources.Geyser
                Mainfrm.PictureBox12.Image = My.Resources.Frozen_Ground
                Mainfrm.PictureBox13.Image = My.Resources.Healing_Rain
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox9.Image = My.Resources.Chain_Lightning
                Mainfrm.PictureBox10.Image = My.Resources.Lightning_Surge
                Mainfrm.PictureBox11.Image = My.Resources.Gust
                Mainfrm.PictureBox12.Image = My.Resources.Windborne_Speed
                Mainfrm.PictureBox13.Image = My.Resources.Static_Field
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox9.Image = My.Resources.Stoning
                Mainfrm.PictureBox10.Image = My.Resources.Eruption
                Mainfrm.PictureBox11.Image = My.Resources.Magnetic_Aura
                Mainfrm.PictureBox12.Image = My.Resources.Unsteady_Ground
                Mainfrm.PictureBox13.Image = My.Resources.Shockwave
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Spatial_Surge
            Mainfrm.PictureBox10.Image = My.Resources.Mirror_Blade
            Mainfrm.PictureBox11.Image = My.Resources.Mind_Stab
            Mainfrm.PictureBox12.Image = My.Resources.Phantasmal_Berserker
            Mainfrm.PictureBox13.Image = My.Resources.Illusionary_Wave
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Winds_of_Chaos
            Mainfrm.PictureBox10.Image = My.Resources.Phase_Retreat
            Mainfrm.PictureBox11.Image = My.Resources.Illusionary_Warlock
            Mainfrm.PictureBox12.Image = My.Resources.Chaos_Armor
            Mainfrm.PictureBox13.Image = My.Resources.Chaos_Storm
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox1.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Necrotic_Grasp
            Mainfrm.PictureBox10.Image = My.Resources.Mark_of_Blood
            Mainfrm.PictureBox11.Image = My.Resources.Chillblains
            Mainfrm.PictureBox12.Image = My.Resources.Putrid_Mark
            Mainfrm.PictureBox13.Image = My.Resources.Reaper_s_Mark
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Flurry_png
            Mainfrm.PictureBox9.Image = My.Resources.Sever_Artery_png
            Mainfrm.PictureBox30.Image = My.Resources.Gash_png
            Mainfrm.PictureBox31.Image = My.Resources.Final_Thrust_png
            Mainfrm.PictureBox10.Image = My.Resources.Savage_Leap_png
            Mainfrm.PictureBox11.Image = My.Resources.Hamstring_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Eviscerate_png
            Mainfrm.PictureBox9.Image = My.Resources.Chop_png
            Mainfrm.PictureBox30.Image = My.Resources.Double_Chop_png
            Mainfrm.PictureBox31.Image = My.Resources.Triple_Chop_png
            Mainfrm.PictureBox10.Image = My.Resources.Cyclone_Axe_png
            Mainfrm.PictureBox11.Image = My.Resources.Throw_Axe_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Skull_Crack_png
            Mainfrm.PictureBox9.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox30.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox31.Image = My.Resources.Pulverize_png
            Mainfrm.PictureBox10.Image = My.Resources.Counter_Blow_png
            Mainfrm.PictureBox11.Image = My.Resources.Pommel_Bash_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Tactical_Strike
            Mainfrm.PictureBox9.Image = My.Resources.Slice1
            Mainfrm.PictureBox30.Image = My.Resources.Slash1
            Mainfrm.PictureBox31.Image = My.Resources.Crippling_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Infiltrator_s_Strike
            Mainfrm.PictureBox36.Image = My.Resources.Shadow_Return
            Mainfrm.PictureBox11.Image = My.Resources.Stab
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Dagger" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Backstab
            Mainfrm.PictureBox9.Image = My.Resources.Double_Strike
            Mainfrm.PictureBox30.Image = My.Resources.Wild_Strike
            Mainfrm.PictureBox31.Image = My.Resources.Lotus_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Heartseeker
            Mainfrm.PictureBox11.Image = My.Resources.Twisting_Fangs
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Sneak_Attack
            Mainfrm.PictureBox9.Image = My.Resources.Vital_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Body_Shot
            Mainfrm.PictureBox11.Image = My.Resources.Repeater
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox1.Text = "Dagger" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = True
            Mainfrm.PictureBox42.Visible = True
            Mainfrm.PictureBox43.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Fire
            Mainfrm.PictureBox41.Image = My.Resources.Water
            Mainfrm.PictureBox42.Image = My.Resources.Air
            Mainfrm.PictureBox43.Image = My.Resources.Earth
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox9.Image = My.Resources.Dragon_s_Claw
                Mainfrm.PictureBox10.Image = My.Resources.Drake_s_Breath
                Mainfrm.PictureBox11.Image = My.Resources.Burning_Speed
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox9.Image = My.Resources.Vapor_Blade
                Mainfrm.PictureBox10.Image = My.Resources.Cone_of_Cold
                Mainfrm.PictureBox11.Image = My.Resources.Frozen_Burst
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox9.Image = My.Resources.Lightning_Whip
                Mainfrm.PictureBox10.Image = My.Resources.Lightning_Touch
                Mainfrm.PictureBox11.Image = My.Resources.Shocking_Aura
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox9.Image = My.Resources.Impale
                Mainfrm.PictureBox10.Image = My.Resources.Ring_of_Earth
                Mainfrm.PictureBox11.Image = My.Resources.Magnetic_Grasp
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = True
            Mainfrm.PictureBox42.Visible = True
            Mainfrm.PictureBox43.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Fire
            Mainfrm.PictureBox41.Image = My.Resources.Water
            Mainfrm.PictureBox42.Image = My.Resources.Air
            Mainfrm.PictureBox43.Image = My.Resources.Earth
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox9.Image = My.Resources.Flamestrike
                Mainfrm.PictureBox10.Image = My.Resources.Dragon_s_Tooth
                Mainfrm.PictureBox11.Image = My.Resources.Phoenix
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox9.Image = My.Resources.Ice_Shards
                Mainfrm.PictureBox10.Image = My.Resources.Shatterstone
                Mainfrm.PictureBox11.Image = My.Resources.Water_Trident
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox9.Image = My.Resources.Arc_Lightning
                Mainfrm.PictureBox10.Image = My.Resources.Lightning_Strike
                Mainfrm.PictureBox11.Image = My.Resources.Blinding_Flash
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox36.Visible = True
                Mainfrm.PictureBox9.Image = My.Resources.Stone_Shards
                Mainfrm.PictureBox10.Image = My.Resources.Rock_Barrier
                Mainfrm.PictureBox36.Image = My.Resources.Hurl
                Mainfrm.PictureBox11.Image = My.Resources.Dust_Devil
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Mind_Slash
            Mainfrm.PictureBox30.Image = My.Resources.Mind_Gash
            Mainfrm.PictureBox31.Image = My.Resources.Mind_Stab
            Mainfrm.PictureBox10.Image = My.Resources.Blurred_Frenzy
            Mainfrm.PictureBox11.Image = My.Resources.Illusionary_Leap
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Ether_Bolt
            Mainfrm.PictureBox30.Image = My.Resources.Ether_Blast
            Mainfrm.PictureBox31.Image = My.Resources.Ether_Clone
            Mainfrm.PictureBox10.Image = My.Resources.Illusionary_Counter
            Mainfrm.PictureBox11.Image = My.Resources.Confusing_Images
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox1.Text = "Dagger" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Necrotic_Slash
            Mainfrm.PictureBox30.Image = My.Resources.Necrotic_Stab
            Mainfrm.PictureBox31.Image = My.Resources.Necrotic_Bite
            Mainfrm.PictureBox10.Image = My.Resources.Life_Siphon
            Mainfrm.PictureBox11.Image = My.Resources.Dark_Pact
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Blood_Curse
            Mainfrm.PictureBox30.Image = My.Resources.Rending_Curse
            Mainfrm.PictureBox31.Image = My.Resources.Putrid_Curse
            Mainfrm.PictureBox10.Image = My.Resources.Grasping_Dead
            Mainfrm.PictureBox11.Image = My.Resources.Feast_of_Corruption
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Rending_Claws
            Mainfrm.PictureBox10.Image = My.Resources.Ghastly_Claws
            Mainfrm.PictureBox11.Image = My.Resources.Unholy_Feast
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
        End If
    End Sub
#End Region

#Region "Main Weapon Set 2"
    Public Sub CmbBox2()
        Mainfrm.Label34.Visible = False
        Mainfrm.Label35.Visible = False
        Mainfrm.Label36.Visible = False
        Mainfrm.Label37.Visible = False
        Mainfrm.Label38.Visible = False
        Mainfrm.Label39.Visible = False
        Mainfrm.Label40.Visible = False
        Mainfrm.PictureBox19.Visible = False
        Mainfrm.PictureBox74.Visible = False
        Mainfrm.PictureBox75.Visible = False
        Mainfrm.PictureBox76.Visible = False
        Mainfrm.PictureBox77.Visible = False
        Mainfrm.PictureBox78.Visible = False
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
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = True
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Wave_of_Wrath
            Mainfrm.PictureBox28.Image = My.Resources.Orb_of_Light
            Mainfrm.PictureBox37.Image = My.Resources.Flash_of_Light
            Mainfrm.PictureBox27.Image = My.Resources.Symbol_of_Swiftness
            Mainfrm.PictureBox26.Image = My.Resources.Line_of_Warding
            Mainfrm.PictureBox25.Image = My.Resources.Martyr
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
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox2.Text = "Shortbow" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = True
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Trick_Shot
            Mainfrm.PictureBox28.Image = My.Resources.Cluster_Bomb
            Mainfrm.PictureBox37.Image = My.Resources.Detonate_Cluster
            Mainfrm.PictureBox27.Image = My.Resources.Disabling_Shot
            Mainfrm.PictureBox26.Image = My.Resources.Choking_Gas
            Mainfrm.PictureBox25.Image = My.Resources.Concussion_Shot
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox2.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = True
            Mainfrm.PictureBox42.Visible = True
            Mainfrm.PictureBox43.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Fire
            Mainfrm.PictureBox41.Image = My.Resources.Water
            Mainfrm.PictureBox42.Image = My.Resources.Air
            Mainfrm.PictureBox43.Image = My.Resources.Earth
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox29.Image = My.Resources.Fireball
                Mainfrm.PictureBox28.Image = My.Resources.Lava_Font
                Mainfrm.PictureBox27.Image = My.Resources.Flame_Burst
                Mainfrm.PictureBox26.Image = My.Resources.Burning_Retreat
                Mainfrm.PictureBox25.Image = My.Resources.Meteor_Shower
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox29.Image = My.Resources.Water_Blast
                Mainfrm.PictureBox28.Image = My.Resources.Ice_Spike
                Mainfrm.PictureBox27.Image = My.Resources.Geyser
                Mainfrm.PictureBox26.Image = My.Resources.Frozen_Ground
                Mainfrm.PictureBox25.Image = My.Resources.Healing_Rain
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox29.Image = My.Resources.Chain_Lightning
                Mainfrm.PictureBox28.Image = My.Resources.Lightning_Surge
                Mainfrm.PictureBox27.Image = My.Resources.Gust
                Mainfrm.PictureBox26.Image = My.Resources.Windborne_Speed
                Mainfrm.PictureBox25.Image = My.Resources.Static_Field
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox29.Image = My.Resources.Stoning
                Mainfrm.PictureBox28.Image = My.Resources.Eruption
                Mainfrm.PictureBox27.Image = My.Resources.Magnetic_Aura
                Mainfrm.PictureBox26.Image = My.Resources.Unsteady_Ground
                Mainfrm.PictureBox25.Image = My.Resources.Shockwave
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox2.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Spatial_Surge
            Mainfrm.PictureBox28.Image = My.Resources.Mirror_Blade
            Mainfrm.PictureBox27.Image = My.Resources.Mind_Stab
            Mainfrm.PictureBox26.Image = My.Resources.Phantasmal_Berserker
            Mainfrm.PictureBox25.Image = My.Resources.Illusionary_Wave
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox2.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Winds_of_Chaos
            Mainfrm.PictureBox28.Image = My.Resources.Phase_Retreat
            Mainfrm.PictureBox27.Image = My.Resources.Illusionary_Warlock
            Mainfrm.PictureBox26.Image = My.Resources.Chaos_Armor
            Mainfrm.PictureBox25.Image = My.Resources.Chaos_Storm
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox2.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Necrotic_Grasp
            Mainfrm.PictureBox28.Image = My.Resources.Mark_of_Blood
            Mainfrm.PictureBox27.Image = My.Resources.Chillblains
            Mainfrm.PictureBox26.Image = My.Resources.Putrid_Mark
            Mainfrm.PictureBox25.Image = My.Resources.Reaper_s_Mark
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox2.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox2.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox2.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
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
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = True
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Slice1
            Mainfrm.PictureBox32.Image = My.Resources.Slash1
            Mainfrm.PictureBox33.Image = My.Resources.Crippling_Strike
            Mainfrm.PictureBox28.Image = My.Resources.Infiltrator_s_Strike
            Mainfrm.PictureBox37.Image = My.Resources.Shadow_Return
            Mainfrm.PictureBox27.Image = My.Resources.Stab
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox2.Text = "Dagger" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Double_Strike
            Mainfrm.PictureBox32.Image = My.Resources.Wild_Strike
            Mainfrm.PictureBox33.Image = My.Resources.Lotus_Strike
            Mainfrm.PictureBox28.Image = My.Resources.Heartseeker
            Mainfrm.PictureBox27.Image = My.Resources.Twisting_Fangs
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox2.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Vital_Shot
            Mainfrm.PictureBox28.Image = My.Resources.Body_Shot
            Mainfrm.PictureBox27.Image = My.Resources.Repeater
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox2.Text = "Dagger" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = True
            Mainfrm.PictureBox42.Visible = True
            Mainfrm.PictureBox43.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Fire
            Mainfrm.PictureBox41.Image = My.Resources.Water
            Mainfrm.PictureBox42.Image = My.Resources.Air
            Mainfrm.PictureBox43.Image = My.Resources.Earth
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox9.Image = My.Resources.Dragon_s_Claw
                Mainfrm.PictureBox10.Image = My.Resources.Drake_s_Breath
                Mainfrm.PictureBox11.Image = My.Resources.Burning_Speed
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox9.Image = My.Resources.Vapor_Blade
                Mainfrm.PictureBox10.Image = My.Resources.Cone_of_Cold
                Mainfrm.PictureBox11.Image = My.Resources.Frozen_Burst
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox9.Image = My.Resources.Lightning_Whip
                Mainfrm.PictureBox10.Image = My.Resources.Lightning_Touch
                Mainfrm.PictureBox11.Image = My.Resources.Shocking_Aura
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox9.Image = My.Resources.Impale
                Mainfrm.PictureBox10.Image = My.Resources.Ring_of_Earth
                Mainfrm.PictureBox11.Image = My.Resources.Magnetic_Grasp
                Mainfrm.PictureBox12.Image = My.Resources.Unknown
                Mainfrm.PictureBox13.Image = My.Resources.Unknown
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox2.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = True
            Mainfrm.PictureBox42.Visible = True
            Mainfrm.PictureBox43.Visible = True
            Mainfrm.PictureBox40.Image = My.Resources.Fire
            Mainfrm.PictureBox41.Image = My.Resources.Water
            Mainfrm.PictureBox42.Image = My.Resources.Air
            Mainfrm.PictureBox43.Image = My.Resources.Earth
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox29.Image = My.Resources.Flamestrike
                Mainfrm.PictureBox28.Image = My.Resources.Dragon_s_Tooth
                Mainfrm.PictureBox27.Image = My.Resources.Phoenix
                Mainfrm.PictureBox26.Image = My.Resources.Unknown
                Mainfrm.PictureBox25.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox29.Image = My.Resources.Ice_Shards
                Mainfrm.PictureBox28.Image = My.Resources.Shatterstone
                Mainfrm.PictureBox27.Image = My.Resources.Water_Trident
                Mainfrm.PictureBox26.Image = My.Resources.Unknown
                Mainfrm.PictureBox25.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox29.Image = My.Resources.Arc_Lightning
                Mainfrm.PictureBox28.Image = My.Resources.Lightning_Strike
                Mainfrm.PictureBox27.Image = My.Resources.Blinding_Flash
                Mainfrm.PictureBox26.Image = My.Resources.Unknown
                Mainfrm.PictureBox25.Image = My.Resources.Unknown
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox37.Visible = True
                Mainfrm.PictureBox29.Image = My.Resources.Stone_Shards
                Mainfrm.PictureBox28.Image = My.Resources.Rock_Barrier
                Mainfrm.PictureBox36.Image = My.Resources.Hurl
                Mainfrm.PictureBox27.Image = My.Resources.Dust_Devil
                Mainfrm.PictureBox26.Image = My.Resources.Unknown
                Mainfrm.PictureBox25.Image = My.Resources.Unknown
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Mind_Slash
            Mainfrm.PictureBox32.Image = My.Resources.Mind_Gash
            Mainfrm.PictureBox33.Image = My.Resources.Mind_Stab
            Mainfrm.PictureBox28.Image = My.Resources.Blurred_Frenzy
            Mainfrm.PictureBox27.Image = My.Resources.Illusionary_Leap
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox2.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Ether_Bolt
            Mainfrm.PictureBox32.Image = My.Resources.Ether_Blast
            Mainfrm.PictureBox33.Image = My.Resources.Ether_Clone
            Mainfrm.PictureBox28.Image = My.Resources.Illusionary_Counter
            Mainfrm.PictureBox27.Image = My.Resources.Confusing_Images
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox2.Text = "Dagger" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Necrotic_Slash
            Mainfrm.PictureBox32.Image = My.Resources.Necrotic_Stab
            Mainfrm.PictureBox33.Image = My.Resources.Necrotic_Bite
            Mainfrm.PictureBox28.Image = My.Resources.Life_Siphon
            Mainfrm.PictureBox27.Image = My.Resources.Dark_Pact
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox2.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox19.Image = My.Resources.Blood_Curse
            Mainfrm.PictureBox32.Image = My.Resources.Rending_Curse
            Mainfrm.PictureBox33.Image = My.Resources.Putrid_Curse
            Mainfrm.PictureBox28.Image = My.Resources.Grasping_Dead
            Mainfrm.PictureBox27.Image = My.Resources.Feast_of_Corruption
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        ElseIf Mainfrm.Label9.Text = "n" And Mainfrm.ComboBox2.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Rending_Claws
            Mainfrm.PictureBox28.Image = My.Resources.Ghastly_Claws
            Mainfrm.PictureBox27.Image = My.Resources.Unholy_Feast
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
        End If
    End Sub
#End Region

#Region "Off Hand Set 1"
    Public Sub CmbBox3()
        ResetSkillInfo()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Shield_of_Judgment_png
            Mainfrm.PictureBox13.Image = My.Resources.Shield_of_Absorption_png
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Focus" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Ray_of_Judgment
            Mainfrm.PictureBox13.Image = My.Resources.Shield_of_Wrath
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Torch" Then
            Mainfrm.PictureBox34.Visible = True
            Mainfrm.PictureBox12.Image = My.Resources.Cleansing_Flame_png
            Mainfrm.PictureBox13.Image = My.Resources.Zealot_s_Flame_png
            Mainfrm.PictureBox34.Image = My.Resources.Zealot_s_Fire
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Sword" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Impale_png
            Mainfrm.PictureBox13.Image = My.Resources.Riposte_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Shield_Bash_png
            Mainfrm.PictureBox13.Image = My.Resources.Shield_Stance_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Axe" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Dual_Strike_png
            Mainfrm.PictureBox13.Image = My.Resources.Whirling_Axe_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Warhorn" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Charge_png
            Mainfrm.PictureBox13.Image = My.Resources.Call_to_Arms_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Mace" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Crushing_Blow
            Mainfrm.PictureBox13.Image = My.Resources.Tremor_png
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox3.Text = "Pistol" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Blowtorch
            Mainfrm.PictureBox13.Image = My.Resources.Glue_Shot
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Magnetic_Field
            Mainfrm.PictureBox13.Image = My.Resources.Static_Shield
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Dagger" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Stalker_s_Strike
            Mainfrm.PictureBox13.Image = My.Resources.Crippling_Talon
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Axe" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Path_of_Scars
            Mainfrm.PictureBox13.Image = My.Resources.Whirling_Defense
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Warhorn" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Hunter_s_Call
            Mainfrm.PictureBox13.Image = My.Resources.Call_of_the_Wild
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Torch" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Throw_Torch
            Mainfrm.PictureBox13.Image = My.Resources.Bonfire
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox3.Text = "Dagger" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Dancing_Dagger
            Mainfrm.PictureBox13.Image = My.Resources.Cloak_and_Dagger
            If Mainfrm.ComboBox1.Text = "Sword" Then
                Mainfrm.PictureBox11.Image = My.Resources.Flanking_Strike
            ElseIf Mainfrm.ComboBox1.Text = "Dagger" Then
                Mainfrm.PictureBox11.Image = My.Resources.Death_Blossom
            ElseIf Mainfrm.ComboBox1.Text = "Pistol" Then
                Mainfrm.PictureBox11.Image = My.Resources.Shadow_Strike
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox3.Text = "Pistol" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Head_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Black_Powder
            If Mainfrm.ComboBox1.Text = "Sword" Then
                Mainfrm.PictureBox11.Image = My.Resources.Pistol_Whip
            ElseIf Mainfrm.ComboBox1.Text = "Dagger" Then
                Mainfrm.PictureBox11.Image = My.Resources.Shadow_Shot
            ElseIf Mainfrm.ComboBox1.Text = "Pistol" Then
                Mainfrm.PictureBox11.Image = My.Resources.Unload
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox3.Text = "Dagger" Then
            Mainfrm.PictureBox34.Visible = False
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox12.Image = My.Resources.Ring_of_Fire
                Mainfrm.PictureBox13.Image = My.Resources.Fire_Grab
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox12.Image = My.Resources.Frost_Aura
                Mainfrm.PictureBox13.Image = My.Resources.Cleansing_Wave
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox12.Image = My.Resources.Ride_the_Lightning
                Mainfrm.PictureBox13.Image = My.Resources.Updraft
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox12.Image = My.Resources.Earthquake
                Mainfrm.PictureBox13.Image = My.Resources.Churning_Earth
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox3.Text = "Focus" Then
            Mainfrm.PictureBox34.Visible = False
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox12.Image = My.Resources.Flamewall
                Mainfrm.PictureBox13.Image = My.Resources.Fire_Shield
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox12.Image = My.Resources.Freezing_Gust
                Mainfrm.PictureBox13.Image = My.Resources.Comet
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox12.Image = My.Resources.Swirling_Winds
                Mainfrm.PictureBox13.Image = My.Resources.Gale
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox12.Image = My.Resources.Magnetic_Wave
                Mainfrm.PictureBox13.Image = My.Resources.Obsidian_Flesh
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox3.Text = "Sword" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Illusionary_Riposte
            Mainfrm.PictureBox13.Image = My.Resources.Illusionary_Swordsman
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox3.Text = "Pistol" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Illusionary_Duelist
            Mainfrm.PictureBox13.Image = My.Resources.Trick_Shot1
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox3.Text = "Focus" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Temporal_Curtain
            Mainfrm.PictureBox13.Image = My.Resources.Illusionary_Warden
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox3.Text = "Torch" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.The_Prestige
            Mainfrm.PictureBox13.Image = My.Resources.Illusionary_Mage
        End If
    End Sub
#End Region

#Region "Off Hand Set 2"
    Public Sub CmbBox4()
        ResetSkillInfo()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Shield_of_Judgment_png
            Mainfrm.PictureBox25.Image = My.Resources.Shield_of_Absorption_png
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Focus" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Ray_of_Judgment
            Mainfrm.PictureBox25.Image = My.Resources.Shield_of_Wrath
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Torch" Then
            Mainfrm.PictureBox35.Visible = True
            Mainfrm.PictureBox26.Image = My.Resources.Cleansing_Flame_png
            Mainfrm.PictureBox25.Image = My.Resources.Zealot_s_Flame_png
            Mainfrm.PictureBox35.Image = My.Resources.Zealot_s_Fire
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Sword" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Impale_png
            Mainfrm.PictureBox25.Image = My.Resources.Riposte_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Shield_Bash_png
            Mainfrm.PictureBox25.Image = My.Resources.Shield_Stance_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Axe" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Dual_Strike_png
            Mainfrm.PictureBox25.Image = My.Resources.Whirling_Axe_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Warhorn" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Charge_png
            Mainfrm.PictureBox25.Image = My.Resources.Call_to_Arms_png
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Mace" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Crushing_Blow
            Mainfrm.PictureBox25.Image = My.Resources.Tremor_png
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox4.Text = "Pistol" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Blowtorch
            Mainfrm.PictureBox25.Image = My.Resources.Glue_Shot
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Magnetic_Field
            Mainfrm.PictureBox25.Image = My.Resources.Static_Shield
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Dagger" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Stalker_s_Strike
            Mainfrm.PictureBox25.Image = My.Resources.Crippling_Talon
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Axe" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Path_of_Scars
            Mainfrm.PictureBox25.Image = My.Resources.Whirling_Defense
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Warhorn" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Hunter_s_Call
            Mainfrm.PictureBox25.Image = My.Resources.Call_of_the_Wild
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Torch" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Throw_Torch
            Mainfrm.PictureBox25.Image = My.Resources.Bonfire
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox4.Text = "Dagger" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Dancing_Dagger
            Mainfrm.PictureBox25.Image = My.Resources.Cloak_and_Dagger
            If Mainfrm.ComboBox2.Text = "Sword" Then
                Mainfrm.PictureBox27.Image = My.Resources.Flanking_Strike
            ElseIf Mainfrm.ComboBox2.Text = "Dagger" Then
                Mainfrm.PictureBox27.Image = My.Resources.Death_Blossom
            ElseIf Mainfrm.ComboBox2.Text = "Pistol" Then
                Mainfrm.PictureBox27.Image = My.Resources.Shadow_Strike
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox4.Text = "Pistol" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Black_Powder
            Mainfrm.PictureBox25.Image = My.Resources.Head_Shot
            If Mainfrm.ComboBox2.Text = "Sword" Then
                Mainfrm.PictureBox27.Image = My.Resources.Pistol_Whip
            ElseIf Mainfrm.ComboBox2.Text = "Dagger" Then
                Mainfrm.PictureBox27.Image = My.Resources.Shadow_Shot
            ElseIf Mainfrm.ComboBox2.Text = "Pistol" Then
                Mainfrm.PictureBox27.Image = My.Resources.Unload
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox4.Text = "Dagger" Then
            Mainfrm.PictureBox35.Visible = False
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox26.Image = My.Resources.Ring_of_Fire
                Mainfrm.PictureBox25.Image = My.Resources.Fire_Grab
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox26.Image = My.Resources.Frost_Aura
                Mainfrm.PictureBox25.Image = My.Resources.Cleansing_Wave
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox26.Image = My.Resources.Ride_the_Lightning
                Mainfrm.PictureBox25.Image = My.Resources.Updraft
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox26.Image = My.Resources.Earthquake
                Mainfrm.PictureBox25.Image = My.Resources.Churning_Earth
            End If
        ElseIf Mainfrm.Label9.Text = "el" And Mainfrm.ComboBox4.Text = "Focus" Then
            Mainfrm.PictureBox35.Visible = False
            If Mainfrm.Label41.Text = "f" Then
                Mainfrm.PictureBox26.Image = My.Resources.Flamewall
                Mainfrm.PictureBox25.Image = My.Resources.Fire_Shield
            ElseIf Mainfrm.Label41.Text = "w" Then
                Mainfrm.PictureBox26.Image = My.Resources.Freezing_Gust
                Mainfrm.PictureBox25.Image = My.Resources.Comet
            ElseIf Mainfrm.Label41.Text = "a" Then
                Mainfrm.PictureBox26.Image = My.Resources.Swirling_Winds
                Mainfrm.PictureBox25.Image = My.Resources.Gale
            ElseIf Mainfrm.Label41.Text = "e" Then
                Mainfrm.PictureBox26.Image = My.Resources.Magnetic_Wave
                Mainfrm.PictureBox25.Image = My.Resources.Obsidian_Flesh
            End If
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox4.Text = "Sword" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Illusionary_Riposte
            Mainfrm.PictureBox25.Image = My.Resources.Illusionary_Swordsman
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox4.Text = "Pistol" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Illusionary_Duelist
            Mainfrm.PictureBox25.Image = My.Resources.Trick_Shot1
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox4.Text = "Focus" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Temporal_Curtain
            Mainfrm.PictureBox25.Image = My.Resources.Illusionary_Warden
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox4.Text = "Torch" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.The_Prestige
            Mainfrm.PictureBox25.Image = My.Resources.Illusionary_Mage
        End If
    End Sub
#End Region

#Region "Heal Skills"
    Public Sub Heal()
        ResetSkillInfo()
        If Mainfrm.Label9.Text = "Label9" Then
        ElseIf Mainfrm.Label9.Text = "g" Then
            Selectfrm.PictureBox1.Image = My.Resources.Shelter
            Selectfrm.PictureBox2.Image = My.Resources.Signet_of_Resolve
            Selectfrm.PictureBox3.Image = My.Resources.Healing_Breeze
            Selectfrm.ShowDialog()
        ElseIf Mainfrm.Label9.Text = "w" Then
            Selectfrm.PictureBox1.Image = My.Resources.Healing_Surge
            Selectfrm.PictureBox2.Image = My.Resources.Mending
            Selectfrm.PictureBox3.Image = My.Resources.Healing_Signet
            Selectfrm.ShowDialog()
        ElseIf Mainfrm.Label9.Text = "en" Then
            Selectfrm.PictureBox1.Image = My.Resources.Elixir_H
            Selectfrm.PictureBox2.Image = My.Resources.Med_Kit
            Selectfrm.PictureBox3.Image = My.Resources.Healing_Turret
            Selectfrm.ShowDialog()
        ElseIf Mainfrm.Label9.Text = "r" Then
            Selectfrm.PictureBox1.Image = My.Resources.Elixir_H
            Selectfrm.PictureBox2.Image = My.Resources.Med_Kit
            Selectfrm.PictureBox3.Image = My.Resources.Healing_Turret
            Selectfrm.ShowDialog()
        ElseIf Mainfrm.Label9.Text = "t" Then
            Selectfrm.PictureBox1.Image = My.Resources.Hide_in_Shadows
            Selectfrm.PictureBox2.Image = My.Resources.Withdraw
            Selectfrm.PictureBox3.Image = My.Resources.Signet_of_Malice
            Selectfrm.ShowDialog()
        ElseIf Mainfrm.Label9.Text = "el" Then
            Selectfrm.PictureBox1.Image = My.Resources.Glyph_of_Elemental_Harmony
            Selectfrm.PictureBox2.Image = My.Resources.Ether_Renewal
            Selectfrm.PictureBox3.Image = My.Resources.Signet_of_Restoration
            Selectfrm.ShowDialog()
        ElseIf Mainfrm.Label9.Text = "m" Then
            Selectfrm.PictureBox1.Image = My.Resources.Ether_Feast
            Selectfrm.PictureBox2.Image = My.Resources.Mirror
            Selectfrm.PictureBox3.Image = My.Resources.Mantra_of_Recovery
            Selectfrm.ShowDialog()
        ElseIf Mainfrm.Label9.Text = "n" Then
            Selectfrm.PictureBox1.Image = My.Resources.Summon_Blood_Fiend
            Selectfrm.PictureBox2.Image = My.Resources.Consume_Conditions
            Selectfrm.PictureBox3.Image = My.Resources.Well_of_Blood
            Selectfrm.ShowDialog()
        End If
    End Sub
#End Region
End Class
