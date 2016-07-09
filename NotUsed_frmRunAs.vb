Option Strict Off
Option Explicit On
Friend Class NotUsed_frmRunAs
    Inherits System.Windows.Forms.Form

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        txtUser.Text = ""
        cmdOK_Click(cmdOK, New System.EventArgs())
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'Dim iError As Object
        Dim sUser As String
        Dim sPass As String
        Dim sDomain As String

        sPass = ""
        sDomain = ""
        sUser = txtUser.Text

        If sUser <> "" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object modEncrypt.Encode(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            sPass = NotUsed_modEncrypt.Encode((txtPassword.Text))
            sDomain = cmbDomain.Text
        End If


        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "RunAs", sUser, sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "PWD", sPass, sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "Domain", sDomain, sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()

        frmFolders.mnuSave.Enabled = True

        If sUser = "" Then
            frmFolders.mnuRunAs.Checked = False
        Else
            frmFolders.mnuRunAs.Checked = True
        End If

        Me.Close()
    End Sub

    Private Sub cmdTest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTest.Click
        cmdTest.Enabled = False
        cmdTest.Text = "Testing... Please Wait."

        If txtUser.Text <> "" Then
            RunAsMe((txtUser.Text), (txtPassword.Text), (cmbDomain.Text), "cmdTestRun")
        Else
            MsgBox("You must enter a Username", MsgBoxStyle.Critical, "PM206 - RunAs Test")
        End If

        cmdTest.Text = "Test"
        cmdTest.Enabled = True
    End Sub

    Private Sub frmRunAs_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sUser As String
        Dim sPass As String
        Dim sDomain As String


        EnumDomains(cmbDomain)

        sPass = ""
        sDomain = ""
        sUser = ""

        'sUser = ReadINI("Extras", "RunAs", sINIFile)
        'If sUser <> "" Then
        '	sPass = ReadINI("Extras", "PWD", sINIFile)
        '	sPass = modEncrypt.DeCode(sPass)
        '	sDomain = ReadINI("Extras", "Domain", sINIFile)
        'End If

        If sDomain = "" Then sDomain = GetSetting(My.Application.Info.Title, "Settings", "Domain", sCurrentDomain)

        txtUser.Text = sUser
        txtPassword.Text = sPass

        On Error Resume Next
        cmbDomain.Text = sDomain
        If Err.Number Then 'default domain does not exits.....force refresh of list
            Err.Clear()
            RefreshDomains()
            EnumDomains(cmbDomain, True)
            cmbDomain.Text = sDomain
            If Err.Number Then
                Err.Clear() 'default domain does not exits after 2nd attempt....give up
                If cmbDomain.Items.Count > 0 Then cmbDomain.SelectedIndex = 0
                MsgBox("ERROR: Domain, " & sDomain & ", Not Found", MsgBoxStyle.Critical)
            End If
        End If
        On Error GoTo 0
    End Sub

    Private Sub txtPassword_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Enter
        If Len(txtPassword.Text) > 0 Then
            txtPassword.SelectionStart = 0
            txtPassword.SelectionLength = Len(txtPassword.Text)
        End If
    End Sub

    Private Sub txtPassword_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles txtPassword.MouseUp
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        'Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        'Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        txtPassword.SelectionLength = 0
    End Sub

    Private Sub txtUser_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtUser.Enter
        If Len(txtUser.Text) > 0 Then
            txtUser.SelectionStart = 0
            txtUser.SelectionLength = Len(txtUser.Text)
        End If
    End Sub

    Private Sub txtUser_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles txtUser.MouseUp
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        'Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
        'Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
        'txtUser.SelectionLength = 0
    End Sub
End Class