Imports System.Net
Imports System.Text
Imports System.IO

Public Class FFDx0MApp

    Dim FFDx2SAVEDxDLxURL As String
    Dim FFDx2WEBCLIENT As WebClient

    Sub FFDx1FORMSETUP()
        'use x1 var's
        FFDx0DRAG.SetDrag(FFDx0PANELCONTROLS)
        FFDx0SHADOW.SetShadowForm(Me)
    End Sub

    Sub FFDx1CHECKDOWNLOADURL()
        'use x1 var's
        If FFDx0DOWNLOADURL.Text = Nothing Then
            'error{i}
            FFDx0DOWNLOADURL.BorderColor = Color.Red
        Else
            'success
            FFDx2SAVEDxDLxURL = FFDx0DOWNLOADURL.Text
            FFDx0DOWNLOADURL.BorderColor = Color.Orange
        End If

        If FFDx0DOWNLOADURL.Text.Contains("https, http") Then
            'error{i}
            FFDx2SAVEDxDLxURL = ""
            FFDx0DOWNLOADURL.BorderColor = Color.Red
        Else
            FFDx0DODOWNLOAD()
            'success
            FFDx2SAVEDxDLxURL = FFDx0DOWNLOADURL.Text
            FFDx0DOWNLOADURL.BorderColor = Color.Orange
        End If
    End Sub

    Sub FFDx0DODOWNLOAD()
        If FFDx0DOWNLOADURL.Text.Contains("exe") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".exe"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("zip") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".zip"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("rar") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".rar"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("dll") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".dll"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("html") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".html"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("png") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".png"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("jpg") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".jpg"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("gif") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".gif"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("wmv") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".wmv"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("mp4") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".mp4"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("mp3") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".mp3"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("wav") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".wav"
        ElseIf FFDx0DOWNLOADURL.Text.Contains("ogg") Then
            FFDx0DOWNLOADNAME.Text = FFDx0DOWNLOADNAME.Text & ".ogg"
        End If

        AddHandler FFDx2WEBCLIENT.DownloadProgressChanged, AddressOf ProgChanged
        FFDx2WEBCLIENT.DownloadFileAsync(New Uri(FFDx0DOWNLOADURL.Text), FFDx0DOWNLOADPATH.Text & "\" & FFDx0DOWNLOADNAME.Text)
    End Sub

    Private Sub ProgChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        If FFDx0DOWNLOADPROGRESS.Value = 100 Then
            FDDx0DONETITLE.Visible = True
            Process.Start(FFDx0DOWNLOADPATH.Text)
        End If

        FFDx0DOWNLOADPROGRESS.Value = e.ProgressPercentage
        FFDx0DOWNLOADLABEL.Text = String.Format("{0} MB's / {1} MB's", (e.BytesReceived / 1024D / 1024D).ToString("0.00"), (e.TotalBytesToReceive / 1024D / 1024D).ToString("0.00"))
    End Sub


    Private Sub FFDx0MApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'use local x0 var's
        FFDx2WEBCLIENT = New WebClient()
        FFDx0LOCALDLPATH.SelectedPath = My.Computer.FileSystem.SpecialDirectories.Desktop
        FFDx1FORMSETUP()
    End Sub

    Private Sub FFDx0CREATEDOWNLOAD_Click(sender As Object, e As EventArgs) Handles FFDx0CREATEDOWNLOAD.Click
        FDDx0DONETITLE.Visible = False
        FFDx1CHECKDOWNLOADURL()
    End Sub

    Private Sub FFD0xDOWNLOADPATH_Click(sender As Object, e As EventArgs) Handles FFDx0DOWNLOADPATH.Click
        If FFDx0LOCALDLPATH.ShowDialog() = DialogResult.OK Then
            FFDx0DOWNLOADPATH.Text = FFDx0LOCALDLPATH.SelectedPath
        End If
    End Sub
End Class