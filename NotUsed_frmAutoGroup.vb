Option Strict Off
Option Explicit On
Friend Class NotUsed_frmAutoGroup
    Inherits System.Windows.Forms.Form
    Private Sub cmdBrowse_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBrowse.Click
        NotUsed_frmOUs.ShowDialog(Me)
    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClear.Click
        txtSuffix.Text = ""
        cmdOK_Click(cmdOK, New System.EventArgs())
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        'Dim iError As Object
        Dim sSuffix As String
        Dim sADPath As String
        Dim sType As String
        Dim iPrompt As Short
        Dim iAutoAdd As Short

        sSuffix = txtSuffix.Text
        sADPath = ""
        sType = ""
        iPrompt = 0
        iAutoAdd = 1


        If sSuffix <> "" Then
            sADPath = txtOU.Text
            sType = cmbType.Text
            iPrompt = chkPrefix.CheckState
            iAutoAdd = chkAddGroup.CheckState
        End If


        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "Suffix", sSuffix, sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "OU", sADPath, sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "Security", sType, sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "Prefix", Str(iPrompt), sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'iError = WriteINI("Extras", "AutoAdd", Str(iAutoAdd), sINIFile)
        ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If iError = 0 Then INIErrorMsg()

        frmFolders.mnuSave.Enabled = True

        If sSuffix <> "" Then
            frmFolders.mnuAutoGroup.Checked = True
        Else
            frmFolders.mnuAutoGroup.Checked = False
        End If

        Me.Close()
    End Sub

    Private Sub frmAutoGroup_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim sSuffix As String
        Dim sADPath As String
        Dim sType As String
        Dim iPrompt As Short
        Dim iAutoAdd As Short

        sSuffix = ""
        sADPath = ""
        sType = "Domain local"
        iPrompt = 0
        iAutoAdd = 1


        'sSuffix = ReadINI("Extras", "Suffix", sINIFile)
        'If sSuffix <> "" Then
        '	sADPath = ReadINI("Extras", "OU", sINIFile)
        '	sType = ReadINI("Extras", "Security", sINIFile)
        '	iPrompt = Val(ReadINI("Extras", "Prefix", sINIFile))
        '	iAutoAdd = Val(ReadINI("Extras", "AutoAdd", sINIFile))
        'End If

        txtSuffix.Text = sSuffix
        txtOU.Text = sADPath
        cmbType.Text = sType
        chkPrefix.CheckState = iPrompt
        chkAddGroup.CheckState = iAutoAdd
    End Sub
End Class