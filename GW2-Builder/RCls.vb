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
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox19, "Click to swap weapon set")
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

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox14, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox15, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox16, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox17, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox18, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox20, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox21, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox22, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox23, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox24, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox41, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox42, vbNullString)
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox43, vbNullString)

        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
        Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)

        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox1, "Guardian")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox2, "Warrior")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox3, "Engineer")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox4, "Ranger")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox5, "Thief")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox6, "Elementalist")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox7, "Mesmer")
        Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox8, "Necromancer")

        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a one hand or a two hand weapon first")
        Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a one hand or a two hand weapon first")
    End Sub

    Public Sub LblClick()
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

#Region "Traits"
    Dim maxoverall As Integer = 70
    Dim maxsingle As Integer = 30
    Dim minsingle As Integer = 0

    Public Sub AddPnt1()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox49, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox49, "Increases power by 10" & vbCrLf & "Increases condition duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox59, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox60, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label20, "Increases power by " & Mainfrm.Label20.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label21, "Increases condition duration by " & Mainfrm.Label21.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
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
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases condition damage by " & Mainfrm.Label23.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox52, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox52, "Increases precision by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox62, "Increases precision by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox61, "Increases critical damage by " & Mainfrm.Label23.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label22, "Increases precision by " & Mainfrm.Label22.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label23, "Increases critical damage by " & Mainfrm.Label23.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
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
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases critical damage by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases critical damage by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases critical damage by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condtion damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases healing by " & Mainfrm.Label25.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases healing by " & Mainfrm.Label25.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases condition damage by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases condtion damage by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases condition damage by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox54, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox54, "Increases toughness by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox64, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox63, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label24, "Increases toughness by " & Mainfrm.Label24.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label25, "Increases boon duration by " & Mainfrm.Label25.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
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
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "w" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "en" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "r" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "t" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases boon duration by 1%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases boon duration by " & Mainfrm.Label27.Text & "%")
            End If
        ElseIf Mainfrm.Label9.Text = "el" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "m" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        ElseIf Mainfrm.Label9.Text = "n" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox56, "Add Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox56, "Increases vitality by 10" & vbCrLf & "Increases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
        End If
    End Sub

    Public Sub RmvPnt1()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer

        If Mainfrm.Label9.Text = "g" Then
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
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox55, "Remove Point")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox55, "Decreases vitality by 10" & vbCrLf & "Decreases healing by 1")
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox66, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox65, "Increases healing by " & Mainfrm.Label27.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label26, "Increases vitality by " & Mainfrm.Label26.Text)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.Label27, "Increases healing by " & Mainfrm.Label27.Text)
            End If
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
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Hammer_Swing
            Mainfrm.PictureBox30.Image = My.Resources.Hammer_Bash
            Mainfrm.PictureBox31.Image = My.Resources.Symbol_of_Protection
            Mainfrm.PictureBox10.Image = My.Resources.Mighty_Blow
            Mainfrm.PictureBox11.Image = My.Resources.Zealot_s_Embrace
            Mainfrm.PictureBox12.Image = My.Resources.Banish
            Mainfrm.PictureBox13.Image = My.Resources.Ring_of_Warding
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Hammer Swing")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Hammer Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Symbol of Protection")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Mighty Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Zealot's Embrace")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Banish")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Ring of Warding")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Strike your foe." & vbCrLf & "Damage: 368" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Symbol of Protection")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe." & vbCrLf & "Damage: 413" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Create a symbol that gives Protection to you and your allies." _
                                & vbCrLf & "Damage: 920" & vbCrLf & "Protection(1s): 33% damage reduction" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Damage nearby foes with a mighty ground slam." & vbCrLf & "Damage: 551" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Send a wave toward your foe that immobilizes enemies in a line." _
                                & vbCrLf & "Damage: 368" & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Launch your foe with a powerful smash." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Launch: 900" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Create a ring around you that foes cannot cross. Trapped enemies cannot exit the ring while it is active." _
                                & vbCrLf & "Duration: 5 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Wave_of_Wrath
            Mainfrm.PictureBox10.Image = My.Resources.Orb_of_Light
            Mainfrm.PictureBox36.Image = My.Resources.Flash_of_Light
            Mainfrm.PictureBox11.Image = My.Resources.Symbol_of_Swiftness
            Mainfrm.PictureBox12.Image = My.Resources.Line_of_Warding
            Mainfrm.PictureBox13.Image = My.Resources.Martyr
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Wave of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Orb of Light")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox36, "Flash of Light")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Symbol of Swiftness")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Line of Warding")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Martyr")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox36, Mainfrm.PictureBox36.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Send out a powerful shockwave, hitting up to five enemies." _
                                & vbCrLf & "Damage: 276" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Chain. Fire a slow-moving orb of light that can be detonated to Heal allies." _
                                & vbCrLf & "Damage: 551" & vbCrLf & "Healing: 1372" & vbCrLf & "Detonate Damage: 276" & vbCrLf & "Range: 1200" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Orb of Light > Flash of Light")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox36, "Chain. Detonate the orb to Heal nearby allies. Recharge on Orb of Light is set to 4 times" _
                                        & "it's basic recharge." & vbCrLf & "Damage: 276" & vbCrLf & "Healing: 803" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Sear a mystic symbol into the target area, damaging foes and granting Swiftness to allies." _
                                & vbCrLf & "Damage: 230" & vbCrLf & "Swiftness(2s): +33% movement speed" _
                                & vbCrLf & "Symbol radius: 180" & vbCrLf & "Symbol duration: 4 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Create a line in front of you that foes cannot cross." & vbCrLf & "Duration: 5 seconds")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Draw conditions from nearby allies to yourself. Gain multiple boons for a short duration." _
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
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Strike
            Mainfrm.PictureBox30.Image = My.Resources.Vengeful_Strike
            Mainfrm.PictureBox31.Image = My.Resources.Wrathful_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Symbol_of_Wrath
            Mainfrm.PictureBox11.Image = My.Resources.Whirling_Wrath
            Mainfrm.PictureBox12.Image = My.Resources.Leap_of_Faith
            Mainfrm.PictureBox13.Image = My.Resources.Binding_Blade
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Vengeful Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Wrathful Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Symbol of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Whirling Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Leap of Faith")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Binding Blade")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Strike your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Strike > Vengeful Strike > Wrathful Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Strike your foe again." & vbCrLf & "Damage: 376" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Attack your foe with a wrathful strike." _
                                & vbCrLf & "Damage: 459" & vbCrLf & "Might(3s): +5-35 Power" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Pierce the ground with a mystic symbol that damages and Burns foes while " _
                                & "granting Retaliation to allies." & vbCrLf & "Damage: 230" & vbCrLf _
                                & "Retaliation(2s): Reflect incoming damage back to it's source" & vbCrLf & "Combo Field: Light")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Spin in place and swing your greatword while hurling powerful projectiles." _
                                & vbCrLf & "Damage: 1413" & vbCrLf & "Projectile Damage: 1412" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Leap at your foe. On hit, blind nearby foes." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Throw blades at your foes, causing damage over time. Bounds foe can be " _
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
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Earthshaker
            Mainfrm.PictureBox9.Image = My.Resources.Hammer_Swing1
            Mainfrm.PictureBox30.Image = My.Resources.Hammer_Bash1
            Mainfrm.PictureBox31.Image = My.Resources.Hammer_Smash
            Mainfrm.PictureBox10.Image = My.Resources.Fierce_Blow
            Mainfrm.PictureBox11.Image = My.Resources.Hammer_Shock
            Mainfrm.PictureBox12.Image = My.Resources.Staggering_Blow
            Mainfrm.PictureBox13.Image = My.Resources.Backbreaker
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Earthshaker")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Hammer Swing")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Hammer Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Hammer Smash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Fierce Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Hammer Shock")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Staggering Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Backbreaker")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Burst. Jump to the targeted location and slam your hammer down, damaging ans Stunning foes." _
                                & vbCrLf & "Damage: 244" & vbCrLf & "Level 1 Stun: 1 second" & vbCrLf & "Level 2 Stun: 1,5 second" _
                                & vbCrLf & "Level 3 Stun: 2 seconds" & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Bash your foe." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Hammer Blow")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe again." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Smash the ground and damage nearby foes." _
                                & vbCrLf & "Damage: 821" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Weaken your foe with a fierce blow." & vbCrLf & "Damage: 645" & vbCrLf _
                                & "Weakness(8s): -50% Endurance Regeneration, 50% Fumble" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Smash the ground and send out a Crippling wave." _
                                & vbCrLf & "Damage: 410" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Push back nearby foes with a stuggering blow." & vbCrLf & "Damage: 703" & vbCrLf _
                                & "Knockback: 180" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Knock down your target foe." & vbCrLf & "Damage: 879" _
                                & vbCrLf & "Knockdown: 2 seconds" & vbCrLf & "Range: 130")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Arcing_Slice
            Mainfrm.PictureBox9.Image = My.Resources.Greatsword_Swing
            Mainfrm.PictureBox30.Image = My.Resources.Greatsword_Slice
            Mainfrm.PictureBox31.Image = My.Resources.Brutal_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Hundred_Blades
            Mainfrm.PictureBox11.Image = My.Resources.Whirlwind_Attack
            Mainfrm.PictureBox12.Image = My.Resources.Bladetrail
            Mainfrm.PictureBox13.Image = My.Resources.Rush
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Arcing Slice")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Greatsword Swing")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Greatsword Slice")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Brutal Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Hundred Blades")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Whirlwind Attack")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Bladetrail")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Rush")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Strike your foe with an uppercut that grants Might." & vbCrLf & "Damage: 816" _
                                & vbCrLf & "Level 1 Sdrenaline(15s): +5-35 Power" & vbCrLf & "Level 2 Sdrenaline(15s): +5-35 Power" _
                                & vbCrLf & "Level 3 Sdrenaline(15s): +5-35 Power" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Greatsword Swing > Greatosword Slice > Brutal Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Slice your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Hit your foes with a final brutal strike." & vbCrLf & "Damage: 480" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Repeatedly strike multiple foes. The last stike does extra damage." & vbCrLf & "Damage: 2756" & vbCrLf _
                                & "Final Strike Damage: 644" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Whirl in a target's direction, slashing foes along your path." _
                                & vbCrLf & "Damage: 373" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Throw your greatsword at your foe. It travels to your target and returns to you." _
                                & "Cripplings foes along your path." & vbCrLf & "Damage: 469" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Charge your foe." & vbCrLf & "Damage: 146" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Longbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Combustive_Shot
            Mainfrm.PictureBox9.Image = My.Resources.Dual_Shot_png
            Mainfrm.PictureBox10.Image = My.Resources.Fan_of_Fire_png
            Mainfrm.PictureBox11.Image = My.Resources.Arcing_Arrow_png
            Mainfrm.PictureBox12.Image = My.Resources.Smoldering_Arrow_png
            Mainfrm.PictureBox13.Image = My.Resources.Pin_Down_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Combustive Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Dual Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Fan of Fire")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Arcing Arrow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Smoldering Arrow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Pin Down")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Ignite target area, Burning nearby foes. Effect increases with adrenaline level." _
                                & vbCrLf & "Burning(2s): -690 health" & vbCrLf & "Duration: 4 seconds" & vbCrLf & "Area of Effect: Circle 240 feet" _
                                & vbCrLf & "Combo Field: Fire" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Shot a pair of arrows at your foe." & vbCrLf & "Damage: 284" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Fire a spread of three flaming arrows, Burning foes." & vbCrLf & "Damage: 168" _
                                & vbCrLf & "Burning(2s): -690 health" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Shot a slow, arcing arrow that explodes on impact." & vbCrLf & "Damage: 814" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Shot an arrow that explodes on impact. Blinding foes." _
                                & vbCrLf & "Damage: 112" & vbCrLf & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Fire an arrow that Immobilizes the target." & vbCrLf & "Damage: 234" _
                                & vbCrLf & "Immobilize(3s): Unable to move" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Kill_Shot
            Mainfrm.PictureBox9.Image = My.Resources.Bleeding_Shot_png
            Mainfrm.PictureBox10.Image = My.Resources.Aimed_Shot_png
            Mainfrm.PictureBox11.Image = My.Resources.Volley_png
            Mainfrm.PictureBox12.Image = My.Resources.Brutal_Shot_png
            Mainfrm.PictureBox13.Image = My.Resources.Rifle_Butt_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Kill Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Bleeding Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Aimed Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Volley")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Brutal Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Rifle Butt")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Fire a powerful shot. Damage increases with adrenaline level." & vbCrLf & "Level 1 Damage: 698" _
                    & vbCrLf & "Level 2 Damage: 997" & vbCrLf & "Level 3 Damage: 1256" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 5000")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Fire a shot that Bleeds your target." & vbCrLf & "Damage: 213" _
                                & vbCrLf & "Bleeding(6s): -270 damage over time" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Fire a precise shot that Cripples your foe." & vbCrLf & "Damage: 186" _
                                & vbCrLf & "Cripple(5s): -50% Speed" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Fire a volley of shots at your foe." & vbCrLf & "Damage: 376" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Shot your foes and make them Vulnerable." _
                                & vbCrLf & "Damage: 306" & vbCrLf & "Vulnerability(10s): -30 defence" & vbCrLf & "Combo Finisher: Physical Projectile" _
                                & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Push your foe back with your rifle butt." & vbCrLf & "Damage: 568" _
                                & vbCrLf & "Knockback: 450" & vbCrLf & "Range: 130")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Rifle" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Hip_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Net_Shot
            Mainfrm.PictureBox11.Image = My.Resources.Blunderbuss
            Mainfrm.PictureBox12.Image = My.Resources.Overcharged_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Jump_Shot
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Hip Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Net Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Blunderbuss")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Overcharged Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Jump Shot")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Deliver a quick rifle shot from the hip." & vbCrLf & "Damage: 155" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Immobilizie foes with a net shot." & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Fire a cloud of sharpnel that causes more damage the closer you are to foes." _
                                & vbCrLf & "Within 8 fett: 621" & vbCrLf & "Within 16 feet: 563" & vbCrLf & "Within 24 feet: 466" _
                                & vbCrLf & "Within 32 feet: 388" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Fire a blast so strong it Launches your foe as you fall backward." _
                                & vbCrLf & "Damage: 388" & vbCrLf & "Enemy launch distance: 450" & vbCrLf & "Self knockback distance: 350" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Blast the ground, damaging nearby foes and leaping to your target." _
                                & vbCrLf & "Leap Damage: 466" & vbCrLf & "Landing Damage: 456" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 700")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = True
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Slash
            Mainfrm.PictureBox30.Image = My.Resources.Slice
            Mainfrm.PictureBox31.Image = My.Resources.Power_Stab
            Mainfrm.PictureBox10.Image = My.Resources.Maul
            Mainfrm.PictureBox11.Image = My.Resources.Swoop
            Mainfrm.PictureBox12.Image = My.Resources.Counterattack
            Mainfrm.PictureBox38.Image = My.Resources.Crippling_Throw
            Mainfrm.PictureBox13.Image = My.Resources.Hilt_Bash
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Slash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Slice")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Power Stab")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Maul")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Swoop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Counterattack")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox38, "Crippling Throw")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Hilt Bash")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox38, Mainfrm.PictureBox38.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Slice > Power Stab")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Slice your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Stab your foe and Evade attacks." & vbCrLf & "Damage: 671" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Bleed your foe four times with a mauling strike." & vbCrLf & "Damage: 280" & vbCrLf _
                                & "Bleeding(4s): -1546 damage over time" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Run and leap at your foe, hitting them and nearby foes." _
                                & vbCrLf & "Damage: 783" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 770")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Chain. Block and counter an attack with a kick that pushes foes back." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Counterattack > Crippling Throw")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox38, "Chain. Throw your Greatsword, Crippling your foe." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Daze your foe with a hilt bash. Stun them if you hit from behind. Your pet's" _
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
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Long_Range_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Rapid_Fire
            Mainfrm.PictureBox11.Image = My.Resources.Hunter_s_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Point_Blank_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Barrage
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Long Range Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Rapid Fire")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Hunter's Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Point Blank Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Barrage")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Shot your foe with a long range arrow. The farther the arrows flies, the more damage it does." _
                                & vbCrLf & "1000+ Range: 509" & vbCrLf & "500-1000 Range: 382" & vbCrLf & "0-500 Range: 254" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Fire multiple arrows at your foe." & vbCrLf & "Damage: 2040" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20& chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Fire an arrow to make your foe Vulnerability. Your pet gains Swiftness." & vbCrLf & "Damage: 267" _
                                & vbCrLf & "Vulnerability(10s): -30 defense" & vbCrLf & "Pet Swiftness(10s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Push back your foe with a point-blank shot. The closer they are, the farther it knocks back." _
                                & vbCrLf & "Damage: 539" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Barrage the target area with a hail of arrows that Cripple." & vbCrLf & "Damage: 1836" _
                                & vbCrLf & "Cripple(3s): -50% Speed" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Shortbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Cross_Fire
            Mainfrm.PictureBox10.Image = My.Resources.Poison_Volley
            Mainfrm.PictureBox11.Image = My.Resources.Quick_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Crippling_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Concussion_Shot
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Cross Fire")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Poison Volley")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Quick Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Crippling Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Concussion Shot")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Fire an arrow that bleeds your target if it hits your foe from behind or the side." _
                                & vbCrLf & "Damage: 204" & vbCrLf & "Bleeding(3s): -144 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Fire a spread of 5 poison arrows." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Poison(2s): -194 health, -33% reduce healing" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Fire a quick shot in an Evasive retreat. Gain Swiftness if the shot hits." _
                                & "This can be used while retreating." & vbCrLf & "Damage: 178" & vbCrLf & "Swiftness(3s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Shatter your foe's dreams of becoming an adventurer with a single arrow to the knee." _
                                & "Your pet's next three attacks inflict Bleeding." & vbCrLf & "Damage: 178" & vbCrLf & "Cripple(3s): -50% Speed" _
                                & vbCrLf & "Bleeding(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Daze your foe with an arrow. Stun them if you hit from behind or from the side." & vbCrLf & "Damage: 178" _
                                & vbCrLf & "Daze: 1 second" & vbCrLf & "Stun: 1 second" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Shortbow" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Surprise_Shot
            Mainfrm.PictureBox9.Image = My.Resources.Trick_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Cluster_Bomb
            Mainfrm.PictureBox36.Image = My.Resources.Detonate_Cluster
            Mainfrm.PictureBox11.Image = My.Resources.Disabling_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Choking_Gas
            Mainfrm.PictureBox13.Image = My.Resources.Concussion_Shot
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Surprise Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Trick Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Cluster Bomb")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox36, "Detonate Cluster")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Disabling Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Choking Gas")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Infiltrator's Arrow")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox36, Mainfrm.PictureBox36.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Shot an arrow that Immobilizes your foe.")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Bounce an arrow off multiple nearby foes." & vbCrLf & "Damage: 272" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Fire a cluster bomb at the target area. Detonate in midair for multiple explosions" _
                                & vbCrLf & "Large explosion: 715" & vbCrLf & "Small explosion: 246" & vbCrLf & "Bleeding(4s): -576 damage over time" _
                                & vbCrLf & "Combo Finisher: Blast")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox36, "Detonate cluster bomb in midair.")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Do an Evasive leap away from your foe while firing a Crippling shot." _
                                & vbCrLf & "Damage: 246" & vbCrLf & "Cripple(2s): -50% speed" & vbCrLf & "Combo Finisher: Physical Projectile")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Fire an arrow that fills the target area with a Poisonus cloud." _
                                & vbCrLf & "Poison(5s): -480 health, -33% reduce healing" & vbCrLf & "Combo Field: Poison")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Fire an arrow and shadowstep to the target area, Blinding nearby enemies." _
                                & vbCrLf & "Blindness(5s): Next outgoing attack misses")
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox3.Enabled = False
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Spatial_Surge
            Mainfrm.PictureBox10.Image = My.Resources.Mirror_Blade
            Mainfrm.PictureBox11.Image = My.Resources.Mind_Stab
            Mainfrm.PictureBox12.Image = My.Resources.Phantasmal_Berserker
            Mainfrm.PictureBox13.Image = My.Resources.Illusionary_Wave
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Spatial Surge")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Mirror Blade")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Mind Stab")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Phantasmal Berserker")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Illusionary Wave")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Shoot a beam at your foe. The farther away they are, the more damage you deal." & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Throw an illusionary greatsword that bounces between targets, damaging enemies" _
                                & vbCrLf & "and giving might to allies. It creates a clone at it's final target." & vbCrLf & "Damage: 296" _
                                & vbCrLf & "Might(5s): +5-35 Power" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Thrust your greatsword into the ground, creating a powerful attack that damages and applies Vulnerability." _
                                & vbCrLf & "Vulnerability(6s): -30 Defense" & vbCrLf & "Damage: 593" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Create a phantasm that uses a whirling attack to damage and Cripple foes." _
                                & vbCrLf & "Cripple(2s):-50% Movement Speed" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Push back all foes in front of you with a wave of magical energy." & vbCrLf & "Damage: 178" _
                                & vbCrLf & "Range: 425")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Sword_of_Wrath
            Mainfrm.PictureBox30.Image = My.Resources.Sword_Arc
            Mainfrm.PictureBox31.Image = My.Resources.Sword_Wave
            Mainfrm.PictureBox10.Image = My.Resources.Flashing_Blade
            Mainfrm.PictureBox11.Image = My.Resources.Zealot_s_Defense
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Sword of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Sword Arc")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Sword Wave")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Flashing Blade")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Zealot's Defence")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe once." & vbCrLf & "Damage: 376" & vbCrLf _
                                & "Range: 150" & vbCrLf & "Skill Chain:" & vbCrLf & "Sword of Wrath > Sword Arc > Sword Wave")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Slash your foe again." & vbCrLf & "Damage: 459" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Send out a cone attack, striking up to three enemies." & vbCrLf & "Damage: 543" & vbCrLf _
                                & "Range: 280")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Teleport to your target, striking them and Blinding nearby foes." & vbCrLf _
                                & "Damage: 84" & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Block ranged attacks while throwing magical projectiles." & vbCrLf _
                                & "Damage: 1104" & vbCrLf & "Block Duration: 3 seconds" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Orb_of_Wrath_png
            Mainfrm.PictureBox10.Image = My.Resources.Smite_png
            Mainfrm.PictureBox11.Image = My.Resources.Chains_of_Light_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Orb of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Smite")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Chains of Light")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Fire a slow-moving orb at your foe." & vbCrLf & "Damage: 355" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Strike foes in the target area repeatedly." & vbCrLf & "Damage: 2070" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Immobilize your foe with ethereal chains." & vbCrLf & "Immobilize(2s): Unable to move" _
                                & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.True_Strike
            Mainfrm.PictureBox30.Image = My.Resources.Pure_Strike
            Mainfrm.PictureBox31.Image = My.Resources.Faithful_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Symbol_of_Faith
            Mainfrm.PictureBox11.Image = My.Resources.Protector_s_Strike
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "True Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Pure Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Faithful Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Symbol of Faith")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Protector's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Smash your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "True Strike > Pure Strike > Faithful Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe." & vbCrLf & "Damage: 470" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Hit your fow with a final strike and heal your neabry allies." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Healing: 534" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Smash a mystic symbol onto the ground that damages foes and regenerates allies." _
                                & vbCrLf & "Damage: 209" & vbCrLf & "Regen(1s): +356 health regen" & vbCrLf & "Symbol Duration: 4 seconds" _
                                & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 120")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Surround yourself and nearby allies with a shield. Knock back enemies that strike protected allies." _
                                & " Grant Protection to yourself and nearby allies if you are not struck." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Protection(5s): 33% damage reduction" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Flurry_png
            Mainfrm.PictureBox9.Image = My.Resources.Sever_Artery_png
            Mainfrm.PictureBox30.Image = My.Resources.Gash_png
            Mainfrm.PictureBox31.Image = My.Resources.Final_Thrust_png
            Mainfrm.PictureBox10.Image = My.Resources.Savage_Leap_png
            Mainfrm.PictureBox11.Image = My.Resources.Hamstring_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Flurry")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Sever Artery")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Gash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Final Thrust")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Savage Leap")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Hamstring")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Immobilize your foes with a flurry of strikes. Effect increases with adrenaline level." _
                                & vbCrLf & "Damage: 2982" & vbCrLf & "Level 1 Immobilize(2s): Unable to move" & vbCrLf & "Level 2 Immobilize(3s): Unable to move" _
                                & vbCrLf & "Level 3 Immobilize(4s): Unable to move" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Bleed your foe with a slash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Sever Artery > Gash > Final Thrust")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Bleed your foe with a gash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Strike your foe with a final powerful thrust." & vbCrLf & "Damage: 693" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Lunge at your foe, striking them with your sword." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Cripple your foe with a precise slash." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Eviscerate_png
            Mainfrm.PictureBox9.Image = My.Resources.Chop_png
            Mainfrm.PictureBox30.Image = My.Resources.Double_Chop_png
            Mainfrm.PictureBox31.Image = My.Resources.Triple_Chop_png
            Mainfrm.PictureBox10.Image = My.Resources.Cyclone_Axe_png
            Mainfrm.PictureBox11.Image = My.Resources.Throw_Axe_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Eviscarate")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Chop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Double Chop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Triple Chop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Cyclone Ace")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Throw Axe")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Leap at your foe with a devastating attack. Effect increases with adrenaline level." _
                                & vbCrLf & "Level 1 Damage: 1066" & vbCrLf & "Level 2 Damage: 1332" & vbCrLf & "Level 3 Damage: 1598" & vbCrLf & "Combo Finisher: Leap" _
                                & vbCrLf & "Range: 300")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Chop your foe." & vbCrLf & "Damage: 453" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Chop > Double Chop > Triple Chop")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Chop your foe twice." & vbCrLf & "Damage: 906" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Deliver three final chop at your foe." & vbCrLf & "Damage: 1359" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Spin around and attack all nearby foes." & vbCrLf & "Damage: 399" _
                                & vbCrLf & "Vulnerability(8s): -30 defence" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Throw an axe that Cripples enemies." & vbCrLf & "Damage: 357" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox1.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Skull_Crack_png
            Mainfrm.PictureBox9.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox30.Image = My.Resources.Mace_Smash_png
            Mainfrm.PictureBox31.Image = My.Resources.Pulverize_png
            Mainfrm.PictureBox10.Image = My.Resources.Counter_Blow_png
            Mainfrm.PictureBox11.Image = My.Resources.Pommel_Bash_png
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Skull Crack")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Mace Smash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Mace Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Pulverize")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Counter Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Pommel Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Stun your foe with a skull crack. Effect increases with adrenaline level." _
                                & vbCrLf & "Damage: 533" & vbCrLf & "Level 1 Stun(2s): Unable to move" & vbCrLf & "Level 2 Stun(3s): Unable to move" _
                                & vbCrLf & "Level 3 Stun(4s): Unable to move" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Smash your foe." & vbCrLf & "Damage: 448" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Mace Smash > Mace Bash > Pulverize")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Bash your foe." & vbCrLf & "Damage: 426" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Trash your foe, leaving them weakened." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Weakness(5s): -50% Endurance Regen, 50% Fumble" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Block the next attack. Counter with an attack if you are in melee range. Gain adrenaline if not attacked." _
                                & vbCrLf & "Damage: 532")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Daze your foe with a brutal pommel bash." & vbCrLf & "Damage: 224" & vbCrLf & "Daze: 1 second" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Explosive_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Poison_Dart_Volley
            Mainfrm.PictureBox11.Image = My.Resources.Static_Shot
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Explosive Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Symbol of Faith")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Protector's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Fire a shot that explode on impact, Bleeding nearby foes." _
                                & vbCrLf & "Damage: 108" & vbCrLf & "Bleeding(4s): -192 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Fire a volley of darts that poison foes." _
                                & vbCrLf & "Damage: 89" & vbCrLf & "Poison(2s): -192 health, -33% reduce healing" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Discharge a lightning shot that bounces Blind and Confusion to multiple enemies." _
                                & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Confusion(3s): -77 health per skill used" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Slash
            Mainfrm.PictureBox30.Image = My.Resources.Kick
            Mainfrm.PictureBox31.Image = My.Resources.Pounce
            Mainfrm.PictureBox10.Image = My.Resources.Hornet_Sting
            Mainfrm.PictureBox36.Image = My.Resources.Monarch_s_Leap
            Mainfrm.PictureBox11.Image = My.Resources.Serpent_s_Strike
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Slash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Kick")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Pounce")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Hornet Sting")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox36, "Monarch's Leap")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Serpent's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox36, Mainfrm.PictureBox36.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Slash your foe." & vbCrLf & "Damage: 305" & vbCrLf _
                                & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Kick > Pounce")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Kick your foe causing a short Cripple." & vbCrLf & "Damage: 305" _
                                & vbCrLf & "Cripple(2s): -50% Movement Speed" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Leap at target foe, striking them. Your pet gain Might." & vbCrLf & "Damage: 509" & vbCrLf _
                                & vbCrLf & "Might(5s): +5-35 Power" & "Range: 430")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Chain. Stab your foe, then Evade backward." & vbCrLf & "Damage: 662" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hornet Sting > Monarch's Leap")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox36, "Chain. Leap back into the fight. Crippling your foe." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Cripple(3s): -50% Movement Speed" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Do an Evasive roll around your target, striking them and poisoning them." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Poison(6s): -582 health, -33% reduce healing" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox1.Text = "Axe" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox9.Image = My.Resources.Ricochet
            Mainfrm.PictureBox10.Image = My.Resources.Splitblade
            Mainfrm.PictureBox11.Image = My.Resources.Winter_s_Bite
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Ricochet")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Splitblade")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Winter's Bite")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Bounce your axe off multiple foes." & vbCrLf & "Damage: 356" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Throw a spread pattern of 5 whirling axes that Bleeds foes." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Bleed(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Throw an axe to Chill your foe. Your pet's next attacks inflicts Weakness." & vbCrLf & "Damage: 254" _
                                & vbCrLf & "Chilled(3s): -66% speed/recharge" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = True
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Tactical_Strike
            Mainfrm.PictureBox9.Image = My.Resources.Slice1
            Mainfrm.PictureBox30.Image = My.Resources.Slash1
            Mainfrm.PictureBox31.Image = My.Resources.Crippling_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Infiltrator_s_Strike
            Mainfrm.PictureBox36.Image = My.Resources.Shadow_Return
            Mainfrm.PictureBox11.Image = My.Resources.Stab
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Tactical Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Slice")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Slash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Crippling Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Infiltrator's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox36, "Shadow Return")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Stab")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox36, Mainfrm.PictureBox36.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Bash your foe with the hilt of the sword causing Blindness, Dazing if you hit them from behind." _
                                & vbCrLf & "Damage: 444" & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Daze: 1 second" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Slice your foe." & vbCrLf & "Damage: 394" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Slice > Slash > Crippling Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Slash your foe again." & vbCrLf & "Damage: 394" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Cripple your foe with a final strike." & vbCrLf & "Damage: 702" _
                                & vbCrLf & "Cripple(2s): -50% movement speed" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Chain. Shadowstep to your target, striking them. Use Shadow Return to shadowstep" _
                                & "back and lose one condition." & vbCrLf & "Damage: 370" & vbCrLf & "Range: 600" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Infiltrator's Strike > Shadow Return")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox36, "Chain. Return to your original location." & vbCrLf & "Break Stun" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Stab your foe." & vbCrLf & "Damage: 493" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Dagger" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = True
            Mainfrm.PictureBox31.Visible = True
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Backstab
            Mainfrm.PictureBox9.Image = My.Resources.Double_Strike
            Mainfrm.PictureBox30.Image = My.Resources.Wild_Strike
            Mainfrm.PictureBox31.Image = My.Resources.Lotus_Strike
            Mainfrm.PictureBox10.Image = My.Resources.Heartseeker
            Mainfrm.PictureBox11.Image = My.Resources.Twisting_Fangs
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Backstab")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Double Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox30, "Wild Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox31, "Lotus Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Heartseeker")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Twisting Fangs")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox30, Mainfrm.PictureBox30.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox31, Mainfrm.PictureBox31.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "Leap at your foe, striking for double damage if you hit from behind.")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Chain. Strike your foe twice." & vbCrLf & "Damage: 279" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Double Strike > Wild Strike > Lotus Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox30, "Chain. Strike your foe again." & vbCrLf & "Damage: 325" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox31, "Chain. Strike your foe with an 80% chance to cause Weakness." & vbCrLf & "Damage: 325" & vbCrLf _
                                & vbCrLf & "Weakness(3s): -50% Endurance Regeneration, 50% Fumble" & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Leap and strike your foe. The less health your target has, the more damage you cause." _
                                & vbCrLf & "Above 66%: 493" & vbCrLf & "Below 66%: 739" & vbCrLf & "Below 33%: 985" & vbCrLf & "Combo Finisher: Leap")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Spin in place, hitting nearby enemies. Each hit causes Bleeding." & vbCrLf & "Damage: 148" _
                                & vbCrLf & "Bleeding(10s): -480 damage over time" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox1.Text = "Pistol" Then '#one hand
            Mainfrm.ComboBox3.Enabled = True
            Mainfrm.ComboBox3.Text = "Off Hand"
            Mainfrm.PictureBox30.Visible = False
            Mainfrm.PictureBox31.Visible = False
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox36.Visible = False
            Mainfrm.PictureBox38.Visible = False
            Mainfrm.PictureBox40.Visible = True
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox40.Image = My.Resources.Sneak_Attack
            Mainfrm.PictureBox9.Image = My.Resources.Vital_Shot
            Mainfrm.PictureBox10.Image = My.Resources.Body_Shot
            Mainfrm.PictureBox11.Image = My.Resources.Repeater
            Mainfrm.PictureBox12.Image = My.Resources.Unknown
            Mainfrm.PictureBox13.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox40, "Sneak Attack")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox9, "Vital Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox10, "Body Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Repeater")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox40, Mainfrm.PictureBox40.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox9, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox10, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox40, "A rapid-fire attack that causes Bleeding.")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox9, "Bleed your foe with a shot to the vitals." & vbCrLf & "Damage: 179" _
                                & vbCrLf & "Bleeding(3s): -192 damage over time" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox10, "Make your foe Vulnerable with a body shot." & vbCrLf & "Damage: 246" _
                                & vbCrLf & "Vulnerability(8s): -30 defense" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Blast your foe with rapid fire from your pistol." & vbCrLf & "Damage: 590" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Select a off hand or a two hand weapon")
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
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Hammer_Swing
            Mainfrm.PictureBox32.Image = My.Resources.Hammer_Bash
            Mainfrm.PictureBox33.Image = My.Resources.Symbol_of_Protection
            Mainfrm.PictureBox28.Image = My.Resources.Mighty_Blow
            Mainfrm.PictureBox27.Image = My.Resources.Zealot_s_Embrace
            Mainfrm.PictureBox26.Image = My.Resources.Banish
            Mainfrm.PictureBox25.Image = My.Resources.Ring_of_Warding
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Hammer Swing")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Hammer Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Symbol of Protection")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Mighty Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Zealot's Embrace")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Banish")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Ring of Warding")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Strike your foe." & vbCrLf & "Damage: 368" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Symbol of Protection")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe." & vbCrLf & "Damage: 413" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Create a symbol that gives Protection to you and your allies." _
                                & vbCrLf & "Damage: 920" & vbCrLf & "Protection(1s): 33% damage reduction" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Damage nearby foes with a mighty ground slam." & vbCrLf & "Damage: 551" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 180")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Send a wave toward your foe that immobilizes enemies in a line." _
                                & vbCrLf & "Damage: 368" & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Launch your foe with a powerful smash." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Launch: 900" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Create a ring around you that foes cannot cross. Trapped enemies cannot exit the ring while it is active." _
                                & vbCrLf & "Duration: 5 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 180")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Staff" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = True
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Wave_of_Wrath
            Mainfrm.PictureBox28.Image = My.Resources.Orb_of_Light
            Mainfrm.PictureBox37.Image = My.Resources.Flash_of_Light
            Mainfrm.PictureBox27.Image = My.Resources.Symbol_of_Swiftness
            Mainfrm.PictureBox26.Image = My.Resources.Line_of_Warding
            Mainfrm.PictureBox25.Image = My.Resources.Martyr
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Wave of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Orb of Light")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox37, "Flash of Light")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Symbol of Swiftness")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Line of Warding")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Martyr")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox37, Mainfrm.PictureBox37.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Send out a powerful shockwave, hitting up to five enemies." _
                                & vbCrLf & "Damage: 276" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Chain. Fire a slow-moving orb of light that can be detonated to Heal allies." _
                                & vbCrLf & "Damage: 551" & vbCrLf & "Healing: 1372" & vbCrLf & "Detonate Damage: 276" & vbCrLf & "Range: 1200" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Orb of Light > Flash of Light")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox37, "Chain. Detonate the orb to Heal nearby allies. Recharge on Orb of Light is set to 4" _
                                & "times it's basic recharge." & vbCrLf & "Damage: 276" & vbCrLf & "Healing: 803" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Sear a mystic symbol into the target area, damaging foes and granting" _
                                & vbCrLf & "Swiftness to allies." & vbCrLf & "Damage: 230" & vbCrLf & "Swiftness(2s): +33% movement speed" _
                                & vbCrLf & "Symbol radius: 180" & vbCrLf & "Symbol duration: 4 seconds" & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Create a line in front of you that foes cannot cross." & vbCrLf & "Duration: 5 seconds")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Draw conditions from nearby allies to yourself. Gain multiple boons for a short" _
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
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Strike
            Mainfrm.PictureBox32.Image = My.Resources.Vengeful_Strike
            Mainfrm.PictureBox33.Image = My.Resources.Wrathful_Strike
            Mainfrm.PictureBox28.Image = My.Resources.Symbol_of_Wrath
            Mainfrm.PictureBox27.Image = My.Resources.Whirling_Wrath
            Mainfrm.PictureBox26.Image = My.Resources.Leap_of_Faith
            Mainfrm.PictureBox25.Image = My.Resources.Binding_Blade
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Vengeful Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Wrathful Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Symbol of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Whirling Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Leap of Faith")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Bindind Blade")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Strike your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Strike > Vengeful Strike > Wrathful Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Strike your foe again." & vbCrLf & "Damage: 376" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Attack your foe with a wrathful strike." _
                                & vbCrLf & "Damage: 459" & vbCrLf & "Might(3s): +5-35 Power" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Pierce the ground with a mystic symbol that damages and Burns foes while" _
                                & "granting Retaliation to allies." & vbCrLf & "Damage: 230" & vbCrLf _
                                & "Retaliation(2s): Reflect incoming damage back to it's source" & vbCrLf & "Combo Field: Light")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Spin in place and swing your greatword while hurling powerful projectiles." _
                                & vbCrLf & "Damage: 1413" & vbCrLf & "Projectile Damage: 1412" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Leap at your foe. On hit, blind nearby foes." & vbCrLf & "Damage: 459" & vbCrLf _
                                & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Throw blades at your foes, causing damage over time. Bounds foe can be" _
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Hammer Swing")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Hammer Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Hammer Smash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Fierce Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Hammer Shock")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Staggering Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Backbreaker")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Bash your foe." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hammer Swing > Hammer Bash > Hammer Blow")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe again." & vbCrLf & "Damage: 586" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Smash the ground and damage nearby foes." _
                                & vbCrLf & "Damage: 821" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Weaken your foe with a fierce blow." & vbCrLf & "Damage: 645" & vbCrLf _
                                & "Weakness(8s): -50% Endurance Regeneration, 50% Fumble" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Smash the ground and send out a Crippling wave." _
                                & vbCrLf & "Damage: 410" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Push back nearby foes with a stuggering blow." & vbCrLf & "Damage: 703" & vbCrLf _
                                & "Knockback: 180" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Knock down your target foe." & vbCrLf & "Damage: 879" _
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Greatsword Swing")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Greatsword Slice")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Brutal Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Hundred Blades")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Whirlwind Attack")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Bladetrail")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Rush")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Greatsword Swing > Greatosword Slice > Brutal Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Slice your foe." & vbCrLf & "Damage: 373" & vbCrLf & "Vulnerability(8s): -30 defense" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Hit your foes with a final brutal strike." _
                                & vbCrLf & "Damage: 480" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Repeatedly strike multiple foes. The last stike does extra damage." & vbCrLf & "Damage: 2756" & vbCrLf _
                                & "Final Strike Damage: 644" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Whirl in a target's direction, slashing foes along your path." _
                                & vbCrLf & "Damage: 373" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 450")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Throw your greatsword at your foe. It travels to your target and returns to you." _
                                & "Cripplings foes along your path." & vbCrLf & "Damage: 469" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Charge your foe." & vbCrLf & "Damage: 146" & vbCrLf & "Range: 1200")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Dual Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Fan of Fire")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Arcing Arrow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Smoldering Arrow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Pin Down")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Shot a pair of arrows at your foe." & vbCrLf & "Damage: 284" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Fire a spread of three flaming arrows, Burning foes." & vbCrLf & "Damage: 168" _
                                & vbCrLf & "Burning(2s): -690 health" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Shot a slow, arcing arrow that explodes on impact." & vbCrLf & "Damage: 814" _
                                & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Shot an arrow that explodes on impact. Blinding foes." _
                                & vbCrLf & "Damage: 112" & vbCrLf & "Blindness(5s): Next outgoing attack misses" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Fire an arrow that Immobilizes the target." & vbCrLf & "Damage: 234" _
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Bleeding Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Aimed Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Volley")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Brutal Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Rifle Butt")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Fire a shot that Bleeds your target." & vbCrLf & "Damage: 213" _
                                & vbCrLf & "Bleeding(6s): -270 damage over time" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Fire a precise shot that Cripples your foe." & vbCrLf & "Damage: 186" _
                                & vbCrLf & "Cripple(5s): -50% Speed" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Fire a volley of shots at your foe." & vbCrLf & "Damage: 376" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Shot your foes and make them Vulnerable." _
                                & vbCrLf & "Damage: 306" & vbCrLf & "Vulnerability(10s): -30 defence" & vbCrLf & "Combo Finisher: Physical Projectile" _
                                & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Push your foe back with your rifle butt." & vbCrLf & "Damage: 568" _
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Hip Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Net Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Blunderbuss")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Overcharged Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Jump Shot")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Deliver a quick rifle shot from the hip." & vbCrLf & "Damage: 155" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Immobilizie foes with a net shot." & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 1000")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Fire a cloud of sharpnel that causes more damage the closer you are to foes." _
                                & vbCrLf & "Within 8 fett: 621" & vbCrLf & "Within 16 feet: 563" & vbCrLf & "Within 24 feet: 466" _
                                & vbCrLf & "Within 32 feet: 388" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Fire a blast so strong it Launches your foe as you fall backward." _
                                & vbCrLf & "Damage: 388" & vbCrLf & "Enemy launch distance: 450" & vbCrLf & "Self knockback distance: 350" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Blast the ground, damaging nearby foes and leaping to your target." _
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Slash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Slice")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Power Stab")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Maul")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Swoop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Counterattack")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox39, "Crippling Throw")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Hilt Bash")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox39, Mainfrm.PictureBox39.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Slice > Power Stab")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Slice your foe." & vbCrLf & "Damage: 503" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Stab your foe and Evade attacks." & vbCrLf & "Damage: 671" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Bleed your foe four times with a mauling strike." & vbCrLf & "Damage: 280" & vbCrLf _
                                & "Bleeding(4s): -1546 damage over time" & vbCrLf & "Range: 150")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Run and leap at your foe, hitting them and nearby foes." _
                                & vbCrLf & "Damage: 783" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 770")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Chain. Block and counter an attack with a kick that pushes foes back." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Counterattack > Crippling Throw")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox39, "Chain. Throw your Greatsword, Crippling your foe." & vbCrLf & "Damage: 1119" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Daze your foe with a hilt bash. Stun them if you hit from behind. Your pet's" _
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Long Range Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Rapid Fire")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Hunter's Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Point Blank Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Barrage")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Shot your foe with a long range arrow. The farther the arrows flies, the more damage it does." _
                                & vbCrLf & "1000+ Range: 509" & vbCrLf & "500-1000 Range: 382" & vbCrLf & "0-500 Range: 254" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Fire multiple arrows at your foe." & vbCrLf & "Damage: 2040" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20& chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Fire an arrow to make your foe Vulnerability. Your pet gains Swiftness." & vbCrLf & "Damage: 267" _
                                & vbCrLf & "Vulnerability(10s): -30 defense" & vbCrLf & "Pet Swiftness(10s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Push back your foe with a point-blank shot. The closer they are, the farther it knocks back." _
                                & vbCrLf & "Damage: 539" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Barrage the target area with a hail of arrows that Cripple." & vbCrLf & "Damage: 1836" _
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Cross Fire")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Poison Volley")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Quick Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Crippling Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Concussion Shot")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Fire an arrow that bleeds your target if it hits your foe from behind or the side." _
                                & vbCrLf & "Damage: 204" & vbCrLf & "Bleeding(3s): -144 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Fire a spread of 5 poison arrows." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Poison(2s): -194 health, -33% reduce healing" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Fire a quick shot in an Evasive retreat. Gain Swiftness if the shot hits." _
                                & "This can be used while retreating." & vbCrLf & "Damage: 178" & vbCrLf & "Swiftness(3s): +33% Movement Speed" _
                                & vbCrLf & "Combo Finisher: Physical projectile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Shatter your foe's dreams of becoming an adventurer with a single arrow to the knee." _
                                & "Your pet's next three attacks inflict Bleeding." & vbCrLf & "Damage: 178" & vbCrLf & "Cripple(3s): -50% Speed" _
                                & vbCrLf & "Bleeding(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical Projetile" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Daze your foe with an arrow. Stun them if you hit from behind or from the side." & vbCrLf & "Damage: 178" _
                                & vbCrLf & "Daze: 1 second" & vbCrLf & "Stun: 1 second" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Trick Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Cluster Bomb")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox37, "Detonate Cluster")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Disabling Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Choking Gas")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Infiltrator's Arrow")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox37, Mainfrm.PictureBox37.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Bounce an arrow off multiple nearby foes." & vbCrLf & "Damage: 272" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Fire a cluster bomb at the target area. Detonate in midair for multiple explosions" _
                                & vbCrLf & "Large explosion: 715" & vbCrLf & "Small explosion: 246" & vbCrLf & "Bleeding(4s): -576 damage over time" _
                                & vbCrLf & "Combo Finisher: Blast")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox37, "Detonate cluster bomb in midair.")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Do an Evasive leap away from your foe while firing a Crippling shot." _
                                & vbCrLf & "Damage: 246" & vbCrLf & "Cripple(2s): -50% speed" & vbCrLf & "Combo Finisher: Physical Projectile")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Fire an arrow that fills the target area with a Poisonus cloud." _
                                & vbCrLf & "Poison(5s): -480 health, -33% reduce healing" & vbCrLf & "Combo Field: Poison")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Fire an arrow and shadowstep to the target area, Blinding nearby enemies." _
                                & vbCrLf & "Blindness(5s): Next outgoing attack misses")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Sword" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Sword_of_Wrath
            Mainfrm.PictureBox32.Image = My.Resources.Sword_Arc
            Mainfrm.PictureBox33.Image = My.Resources.Sword_Wave
            Mainfrm.PictureBox28.Image = My.Resources.Flashing_Blade
            Mainfrm.PictureBox27.Image = My.Resources.Zealot_s_Defense
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Sword of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Sword Arc")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Sword Wave")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Flashing Blade")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Zealot's Defence")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe once." & vbCrLf & "Damage: 376" & vbCrLf _
                                & "Range: 150" & vbCrLf & "Skill Chain:" & vbCrLf & "Sword of Wrath > Sword Arc > Sword Wave")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Slash your foe again." & vbCrLf & "Damage: 459" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Send out a cone attack, striking up to three enemies." & vbCrLf & "Damage: 543" & vbCrLf _
                                & "Range: 280")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Teleport to your target, striking them and Blinding nearby foes." & vbCrLf _
                                & "Damage: 84" & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Block ranged attacks while throwing magical projectiles." & vbCrLf _
                                & "Damage: 1104" & vbCrLf & "Block Duration: 3 seconds" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Scepter" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Orb_of_Wrath_png
            Mainfrm.PictureBox28.Image = My.Resources.Smite_png
            Mainfrm.PictureBox27.Image = My.Resources.Chains_of_Light_png
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Orb of Wrath")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Smite")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Chains of Light")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Fire a slow-moving orb at your foe." & vbCrLf & "Damage: 355" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Strike foes in the target area repeatedly." & vbCrLf & "Damage: 2070" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Immobilize your foe with ethereal chains." & vbCrLf & "Immobilize(2s): Unable to move" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox2.Text = "Mace" Then '#one hand
            Mainfrm.ComboBox4.Enabled = True
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = True
            Mainfrm.PictureBox33.Visible = True
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox40.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.True_Strike
            Mainfrm.PictureBox32.Image = My.Resources.Pure_Strike
            Mainfrm.PictureBox33.Image = My.Resources.Faithful_Strike
            Mainfrm.PictureBox28.Image = My.Resources.Symbol_of_Faith
            Mainfrm.PictureBox27.Image = My.Resources.Protector_s_Strike
            Mainfrm.PictureBox26.Image = My.Resources.Unknown
            Mainfrm.PictureBox25.Image = My.Resources.Unknown
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "True Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Pure Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Faithful Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Symbol of Faith")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Protector's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Smash your foe." & vbCrLf & "Damage: 334" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "True Strike > Pure Strike > Faithful Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe." & vbCrLf & "Damage: 470" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Hit your fow with a final strike and heal your neabry allies." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Healing: 534" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Smash a mystic symbol onto the ground that damages foes and regenerates allies." _
                                & vbCrLf & "Damage: 209" & vbCrLf & "Regen(1s): +356 health regen" & vbCrLf & "Symbol Duration: 4 seconds" _
                                & vbCrLf & "Combo Field: Light" & vbCrLf & "Range: 120")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Surround yourself and nearby allies with a shield. Knock back enemies that" _
                                & "strike protected allies. Grant Protection to yourself and nearby allies if you are" & "not struck." _
                                & vbCrLf & "Damage: 584" & vbCrLf & "Protection(5s): 33% damage reduction" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Sever Artery")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Gash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Final Thrust")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Savage Leap")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Hamstring")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Bleed your foe with a slash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Sever Artery > Gash > Final Thrust")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Bleed your foe with a gash." & vbCrLf & "Damage: 320" _
                                & vbCrLf & "Bleedind(8s): -360 damage over time" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Strike your foe with a final powerful thrust." & vbCrLf & "Damage: 693" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Lunge at your foe, striking them with your sword." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Cripple your foe with a precise slash." & vbCrLf _
                                & "Damage: 400" & vbCrLf & "Cripple(7s): -50% Speed" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Chop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Double Chop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Triple Chop")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Cyclone Ace")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Throw Axe")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Chop your foe." & vbCrLf & "Damage: 453" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Chop > Double Chop > Triple Chop")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Chop your foe twice." & vbCrLf & "Damage: 906" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Deliver three final chop at your foe." & vbCrLf & "Damage: 1359" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Spin around and attack all nearby foes." & vbCrLf & "Damage: 399" _
                                & vbCrLf & "Vulnerability(8s): -30 defence" & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Throw an axe that Cripples enemies." & vbCrLf & "Damage: 357" & vbCrLf & "Cripple(4s): -50% Speed" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Mace Smash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Mace Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Pulverize")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Counter Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Pommel Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Smash your foe." & vbCrLf & "Damage: 448" & vbCrLf & "Range: 130" & vbCrLf & _
                                "Skill Chain:" & vbCrLf & "Mace Smash > Mace Bash > Pulverize")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Bash your foe." & vbCrLf & "Damage: 426" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Trash your foe, leaving them weakened." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Weakness(5s): -50% Endurance Regen, 50% Fumble" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Block the next attack. Counter with an attack if you are in melee range. Gain adrenaline if not attacked." _
                                & vbCrLf & "Damage: 532")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Daze your foe with a brutal pommel bash." & vbCrLf & "Damage: 224" & vbCrLf & "Daze: 1 second" _
                                & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Explosive Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Poison Dart Volley")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Static Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Fire a shot that explode on impact, Bleeding nearby foes." _
                                & vbCrLf & "Damage: 108" & vbCrLf & "Bleeding(4s): -192 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Fire a volley of darts that poison foes." _
                                & vbCrLf & "Damage: 89" & vbCrLf & "Poison(2s): -192 health, -33% reduce healing" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Discharge a lightning shot that bounces Blind and Confusion to multiple enemies." _
                                & vbCrLf & "Blindness(3s): Next outgoing attack misses" & vbCrLf & "Confusion(3s): -77 health per skill used" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Slash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Kick")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Pounce")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Hornet Sting")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox37, "Monarch's Leap")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Serpent's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox37, Mainfrm.PictureBox37.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Slash your foe." & vbCrLf & "Damage: 305" & vbCrLf _
                                & "Range: 130" & vbCrLf & "Skill Chain:" & vbCrLf & "Slash > Kick > Pounce")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Kick your foe causing a short Cripple." & vbCrLf & "Damage: 305" _
                                & vbCrLf & "Cripple(2s): -50% Movement Speed" & vbCrLf & "Range: 400")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Leap at target foe, striking them. Your pet gain Might." & vbCrLf & "Damage: 509" & vbCrLf _
                                & vbCrLf & "Might(5s): +5-35 Power" & "Range: 430")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Chain. Stab your foe, then Evade backward." & vbCrLf & "Damage: 662" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Hornet Sting > Monarch's Leap")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox37, "Chain. Leap back into the fight. Crippling your foe." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Cripple(3s): -50% Movement Speed" & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Do an Evasive roll around your target, striking them and poisoning them." & vbCrLf & "Damage: 382" _
                                & vbCrLf & "Poison(6s): -582 health, -33% reduce healing" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Ricochet")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Splitblade")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Winter's Bite")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Bounce your axe off multiple foes." & vbCrLf & "Damage: 356" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Throw a spread pattern of 5 whirling axes that Bleeds foes." & vbCrLf & "Damage: 51" _
                                & vbCrLf & "Bleed(6s): -288 damage over time" & vbCrLf & "Combo Finisher: Physical projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Throw an axe to Chill your foe. Your pet's next attacks inflicts Weakness." & vbCrLf & "Damage: 254" _
                                & vbCrLf & "Chilled(3s): -66% speed/recharge" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Slice")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Slash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Crippling Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Infiltrator's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox37, "Shadow Return")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Stab")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox37, Mainfrm.PictureBox37.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Slice your foe." & vbCrLf & "Damage: 394" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Slice > Slash > Crippling Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Slash your foe again." & vbCrLf & "Damage: 394" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Cripple your foe with a final strike." & vbCrLf & "Damage: 702" _
                                & vbCrLf & "Cripple(2s): -50% movement speed" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Chain. Shadowstep to your target, striking them. Use Shadow Return to shadowstep" _
                                & "back and lose one condition." & vbCrLf & "Damage: 370" & vbCrLf & "Range: 600" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Infiltrator's Strike > Shadow Return")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox37, "Chain. Return to your original location." & vbCrLf & "Break Stun" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Stab your foe." & vbCrLf & "Damage: 493" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Double Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox32, "Wild Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox33, "Lotus Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Heartseeker")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Twisting Fangs")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox32, Mainfrm.PictureBox32.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox33, Mainfrm.PictureBox33.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Chain. Strike your foe twice." & vbCrLf & "Damage: 279" & vbCrLf & "Range: 130" _
                                & vbCrLf & "Skill Chain:" & vbCrLf & "Double Strike > Wild Strike > Lotus Strike")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox32, "Chain. Strike your foe again." & vbCrLf & "Damage: 325" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox33, "Chain. Strike your foe with an 80% chance to cause Weakness." & vbCrLf & "Damage: 325" & vbCrLf _
                                & vbCrLf & "Weakness(3s): -50% Endurance Regeneration, 50% Fumble" & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Leap and strike your foe. The less health your target has, the more damage you cause." _
                                & vbCrLf & "Above 66%: 493" & vbCrLf & "Below 66%: 739" & vbCrLf & "Below 33%: 985" & vbCrLf & "Combo Finisher: Leap")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Spin in place, hitting nearby enemies. Each hit causes Bleeding." & vbCrLf & "Damage: 148" _
                                & vbCrLf & "Bleeding(10s): -480 damage over time" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
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
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Vital Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Body Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Repeater")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox29.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox28.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, My.Resources.null)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Bleed your foe with a shot to the vitals." & vbCrLf & "Damage: 179" _
                                & vbCrLf & "Bleeding(3s): -192 damage over time" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Make your foe Vulnerable with a body shot." & vbCrLf & "Damage: 246" _
                                & vbCrLf & "Vulnerability(8s): -30 defense" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Blast your foe with rapid fire from your pistol." & vbCrLf & "Damage: 590" _
                                & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Select a off hand or a two hand weapon")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Select a off hand or a two hand weapon")
        ElseIf Mainfrm.Label9.Text = "m" And Mainfrm.ComboBox1.Text = "Greatsword" Then '#two hand
            Mainfrm.ComboBox4.Enabled = False
            Mainfrm.ComboBox4.Text = "Off Hand"
            Mainfrm.PictureBox32.Visible = False
            Mainfrm.PictureBox33.Visible = False
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox37.Visible = False
            Mainfrm.PictureBox39.Visible = False
            Mainfrm.PictureBox41.Visible = False
            Mainfrm.PictureBox42.Visible = False
            Mainfrm.PictureBox43.Visible = False
            Mainfrm.PictureBox29.Image = My.Resources.Spatial_Surge
            Mainfrm.PictureBox28.Image = My.Resources.Mirror_Blade
            Mainfrm.PictureBox27.Image = My.Resources.Mind_Stab
            Mainfrm.PictureBox26.Image = My.Resources.Phantasmal_Berserker
            Mainfrm.PictureBox25.Image = My.Resources.Illusionary_Wave
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox29, "Spatial Surge")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox28, "Mirror Blade")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Mind Stab")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Phantasmal Berserker")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Illusionary Wave")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox29, Mainfrm.PictureBox9.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox28, Mainfrm.PictureBox10.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox11.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox29, "Shoot a beam at your foe. The farther away they are, the more damage you deal." _
                                        & vbCrLf & "Range: 1,200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox28, "Throw an illusionary greatsword that bounces between targets, damaging enemies" _
                                & vbCrLf & "and giving might to allies. It creates a clone at it's final target." & vbCrLf & "Damage: 296" & vbCrLf _
                                & "Might(5s):+5-35 Power" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Thrust your greatsword into the ground, creating a powerful attack that damages and applies Vulnerability." _
                                & vbCrLf & "Vulnerability(6s):-30 Defense" & vbCrLf & "Damage: 593" & vbCrLf & "Range: 1,200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Create a phantasm that uses a whirling attack to damage and Cripple foes." & vbCrLf & "Cripple(2s):-50% Movement Speed" & vbCrLf _
                                & "Range: 1,200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Push back all foes in front of you with a wave of magical energy." _
                                & vbCrLf & "Damage: 178" & vbCrLf & "Range: 425")
        End If
    End Sub
#End Region

#Region "ComboBox3"
    Public Sub CmbBox3()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Shield_of_Judgment_png
            Mainfrm.PictureBox13.Image = My.Resources.Shield_of_Absorption_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Shield of Judgment")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Shield of Absorption")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Create a shielding wave in front of you that damages foe and gives" _
                                & vbCrLf & "Protection to yourself and up to five allies." & vbCrLf & "Damage: 376" & vbCrLf & "Protection(5s): 33% damage reduction" _
                                & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Create a dome aroung you that Pushes foes back and Absorb projectiles." _
                                & vbCrLf & "KnockBack Distance: 320" & vbCrLf & "Shield duration: 4 seconds" & vbCrLf & "Combo Field: Light")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Focus" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Ray_of_Judgment
            Mainfrm.PictureBox13.Image = My.Resources.Shield_of_Wrath
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Ray of Judgment")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Shield of Wrath")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Pass a ray over foes and allies. Foes are damaged and Blinded. Allies gain" _
                                & "Regeneration and lose one condition." & vbCrLf & "Damage: 188" & vbCrLf & "Blindness(5s): Next outgoing attack misses" _
                                & vbCrLf & "Regen(5s): +455 health regen" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Create a shield to Block the next 3 attacks. If the shield is not destroyed, it" _
                                & "explodes, damaging nearby foes." & vbCrLf & "Damage: 1044" & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 255")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox3.Text = "Torch" Then
            Mainfrm.PictureBox34.Visible = True
            Mainfrm.PictureBox12.Image = My.Resources.Cleansing_Flame_png
            Mainfrm.PictureBox13.Image = My.Resources.Zealot_s_Flame_png
            Mainfrm.PictureBox34.Image = My.Resources.Zealot_s_Fire
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Cleasing Flame")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Zealot's Flame")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox34, "Zealot's Fire")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox34, Mainfrm.PictureBox34.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Breathe magical flames than damages foes and remove condition from allies." _
                                & vbCrLf & "Damage: 94" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Chain. Set yourself alightm, preiodically Burning up to threee nearby foes." _
                                & vbCrLf & "Duration: 10 seconds" & vbCrLf & "Skill Chain:" & vbCrLf & "Zealot's Flame > Zealot's Fire")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox34, "Chain. Throw your Zealot's Flame at the targeted foe, damaging them" _
                                & "but increasing the skill's recharge time by 50%." & vbCrLf & "Damage: ???" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Sword" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Impale_png
            Mainfrm.PictureBox13.Image = My.Resources.Riposte_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Impale")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Risposte")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Throw our sword at your foe and apply multiple stacks of Bleeding over time." _
                                & vbCrLf & "Damage: 301" & vbCrLf & "Bleeding(12s): -2,160 damage over time" & vbCrLf & "Combo Finisher: Physical projectile" _
                                & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Block the next incoming attack. Risposte and Bleed your foe if you block a melee" _
                                & "attack. Gain adrenaline if your are not attacked." & vbCrLf & "Damage: 266" & vbCrLf & "Bleeding(12s): -2160 damage over time")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Shield_Bash_png
            Mainfrm.PictureBox13.Image = My.Resources.Shield_Stance_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Shield Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Shield Stance")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Bash your foe with your shield and Stun them." & vbCrLf & "Damage: 479" & vbCrLf & "Stun: 1 second" _
                                & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Block incoming attacks." & vbCrLf & "Duration: 3 seconds")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Axe" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Dual_Strike_png
            Mainfrm.PictureBox13.Image = My.Resources.Whirling_Axe_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Dual Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Whirling Axe")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Strike your foe with both axes. Gain Fury with each hit." & vbCrLf & "Damage: 638" _
                                & vbCrLf & "Fury(2s): +20% critical" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Spin and attacking nearby foes. You can move while spinning." & vbCrLf & "Damage: 1590" _
                                & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Warhorn" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Charge_png
            Mainfrm.PictureBox13.Image = My.Resources.Call_to_Arms_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Charge")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Call to Arms")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Grant swiftness to yourself and allies, while removing Chill, Cripple and Immobilize." _
                                & vbCrLf & "Swiftness(10s): +33% Movement Speed" & vbCrLf & "Removes Cripple: -50% Movement Speed" _
                                & vbCrLf & "Removes Immobilizes: Unable to move" & vbCrLf & "Removes Frozen: -66% Speed/Recharge" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Grant Vigor to yourself and allies, while Weakening nearby foes." _
                                & vbCrLf & "Vigor(10s): +100% Endurance regeneration" & vbCrLf & "Weakness(6s): -50% Endurance Regeneration, 50% Fumble" _
                                & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox3.Text = "Mace" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Crushing_Blow
            Mainfrm.PictureBox13.Image = My.Resources.Tremor_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Crushing Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Tremor")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Crash your opponent's armor, leaving them Vulnerable." & vbCrLf & "Damage: 532" _
                                & vbCrLf & "Vulnerability(10s): -50 defence" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Send a wave toward your foe that knocks down enemies in a line." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Knockdown: 2 seconds" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox3.Text = "Pistol" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Blowtorch
            Mainfrm.PictureBox13.Image = My.Resources.Glue_Shot
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Blowtorch")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Glue Shot")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Unleash flame from your pistol to Burn foes." & vbCrLf & "Damage: 67" _
                                & vbCrLf & "Within 15 feet(9s): -3231 health" & vbCrLf & "Within 30 feet(6s): -2154 health" _
                                & vbCrLf & "Within 45 feet(3s): -1077 health" & vbCrLf & "Range: 550")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Coat the target area with a glue paddle that Immobilizes foes." _
                                & vbCrLf & "Immobilize(1s): Unable to move" & vbCrLf & "Glue paddle duration: 6 seconds" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox3.Text = "Shield" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Magnetic_Field
            Mainfrm.PictureBox13.Image = My.Resources.Static_Shield
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Magnetic Field")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Static Shield")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Create a magnetic field that Reflects projectiles and can be released to Push" _
                                & "back foes." & vbCrLf & "Damage: 61" & vbCrLf & "Knockback: 300")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Electrify your shield, preparing to throw it at foes. If you are hit, the shield" _
                                & "discharges, Stunning your nearby attacker." & vbCrLf & "Stun: 3 seconds")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Dagger" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Stalker_s_Strike
            Mainfrm.PictureBox13.Image = My.Resources.Crippling_Talon
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Stalker's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Crippling Talon")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Stab your foe, Poisons them and Evading attacks." & vbCrLf & "Damage: 102" _
                                & vbCrLf & "Poison(10s): -970 health, -33% reduce healing" & vbCrLf & "Range: 270")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Throw a dagger to Bleed and Cripple your foe." & vbCrLf & "Damage: 381" _
                                & vbCrLf & "Cripple(6s): -50% speed" & vbCrLf & "Blleding(8s): -1152 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Axe" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Path_of_Scars
            Mainfrm.PictureBox13.Image = My.Resources.Whirling_Defense
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Path of Scars")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Whirling Defense")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Boomerang a axe in a line, striking foes each way." & vbCrLf & "Damage: 542" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Block projectiles while damaging nearby foes." _
                                & vbCrLf & "Damage: 81" & vbCrLf & "Duration: 5 seconds" & vbCrLf & "Combo Finisher: Whirl")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Warhorn" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Hunter_s_Call
            Mainfrm.PictureBox13.Image = My.Resources.Call_of_the_Wild
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Hunter's Call")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Call of the Wild")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Call hawks to swarm your foe." & vbCrLf & "Damage: 880" _
                                & vbCrLf & "Damafe if Traited: 1110" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Grant Fury, Might and Swiftness to yoursellf and nearby allies." _
                                & vbCrLf & "Fury(15s): +20% Critical" & vbCrLf & "Might(15s): +5-35 Power" & vbCrLf & "Swiftness(15s): +33% movement speed" _
                                & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox3.Text = "Torch" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Throw_Torch
            Mainfrm.PictureBox13.Image = My.Resources.Bonfire
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Throw Torch")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Bonfire")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Throw your torch and burn your foe." & vbCrLf & "Damage: 229" _
                                & vbCrLf & "Burning(3s): -1086 health" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Set a fire around you, Burning foes." _
                                & vbCrLf & "Damage: 49" & vbCrLf & "Burning(1s): -362 health" & vbCrLf & "Combo Field: Fire")
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox3.Text = "Dagger" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Dancing_Dagger
            Mainfrm.PictureBox13.Image = My.Resources.Cloak_and_Dagger
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Dancing Dagger")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Cloak and Dagger")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Throw a dagger that Cripples nearby foes and returns to you." & vbCrLf & "Damage: 493" _
                                & vbCrLf & "Crippled(5s):-50% Movement Speed" & vbCrLf & "Combo Finisher: Physical Projectile")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Stab your foe and vanish in Stealth, leaving them Vulnerable." _
                                & vbCrLf & "Damage: 793" & vbCrLf & "Vulnerability(5s):-30 Defense")
            If Mainfrm.ComboBox1.Text = "Sword" Then
                Mainfrm.PictureBox11.Image = My.Resources.Flanking_Strike
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Flanking Strike")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Evade and stab your foe in the back twice." _
                                & vbCrLf & "Damage: 370" & vbCrLf & "Second strike damage: 739")
            ElseIf Mainfrm.ComboBox1.Text = "Dagger" Then
                Mainfrm.PictureBox11.Image = My.Resources.Death_Blossom
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Death Blossom")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Do an Evasive attack over your opponent, striking nearby enemies three times. Each hit causes Bleeding." _
                                & vbCrLf & "Damage: 444" & vbCrLf & "Bleeding(10s): -1,440 damage over time" & vbCrLf & "Combo Finisher: Whirl")
            ElseIf Mainfrm.ComboBox1.Text = "Pistol" Then
                Mainfrm.PictureBox11.Image = My.Resources.Shadow_Strike
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Shadow Strike")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Stab your foe, then shadowstep away and shoot them." _
                                & vbCrLf & "Damage: 148" & vbCrLf & "Shot Damage damage: 493")
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox3.Text = "Pistol" Then
            Mainfrm.PictureBox34.Visible = False
            Mainfrm.PictureBox12.Image = My.Resources.Head_Shot
            Mainfrm.PictureBox13.Image = My.Resources.Black_Powder
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox12, "Head Shot")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox13, "Black Powder")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox12, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox13, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Daze your foe with a headshot." & vbCrLf & "Damage: 138" _
                                & vbCrLf & "Daze(0.25s): Unable to use skills" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Fire a shot with black powder, creating a smoke cloud that Blinds nearby enemies." _
                                & vbCrLf & "Damage: 138" & vbCrLf & "Combo Field: Smoke" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            If Mainfrm.ComboBox1.Text = "Sword" Then
                Mainfrm.PictureBox11.Image = My.Resources.Pistol_Whip
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Pistol Whip")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Pistol whip your foe, Stunning them, then slash repeatedly with your sword." _
                                & vbCrLf & "Damage: 1211" & vbCrLf & "Stun:0.5 seconds")
            ElseIf Mainfrm.ComboBox1.Text = "Dagger" Then
                Mainfrm.PictureBox11.Image = My.Resources.Shadow_Shot
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Shadow Shot")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Fire a Blinding shot at your foe and shadowstep to them for a dagger strike." _
                                & vbCrLf & "Blindness(5s):Next outgoing attack misses." & vbCrLf & "Damage: 616" & vbCrLf & "Combo Finisher: Physical Projectile")
            ElseIf Mainfrm.ComboBox1.Text = "Pistol" Then
                Mainfrm.PictureBox11.Image = My.Resources.Unload
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox11, "Unload")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox11, Mainfrm.PictureBox11.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox11, "Blast your foe repeatedly with both pistols." _
                                & vbCrLf & "Damage: 148" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)")
            End If

        End If
    End Sub
#End Region

#Region "ComboBox4"
    Public Sub CmbBox4()
        If Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Shield_of_Judgment_png
            Mainfrm.PictureBox25.Image = My.Resources.Shield_of_Absorption_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Shield of Judgment")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Shield of Absorption")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Create a shielding wave in front of you that damages foe and gives" _
                                & "Protection to yourself and up to five allies." & vbCrLf & "Damage: 376" & vbCrLf & "Protection(5s): 33% damage reduction" _
                                & vbCrLf & "Range: 600")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Create a dome aroung you that Pushes foes back and Absorb projectiles." _
                                & vbCrLf & "KnockBack Distance: 320" & vbCrLf & "Shield duration: 4 seconds" & vbCrLf & "Combo Field: Light")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Focus" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Ray_of_Judgment
            Mainfrm.PictureBox25.Image = My.Resources.Shield_of_Wrath
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Ray of Judgment")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Shield of Wrath")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Pass a ray over foes and allies. Foes are damaged and Blinded. Allies gain" _
                                & "Regeneration and lose one condition." & vbCrLf & "Damage: 188" & vbCrLf & "Blindness(5s): Next outgoing attack misses" _
                                & vbCrLf & "Regen(5s): +455 health regen" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Create a shield to Block the next 3 attacks. If the shield is not destroyed, it" _
                                & "explodes, damaging nearby foes." & vbCrLf & "Damage: 1044" & vbCrLf & "Combo Finisher: Blast" & vbCrLf & "Range: 255")
        ElseIf Mainfrm.Label9.Text = "g" And Mainfrm.ComboBox4.Text = "Torch" Then
            Mainfrm.PictureBox35.Visible = True
            Mainfrm.PictureBox26.Image = My.Resources.Cleansing_Flame_png
            Mainfrm.PictureBox25.Image = My.Resources.Zealot_s_Flame_png
            Mainfrm.PictureBox35.Image = My.Resources.Zealot_s_Fire
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Cleasing Flmae")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Zealot's Flame")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox35, "Zealot's Fire")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox35, Mainfrm.PictureBox35.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Breathe magical flames than damages foes and remove condition from allies." _
                                & vbCrLf & "Damage: 94" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Chain. Set yourself alightm, preiodically Burning up to threee nearby foes." _
                                & vbCrLf & "Duration: 10 seconds" & vbCrLf & "Skill Chain:" & vbCrLf & "Zealot's Flame > Zealot's Fire")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox35, "Chain. Throw your Zealot's Flame at the targeted foe, damaging them" _
                                & "but increasing the skill's recharge time by 50%." & vbCrLf & "Damage: ???" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Sword" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Impale_png
            Mainfrm.PictureBox25.Image = My.Resources.Riposte_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Impale")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Risposte")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Throw our sword at your foe and apply multiple stacks of Bleeding over time." _
                                & vbCrLf & "Damage: 301" & vbCrLf & "Bleeding(12s): -2,160 damage over time" & vbCrLf & "Combo Finisher: Physical projectile" _
                                & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Block the next incoming attack. Risposte and Bleed your foe if you block a melee" _
                                & "attack. Gain adrenaline if your are not attacked." & vbCrLf & "Damage: 266" & vbCrLf & "Bleeding(12s): -2160 damage over time")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Shield_Bash_png
            Mainfrm.PictureBox25.Image = My.Resources.Shield_Stance_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Shield Bash")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Shield Stance")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Bash your foe with your shield and Stun them." & vbCrLf & "Damage: 479" & vbCrLf & "Stun: 1 second" _
                                & vbCrLf & "Combo Finisher: Leap" & vbCrLf & "Range: 300")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Block incoming attacks." & vbCrLf & "Duration: 3 seconds")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Axe" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Dual_Strike_png
            Mainfrm.PictureBox25.Image = My.Resources.Whirling_Axe_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Dual Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Whirling Axe")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Strike your foe with both axes. Gain Fury with each hit." & vbCrLf & "Damage: 638" _
                                & vbCrLf & "Fury(2s): +20% critical" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Spin and attacking nearby foes. You can move while spinning." & vbCrLf & "Damage: 1590" _
                                & vbCrLf & "Combo Finisher: Whirl" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Warhorn" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Charge_png
            Mainfrm.PictureBox25.Image = My.Resources.Call_to_Arms_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Charge")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Call to Arms")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Grant swiftness to yourself and allies, while removing Chill, Cripple and Immobilize." _
                                & vbCrLf & "Swiftness(10s): +33% Movement Speed" & vbCrLf & "Removes Cripple: -50% Movement Speed" _
                                & vbCrLf & "Removes Immobilizes: Unable to move" & vbCrLf & "Removes Frozen: -66% Speed/Recharge" & vbCrLf & "Range: 1200")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Grant Vigor to yourself and allies, while Weakening nearby foes." _
                                & vbCrLf & "Vigor(10s): +100% Endurance regeneration" & vbCrLf & "Weakness(6s): -50% Endurance Regeneration, 50% Fumble" _
                                & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "w" And Mainfrm.ComboBox4.Text = "Mace" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Crushing_Blow
            Mainfrm.PictureBox25.Image = My.Resources.Tremor_png
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Crushing Blow")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Tremor")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Crash your opponent's armor, leaving them Vulnerable." & vbCrLf & "Damage: 532" _
                                & vbCrLf & "Vulnerability(10s): -50 defence" & vbCrLf & "Range: 130")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Send a wave toward your foe that knocks down enemies in a line." & vbCrLf & "Damage: 426" _
                                & vbCrLf & "Knockdown: 2 seconds" & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 1200")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox4.Text = "Pistol" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Blowtorch
            Mainfrm.PictureBox25.Image = My.Resources.Glue_Shot
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Blowtorch")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Glue Shot")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Unleash flame from your pistol to Burn foes." & vbCrLf & "Damage: 67" _
                                & vbCrLf & "Within 15 feet(9s): -3231 health" & vbCrLf & "Within 30 feet(6s): -2154 health" _
                                & vbCrLf & "Within 45 feet(3s): -1077 health" & vbCrLf & "Range: 550")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Coat the target area with a glue paddle that Immobilizes foes." _
                                & vbCrLf & "Immobilize(1s): Unable to move" & vbCrLf & "Glue paddle duration: 6 seconds" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "en" And Mainfrm.ComboBox4.Text = "Shield" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Magnetic_Field
            Mainfrm.PictureBox25.Image = My.Resources.Static_Shield
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Magnetic Field")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Static Shield")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Create a magnetic field that Reflects projectiles and can be released to Push" _
                                & "back foes." & vbCrLf & "Damage: 61" & vbCrLf & "Knockback: 300")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Electrify your shield, preparing to throw it at foes. If you are hit, the shield" _
                                & "discharges, Stunning your nearby attacker." & vbCrLf & "Stun: 3 seconds")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Dagger" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Stalker_s_Strike
            Mainfrm.PictureBox25.Image = My.Resources.Crippling_Talon
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Stalker's Strike")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Crippling Talon")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Stab your foe, Poisons them and Evading attacks." & vbCrLf & "Damage: 102" _
                                & vbCrLf & "Poison(10s): -970 health, -33% reduce healing" & vbCrLf & "Range: 270")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Throw a dagger to Bleed and Cripple your foe." & vbCrLf & "Damage: 381" _
                                & vbCrLf & "Cripple(6s): -50% speed" & vbCrLf & "Blleding(8s): -1152 damage over time" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Axe" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Path_of_Scars
            Mainfrm.PictureBox25.Image = My.Resources.Whirling_Defense
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Path of Scars")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Whirling Defense")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox12, "Boomerang a axe in a line, striking foes each way." & vbCrLf & "Damage: 542" _
                                & vbCrLf & "Combo Finisher: Physical Projectile" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox13, "Block projectiles while damaging nearby foes." _
                                & vbCrLf & "Damage: 81" & vbCrLf & "Duration: 5 seconds" & vbCrLf & "Combo Finisher: Whirl")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Warhorn" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Hunter_s_Call
            Mainfrm.PictureBox25.Image = My.Resources.Call_of_the_Wild
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Hunter's Call")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Call of the Wild")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Call hawks to swarm your foe." & vbCrLf & "Damage: 880" _
                                & vbCrLf & "Damafe if Traited: 1110" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Grant Fury, Might and Swiftness to yoursellf and nearby allies." _
                                & vbCrLf & "Fury(15s): +20% Critical" & vbCrLf & "Might(15s): +5-35 Power" & vbCrLf & "Swiftness(15s): +33% movement speed" _
                                & vbCrLf & "Range: 900")
        ElseIf Mainfrm.Label9.Text = "r" And Mainfrm.ComboBox4.Text = "Torch" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Throw_Torch
            Mainfrm.PictureBox25.Image = My.Resources.Bonfire
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Throw Torch")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Bonfire")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Throw your torch and burn your foe." & vbCrLf & "Damage: 229" _
                                & vbCrLf & "Burning(3s): -1086 health" & vbCrLf & "Range: 900")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Set a fire around you, Burning foes." _
                                & vbCrLf & "Damage: 49" & vbCrLf & "Burning(1s): -362 health" & vbCrLf & "Combo Field: Fire")
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox4.Text = "Dagger" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Dancing_Dagger
            Mainfrm.PictureBox25.Image = My.Resources.Cloak_and_Dagger
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Dancing Dagger")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Cloak and Dagger")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox12.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox13.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Throw a dagger that Cripples nearby foes and returns to you." & vbCrLf & "Damage: 493" _
                                & vbCrLf & "Crippled(5s):-50% Movement Speed" & vbCrLf & "Combo Finisher: Physical Projectile")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Stab your foe and vanish in Stealth, leaving them Vulnerable." _
                                & vbCrLf & "Damage: 793" & vbCrLf & "Vulnerability(5s):-30 Defense")
            If Mainfrm.ComboBox2.Text = "Sword" Then
                Mainfrm.PictureBox27.Image = My.Resources.Flanking_Strike
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Flanking Strike")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Evade and stab your foe in the back twice." _
                                & vbCrLf & "Damage: 370" & vbCrLf & "Second strike damage: 739")
            ElseIf Mainfrm.ComboBox2.Text = "Dagger" Then
                Mainfrm.PictureBox27.Image = My.Resources.Death_Blossom
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Death Blossom")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Do an Evasive attack over your opponent, striking nearby enemies three times. Each hit causes Bleeding." _
                                & vbCrLf & "Damage: 444" & vbCrLf & "Bleeding(10s): -1,440 damage over time" & vbCrLf & "Combo Finisher: Whirl")
            ElseIf Mainfrm.ComboBox2.Text = "Pistol" Then
                Mainfrm.PictureBox27.Image = My.Resources.Shadow_Strike
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Shadow Strike")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Stab your foe, then shadowstep away and shoot them." _
                                & vbCrLf & "Damage: 148" & vbCrLf & "Shot Damage damage: 493")
            End If
        ElseIf Mainfrm.Label9.Text = "t" And Mainfrm.ComboBox4.Text = "Pistol" Then
            Mainfrm.PictureBox35.Visible = False
            Mainfrm.PictureBox26.Image = My.Resources.Black_Powder
            Mainfrm.PictureBox25.Image = My.Resources.Head_Shot
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox26, "Black Powder")
            Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox25, "Head Shot")
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox26, Mainfrm.PictureBox26.Image)
            Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox25, Mainfrm.PictureBox25.Image)
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox26, "Throw a dagger that Cripples nearby foes and returns to you." & vbCrLf & "Damage: 493" _
                                & vbCrLf & "Crippled(5s):-50% Movement Speed" & vbCrLf & "Combo Finisher: Physical Projectile")
            Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox25, "Stab your foe and vanish in Stealth, leaving them Vulnerable." _
                                & vbCrLf & "Damage: 793" & vbCrLf & "Vulnerability(5s):-30 Defense")
            If Mainfrm.ComboBox2.Text = "Sword" Then
                Mainfrm.PictureBox27.Image = My.Resources.Pistol_Whip
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Pistol Whip")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Pistol whip your foe, Stunning them, then slash repeatedly with your sword." _
                                & vbCrLf & "Damage: 1211" & vbCrLf & "Stun:0.5 seconds")
            ElseIf Mainfrm.ComboBox2.Text = "Dagger" Then
                Mainfrm.PictureBox27.Image = My.Resources.Shadow_Shot
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Shadow Shot")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Fire a Blinding shot at your foe and shadowstep to them for a dagger strike." _
                                & vbCrLf & "Blindness(5s):Next outgoing attack misses." & vbCrLf & "Damage: 616" & vbCrLf & "Combo Finisher: Physical Projectile")
            ElseIf Mainfrm.ComboBox2.Text = "Pistol" Then
                Mainfrm.PictureBox27.Image = My.Resources.Unload
                Mainfrm.ToolTip2.SetToolTipTitle(Mainfrm.PictureBox27, "Unload")
                Mainfrm.ToolTip2.SetToolTipImage(Mainfrm.PictureBox27, Mainfrm.PictureBox27.Image)
                Mainfrm.ToolTip2.SetToolTip(Mainfrm.PictureBox27, "Blast your foe repeatedly with both pistols." _
                                & vbCrLf & "Damage: 148" & vbCrLf & "Combo Finisher: Physical Projectile (20% chance)")
            End If
        End If
    End Sub
#End Region
End Class
