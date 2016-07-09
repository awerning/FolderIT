Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class NotUsed_frmGroups
    Inherits System.Windows.Forms.Form
    Dim bFirstRun As Boolean
    Dim bLoading As Boolean

    Private Sub picRefresh_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picRefresh.Paint
        Dim TextFont As New System.Drawing.Font("Arial", 10, FontStyle.Regular)
        Dim TextBrush As New System.Drawing.SolidBrush(System.Drawing.Color.RoyalBlue)
        e.Graphics.DrawString("Refreshing List.....", TextFont, TextBrush, 10, 10)
        e.Graphics.DrawString("Please Wait.", TextFont, TextBrush, 10, 20)
        TextFont.Dispose()
        TextBrush.Dispose()
    End Sub

    Private Sub EnumList(ByRef sDomain As String, ByRef sShortDomain As String, ByRef bRefresh As Boolean)
        'Enumerates all Groups/Users
        On Error Resume Next
        Dim oCont As ActiveDs.IADs
        Dim oObject As ActiveDs.IADs
        Dim sName As String
        Dim sObjectName As String
        Dim iOU As Short
        Dim iUser As Short
        Dim iGroup As Short

        Dim bUsers As Boolean
        Dim sKey As String
        Dim sParent As String

        Dim nGroup As System.Windows.Forms.TreeNode
        Dim bSecurityGroup As Boolean

        Dim sFilter As String
        Dim aFilter() As String

        bUsers = False
        If Not mnuUsers.Checked Then bUsers = True

        If bRefresh Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            DisableForm(False)
            ''UPGRADE_ISSUE: PictureBox method picRefresh.Cls was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'picRefresh.Cls()
            ''UPGRADE_ISSUE: PictureBox method picRefresh.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'picRefresh.Print("Refreshing List.....")
            ''UPGRADE_ISSUE: PictureBox method picRefresh.Print was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            'picRefresh.Print("Please Wait.")
            picRefresh.Visible = True
            tvGroups.Visible = False
            tvGroups.Nodes.Clear()
            tvGroups.CheckBoxes = True
            tvGroups.ImageList = ImageList1
            tvGroups.ImageIndex = 1
            tvGroups.SelectedImageIndex = 2
            SaveSetting(My.Application.Info.Title, "Settings", "Domain", sShortDomain)
        End If


        'OU/User Picture to select from Image list
        iOU = 1
        iUser = 4
        iGroup = 3

        oCont = GetObject(sDomain)
        sFilter = ""
        If Not mnuHide.Checked Then sFilter = "organizationalUnit,container,builtinDomain"
        If bUsers Then
            If sFilter <> "" Then sFilter = sFilter & ","
            sFilter = sFilter & "user"
        End If

        If sFilter <> "" Then sFilter = sFilter & ","
        sFilter = sFilter & "group"
        aFilter = Split(sFilter, ",", -1, CompareMethod.Text)

        'UPGRADE_WARNING: Couldn't resolve default property of object oCont.Filter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'oCont.Filter = VB6.CopyArray(aFilter)

        'For Each oObject In oCont
        '    sObjectName = oObject.Name
        '    If sDomain <> "WinNT://127.0.0.1" Then
        '        sName = VB.Right(sObjectName, Len(sObjectName) - 3)
        '    Else
        '        sName = sObjectName
        '    End If
        '    sParent = oObject.Parent
        '    Select Case oObject.Class
        '        Case "organizationalUnit", "container", "builtinDomain"

        '            If sName <> "System" Then
        '                sKey = oObject.ADsPath

        '                If bRefresh Then
        '                    'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                    If Not mnuHide.Checked Then tvGroups.Nodes.Add(sKey, sName, iOU)
        '                Else
        '                    'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
        '                    'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                    If Not mnuHide.Checked Then tvGroups.Nodes.Find(sParent, True)(0).Nodes.Add(sKey, sName, iOU)
        '                End If
        '            End If

        '            EnumList(sKey, sShortDomain, False)

        '        Case "group", "Group"
        '            bSecurityGroup = True
        '            If sDomain <> "WinNT://127.0.0.1" Then
        '                'UPGRADE_WARNING: Couldn't resolve default property of object oObject.Get(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                sKey = sShortDomain & "\" & oObject.Get("sAMAccountName")
        '                'UPGRADE_WARNING: Couldn't resolve default property of object oObject.Get(groupType). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                If oObject.Get("groupType") > 0 Then bSecurityGroup = False
        '            Else
        '                sKey = sShortDomain & "\" & sName
        '            End If

        '            If bSecurityGroup Then
        '                If bRefresh Then
        '                    'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                    tvGroups.Nodes.Add(sKey, sName, iGroup)
        '                Else
        '                    If UCase(VB.Left(sParent, 18)) = "LDAP://CN=BUILTIN," Then sKey = "BUILTIN\" & sName
        '                    If mnuHide.Checked Then
        '                        'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                        tvGroups.Nodes.Add(sKey, sName, iGroup)
        '                    Else
        '                        'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
        '                        'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                        tvGroups.Nodes.Find(sParent, True)(0).Nodes.Add(sKey, sName, iGroup)
        '                    End If
        '                End If
        '            End If

        '        Case "user", "User"
        '            If bUsers Then
        '                If sDomain <> "WinNT://127.0.0.1" Then
        '                    'UPGRADE_WARNING: Couldn't resolve default property of object oObject.Get(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                    sKey = sShortDomain & "\" & oObject.Get("sAMAccountName")
        '                Else
        '                    sKey = sShortDomain & "\" & sName
        '                End If

        '                If bRefresh Then
        '                    'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                    tvGroups.Nodes.Add(sKey, sName, iUser)
        '                Else
        '                    If mnuHide.Checked Then
        '                        'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                        tvGroups.Nodes.Add(sKey, sName, iUser)
        '                    Else
        '                        'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
        '                        'UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        '                        tvGroups.Nodes.Find(sParent, True)(0).Nodes.Add(sKey, sName, iUser)
        '                    End If
        '                End If
        '            End If
        '    End Select
        '    System.Windows.Forms.Application.DoEvents()
        'Next oObject

        ''Add Unique Groups
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\ANONYMOUS LOGON", "ANONYMOUS LOGON", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\Authenticated Users", "Authenticated Users", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\BATCH", "BATCH", iGroup)
        '' tvGroups.Nodes.Add , , "CREATOR Group", "CREATOR GROUP", iGroup, iGroup
        '' tvGroups.Nodes.Add , , "CREATOR Owner", "CREATOR OWNER", iGroup, iGroup
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\DIALUP", "DIALUP", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\ENTERPRISE DOMAIN CONTROLLERS", "ENTERPRISE DOMAIN CONTROLLERS", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("Everyone", "Everyone", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\INTERACTIVE", "INTERACTIVE", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("S-1-5-19", "LOCAL SERVICE", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\NETWORK", "NETWORK", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("S-1-5-20", "NETWORK SERVICE", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\PROXY", "PROXY", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("S-1-5-14", "REMOTE INTERACTIVE LOGON", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\RESTRICTED", "RESTRICTED", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\SELF", "SELF", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\SERVICE", "SERVICE", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\System", "SYSTEM", iGroup)
        ''UPGRADE_WARNING: SelectedImage property was not upgraded Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="14981025-6E0D-4DD3-82F8-AD5B7837D779"'
        'tvGroups.Nodes.Add("NT AUTHORITY\TERMINAL SERVER USER", "TERMINAL SERVER USER", iGroup)


        If bRefresh Then
            tvGroups.Visible = True
            picRefresh.Visible = False
            DisableForm(True)
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If

    End Sub

    Private Sub AddSelection()
        'Dim iError As Short
        'Addes ACL to File
        Dim i As Short
        Dim sKey As String
        Dim aKey() As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DisableForm(False)

        If tvGroups.Nodes.Count >= 0 Then
            For i = 0 To tvGroups.Nodes.Count - 1
                If tvGroups.Nodes.Item(i).Checked Then
                    'Save ACE to File
                    'Might Want to change Default Permisions of Read/Execute
                    'TODO Check if in File already and if inherited
                    sKey = Replace(tvGroups.Nodes.Item(i).Name, "/", "\", 1, -1, CompareMethod.Text)
                    aKey = Split(sKey, "\", -1, CompareMethod.Text)
                    sKey = aKey(LBound(aKey)) & "\" & aKey(UBound(aKey))

                    ''UPGRADE_WARNING: MSComctlLib.Node property tvGroups.Nodes.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
                    ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'iError = WriteINI(tvGroups.Tag, sKey, tvGroups.Nodes.Item(i).Text & "|||" & Str(tvGroups.Nodes.Item(i).ImageKey) & "|||0|0|0|0|0|0|131241||0|0|0|0|0|0|0", sINIFile)
                    ''UPGRADE_WARNING: Couldn't resolve default property of object iError. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'If iError = 0 Then INIErrorMsg()
                    cmdOK.Tag = "CHANGED"
                End If
                System.Windows.Forms.Application.DoEvents()
            Next
        End If

        DisableForm(True)
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Function AddAdvSecurity() As String
        'Addes ACL to File
        Dim i As Short
        Dim sSelections As String

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DisableForm(False)
        sSelections = ""

        If tvGroups.Nodes.Count > 0 Then
            For i = 1 To tvGroups.Nodes.Count
                'UPGRADE_WARNING: Lower bound of collection tvGroups.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If tvGroups.Nodes.Item(i).Checked Then
                    'Might Want to change Default Permisions of Read/Execute
                    'TODO Check if in File already and if inherited
                    If sSelections <> "" Then sSelections = sSelections & ";;;"
                    'UPGRADE_WARNING: Lower bound of collection tvGroups.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                    'UPGRADE_WARNING: MSComctlLib.Node property tvGroups.Nodes.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
                    sSelections = sSelections & tvGroups.Nodes.Item(i).Name & "=" & tvGroups.Nodes.Item(i).Text & "|||" & Str(tvGroups.Nodes.Item(i).ImageKey) & "|||"
                    cmdOK.Tag = "CHANGED"
                End If
                System.Windows.Forms.Application.DoEvents()
            Next
        End If

        DisableForm(True)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        AddAdvSecurity = sSelections
    End Function

    Private Sub ClearSelection()
        'Clear Selections in TV
        Dim i As Short

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        DisableForm(False)

        If tvGroups.Nodes.Count > 0 Then
            For i = 1 To tvGroups.Nodes.Count
                'UPGRADE_WARNING: Lower bound of collection tvGroups.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
                If tvGroups.Nodes.Item(i).Checked Then tvGroups.Nodes.Item(i).Checked = False
                System.Windows.Forms.Application.DoEvents()
            Next
        End If

        DisableForm(True)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub DisableForm(ByRef bEnabled As Boolean)
        cmbDomain.Enabled = bEnabled
        tvGroups.Enabled = bEnabled
        cmdCancel.Enabled = bEnabled
        cmdOK.Enabled = bEnabled
        mnuFile.Enabled = bEnabled
    End Sub




    Private Sub frmGroups_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' Dim sComputer As String
        'Dim clsComputer As New ComputerInfo

        ' sComputer = clsComputer.ComputerName
        ' Set clsComputer = Nothing
        ' If sComputer <> "" Then cmbDomain.AddItem sComputer

        bFirstRun = True
    End Sub

    'UPGRADE_WARNING: Form event frmGroups.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmGroups_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Dim sDomain As String
        Dim sShowUsers As String
        Dim sShowOU As String
        If bFirstRun Then
            bLoading = True
            sShowOU = GetSetting(My.Application.Info.Title, "Settings", "ShowOU", "0")
            If sShowOU = "0" Then mnuHide.Checked = True

            EnumDomains(cmbDomain)

            sDomain = GetSetting(My.Application.Info.Title, "Settings", "Domain", sCurrentDomain)
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
                End If
            End If
            On Error GoTo 0


            sShowUsers = GetSetting(My.Application.Info.Title, "Settings", "ShowUsers", "0")
            If sShowUsers = "0" Then mnuUsers.Checked = True

            bLoading = False
            bFirstRun = False
            cmbDomain_SelectedIndexChanged(cmbDomain, New System.EventArgs())
        Else
            ClearSelection()
        End If
    End Sub

    Private Sub frmGroups_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'If Me.Visible Then Cancel = 1
        Me.Visible = False
    End Sub

    Public Sub mnuHide_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuHide.Click
        If mnuHide.Checked Then
            'uncheck
            mnuHide.Checked = False
            SaveSetting(My.Application.Info.Title, "Settings", "ShowOU", "1")
        Else
            'check
            mnuHide.Checked = True
            SaveSetting(My.Application.Info.Title, "Settings", "ShowOU", "0")
        End If

        'refresh
        Dim sDomain As String
        sDomain = cmbDomain.Text
        'UPGRADE_WARNING: Couldn't resolve default property of object GetLDAPName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        EnumList(GetLDAPName(sDomain), sDomain, True)

    End Sub

    Public Sub mnuRefresh_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuRefresh.Click
        'UPGRADE_WARNING: Couldn't resolve default property of object GetLDAPName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        EnumList(GetLDAPName((cmbDomain.Tag)), (cmbDomain.Tag), True)
    End Sub

    Private Sub tvGroups_AfterCollapse(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles tvGroups.AfterCollapse
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        'UPGRADE_WARNING: MSComctlLib.Node property Node.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        Node.ImageKey = Node.ImageKey - 1
        'UPGRADE_WARNING: MSComctlLib.Node property Node.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        Node.SelectedImageIndex = Node.ImageKey
    End Sub

    Private Sub tvGroups_AfterExpand(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles tvGroups.AfterExpand
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        'UPGRADE_WARNING: MSComctlLib.Node property Node.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        Node.ImageKey = Node.ImageKey + 1
        'UPGRADE_WARNING: MSComctlLib.Node property Node.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        Node.SelectedImageIndex = Node.ImageKey
    End Sub

    'UPGRADE_WARNING: Event cmbDomain.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmbDomain_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDomain.SelectedIndexChanged
        If bLoading Then Exit Sub
        Dim sDomain As String
        If cmbDomain.Text <> cmbDomain.Tag Then
            sDomain = cmbDomain.Text
            cmbDomain.Tag = sDomain
            'UPGRADE_WARNING: Couldn't resolve default property of object GetLDAPName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            EnumList(GetLDAPName(sDomain), sDomain, True)
        End If
    End Sub

    Public Sub mnuUsers_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUsers.Click
        Dim sDomain As String

        If mnuUsers.Checked Then
            mnuUsers.Checked = False
            SaveSetting(My.Application.Info.Title, "Settings", "ShowUsers", "1")
        Else
            mnuUsers.Checked = True
            SaveSetting(My.Application.Info.Title, "Settings", "ShowUsers", "0")
        End If

        sDomain = cmbDomain.Text

        'UPGRADE_WARNING: Couldn't resolve default property of object GetLDAPName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        EnumList(GetLDAPName(sDomain), sDomain, True)
    End Sub

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        'Unload Me
        Me.Visible = False
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Select Case Me.Tag
            Case "FOLDERS" 'called from frmFolders
                AddSelection()
                If cmdOK.Tag = "CHANGED" Then frmFolders.cmdAdd.Tag = cmdOK.Tag
            Case "ADVSECURITY" 'called from frmAdvSecurity
                'frmAdvSecurity.txtParent.Tag = AddAdvSecurity
        End Select

        'Unload Me
        Me.Visible = False
    End Sub

    Private Sub tvGroups_AfterCheck(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles tvGroups.AfterCheck
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        'On Checked, updates child nodes to be selected or not
        TVSelection(Node, (Node.Checked))
        TVParent(Node)
    End Sub

    Private Sub TVSelection(ByRef X As System.Windows.Forms.TreeNode, ByRef bCheck As Boolean)
        ' Selects or UNSelects all child objects
        Dim Y As System.Windows.Forms.TreeNode
        Dim i As Short
        Dim num As Short

        i = X.GetNodeCount(False)
        X.Checked = bCheck
        If X.GetNodeCount(False) > 0 Then
            'If X.Checked Then
            '	X.NodeFont = VB6.FontChangeBold(X.NodeFont, True)
            'Else
            '	X.NodeFont = VB6.FontChangeBold(X.NodeFont, False)
            'End If
            Y = X.FirstNode
            For num = 1 To i
                If num > 1 Then Y = Y.NextNode
                'UPGRADE_WARNING: MSComctlLib.Node property Y.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
                If (Y.ImageKey = 1) Or (Y.ImageKey = 2) Then
                    TVSelection(Y, bCheck)
                Else
                    Y.Checked = bCheck
                End If
            Next
            'UPGRADE_NOTE: Object Y may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Y = Nothing
        End If
    End Sub

    Private Sub TVParent(ByRef X As System.Windows.Forms.TreeNode)
        ' If all child objects are selected, Parent object is also selected
        ' If not all child objects are selected, parent object is not selected
        On Error Resume Next
        Dim Y As System.Windows.Forms.TreeNode
        Dim sParent As String

        sParent = X.Parent.Text
        If sParent <> "" Then
            Y = X.Parent
            'If Not X.Checked Then
            '	Y.Checked = False
            '	If TVOneSel(Y) Then
            '		Y.NodeFont = VB6.FontChangeBold(Y.NodeFont, True)
            '	Else
            '		Y.NodeFont = VB6.FontChangeBold(Y.NodeFont, False)
            '	End If
            'Else
            '	Y.Checked = TVAllSel(Y)
            '	Y.NodeFont = VB6.FontChangeBold(Y.NodeFont, True)
            'End If

            sParent = Y.Parent.Text
            If Err.Number Then
                Err.Clear()
            Else
                If sParent <> "" Then TVParent(Y)
            End If

            'UPGRADE_NOTE: Object Y may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Y = Nothing
        End If
    End Sub

    Private Function TVAllSel(ByRef X As System.Windows.Forms.TreeNode) As Boolean
        'Returns TRUE if all child nodes are selected
        Dim Y As System.Windows.Forms.TreeNode
        Dim i As Short
        Dim num As Short
        Dim bSel As Boolean

        bSel = True
        i = X.GetNodeCount(False)
        If X.GetNodeCount(False) > 0 Then
            Y = X.FirstNode
            For num = 1 To i
                If num > 1 Then Y = Y.NextNode
                If Not Y.Checked Then
                    bSel = False
                    Exit For
                End If
            Next
            'UPGRADE_NOTE: Object Y may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Y = Nothing
        End If

        TVAllSel = bSel
    End Function

    Private Function TVOneSel(ByRef X As System.Windows.Forms.TreeNode) As Boolean
        'Returns TRUE if one child node is selected
        Dim Y As System.Windows.Forms.TreeNode
        Dim i As Short
        Dim num As Short
        Dim bSel As Boolean

        bSel = False
        i = X.GetNodeCount(False)
        If X.GetNodeCount(False) > 0 Then
            Y = X.FirstNode
            For num = 1 To i
                If num > 1 Then Y = Y.NextNode
                If Y.Checked Then
                    bSel = True
                    Exit For
                End If
            Next
            'UPGRADE_NOTE: Object Y may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
            Y = Nothing
        End If

        TVOneSel = bSel
    End Function

End Class