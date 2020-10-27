Public Class FFDx0MApp

    Dim FFDx2SAVEDxDLxURL As String

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
            'success
            FFDx2SAVEDxDLxURL = FFDx0DOWNLOADURL.Text
            FFDx0DOWNLOADURL.BorderColor = Color.Orange
        End If
    End Sub


    Private Sub FFDx0MApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'use local x0 var's
        FFDx1FORMSETUP()
    End Sub

    Private Sub FFDx0CREATEDOWNLOAD_Click(sender As Object, e As EventArgs) Handles FFDx0CREATEDOWNLOAD.Click
        FFDx1CHECKDOWNLOADURL()
    End Sub
End Class