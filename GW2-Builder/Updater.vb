Public Class Updater
    Dim http As String = "http://covodimatti.altervista.org/update/update.exe"
    Dim Major As String = Environment.OSVersion.Version.Major.ToString
    Dim Minor As String = Environment.OSVersion.Version.Minor.ToString
    Dim save As String = My.Computer.FileSystem.SpecialDirectories.Temp
    Dim exe As String = save + "\update.exe"

    Public WithEvents download As System.Net.WebClient

    Private Function FormatFileSize(ByVal FileBytes As Long, Optional ByVal DecimalDigits As Integer = 1) As String
        Dim Power As Integer = Math.Floor(Math.Log(FileBytes, 1024))
        Return Format(FileBytes / (1024 ^ Power), "#." & StrDup(Math.Max(DecimalDigits, 0), "0")) & " " _
            & New String() {"bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}(Power)
    End Function

    Public Sub InitDownload()
        'Initiates the download
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 100
        download = New System.Net.WebClient
        AddHandler download.DownloadFileCompleted, AddressOf download_DownloadFileCompleted
        AddHandler download.DownloadProgressChanged, AddressOf download_DownloadProgressChanged
        If Major + "." + Minor = "6.1" Then
            download.DownloadFileAsync(New Uri(http), exe)
        ElseIf Major + "." + Minor = "6.0" Then
            download.DownloadFileAsync(New Uri(http), exe)
        Else
            download.DownloadFileAsync(New Uri(http), exe)
        End If
    End Sub

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.character_builder_updater_background
        Label1.BackColor = Color.Transparent
        If System.IO.File.Exists(exe) = True Then
            System.IO.File.Delete(exe)
        End If
        InitDownload()
    End Sub

    Private Sub Updater_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then download.CancelAsync()
        If MsgBoxResult.Ok Then Me.Close()
    End Sub

    Public Sub download_DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        'Sets the progress on the progress bar
        Label1.Text = FormatFileSize(e.BytesReceived, 1) & " recieved of " & FormatFileSize(e.TotalBytesToReceive, 1)
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub download_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles download.DownloadFileCompleted
        ' File download completed
        If e.Cancelled Then
            Label1.Text = "Download cancelled"
            MsgBox("The download was cancelled before completion.", MsgBoxStyle.OkOnly, "Download Cancelled")
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show(e.Error.ToString(), "Download Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Download completed")
            Process.Start(exe)
            Application.Exit()
        End If
    End Sub
End Class