Option Strict Off
Option Explicit On
Friend Class NotUsed_frmGroupFix
    Inherits System.Windows.Forms.Form
    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdGroup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGroup.Click
        txtGroup.Text = txtName.Text
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        If (txtName.Text = "") Or (txtGroup.Text = "") Then
            MsgBox("Display Name and Group Name cannot be blank", MsgBoxStyle.Critical, "ERROR - " & Me.Text)
            Exit Sub
        End If
        '----------------------------------------------------------
        '--FOLLOWING REMD FOR: need to use .NET Open/Save dialogs
        '----------------------------------------------------------
        'If chkDontAsk.CheckState Then
        '	frmFolders.lstGroupFix(0).Tag = "AUTO"
        '	txtGroup.Text = txtName.Text
        'End If

        'frmFolders.lstGroupFix(0).Items.Add(txtName.Text)
        'frmFolders.lstGroupFix(1).Items.Add(txtDomain.Text & "\" & txtGroup.Text)
        'frmFolders.lstGroupFix(1).Tag = "UPDATED"
        Me.Close()
    End Sub
End Class