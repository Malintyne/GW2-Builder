﻿Public Class About
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

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(Label1, "Last compatible game version: June BWE Update")
        ToolTip1.SetToolTip(Label2, "Close")
        ToolTip1.SetToolTipImage(LinkLabel1, My.Resources.Logo_FA)
        ToolTip1.SetToolTip(LinkLabel1, "Homepage")
        ToolTip1.SetToolTip(LinkLabel2, "Click to view the full license")
        ToolTip1.SetToolTip(LinkLabel3, "Click to view the full license")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://www.falchibianchi.enjin.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://en.wikipedia.org/wiki/MIT_License")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://www.codeproject.com/info/cpol10.aspx")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("http://en.wikipedia.org/wiki/MIT_License")
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Process.Start("http://p.yusukekamiyamane.com/")
    End Sub
End Class