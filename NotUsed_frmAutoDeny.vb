Option Strict Off
Option Explicit On
Friend Class NotUsed_frmAutoDeny
    Inherits System.Windows.Forms.Form
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click

        If (chkDel.CheckState = 0) And (chkFile.CheckState = 0) And (chkFolder.CheckState = 0) Then
            MsgBox("You must select at lest one option:" & vbCrLf & vbTab & chkDel.Text & vbCrLf & vbTab & chkFile.Text & vbCrLf & vbTab & chkFolder.Text, MsgBoxStyle.Critical, "AutoMagical Error")
        Else
            SaveSetting(My.Application.Info.Title, "Settings", "AutoDel", Trim(Str(chkDel.CheckState)))
            SaveSetting(My.Application.Info.Title, "Settings", "AutoFiles", Trim(Str(chkFile.CheckState)))
            SaveSetting(My.Application.Info.Title, "Settings", "AutoFolders", Trim(Str(chkFolder.CheckState)))
            SaveSetting(My.Application.Info.Title, "Settings", "AutoSubFolders", Trim(Str(chkSub.CheckState)))
            frmFolders.mnuAutoDeny.Tag = "CHANGED"
            Me.Close()
        End If
    End Sub

    Private Sub frmAutoDeny_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        chkDel.CheckState = Val(GetSetting(My.Application.Info.Title, "Settings", "AutoDel", "1"))
        chkFile.CheckState = Val(GetSetting(My.Application.Info.Title, "Settings", "AutoFiles", "1"))
        chkFolder.CheckState = Val(GetSetting(My.Application.Info.Title, "Settings", "AutoFolders", "1"))
        chkSub.CheckState = Val(GetSetting(My.Application.Info.Title, "Settings", "AutoSubFolders", "1"))
    End Sub
End Class