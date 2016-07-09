Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class NotUsed_frmOUs
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
        'Enumerates all OUs
        On Error Resume Next
        Dim oCont As ActiveDs.IADs
        Dim oObject As ActiveDs.IADs
        Dim sName As String

        Dim sKey As String
        Dim sParent As String
        Dim nNode As System.Windows.Forms.TreeNode

        Dim i As Short


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
            tvGroups.CheckBoxes = False
            ' tvGroups.SingleSel = True
            tvGroups.HideSelection = False
            tvGroups.ImageList = ImageList1
        End If


        oCont = GetObject(sDomain)
        'UPGRADE_WARNING: Couldn't resolve default property of object oCont.Filter. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Array has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        oCont.Filter = New Object() {"organizationalUnit", "container", "builtinDomain"}

        'For	Each oObject In oCont
        '	Select Case oObject.Class
        '		Case "organizationalUnit", "container", "builtinDomain"
        '			sName = oObject.Name
        '			sParent = oObject.Parent

        '			i = InStr(1, sName, "=", CompareMethod.Text)
        '			If i > 0 Then sName = VB.Right(sName, Len(sName) - i)

        '			If sName <> "System" Then
        '				sKey = oObject.ADsPath

        '				If bRefresh Then
        '					nNode = tvGroups.Nodes.Add(sKey, sName, 1, 1)
        '				Else
        '					'UPGRADE_WARNING: Add method behavior has changed Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DBD08912-7C17-401D-9BE9-BA85E7772B99"'
        '					nNode = tvGroups.Nodes.Find(sParent, True)(0).Nodes.Add(sKey, sName, 1, 1)
        '				End If
        '				'UPGRADE_ISSUE: MSComctlLib.Node property nNode.Selected was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '				If UCase(sKey) = UCase(tvGroups.Tag) Then nNode.Selected = True
        '				'UPGRADE_NOTE: Object nNode may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        '				nNode = Nothing
        '			End If

        '			EnumList(sKey, sShortDomain, False)
        '	End Select
        '	System.Windows.Forms.Application.DoEvents()
        'Next oObject

        If bRefresh Then
            picRefresh.Visible = False
            tvGroups.Visible = True
            DisableForm(True)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            'UPGRADE_WARNING: Lower bound of collection tvGroups.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            'UPGRADE_ISSUE: MSComctlLib.Node property tvGroups.Nodes.Selected was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            If (tvGroups.Tag = "") And (tvGroups.Nodes.Count > 0) Then
                'tvGroups.Nodes.Item(0).Selected = True
                tvGroups.SelectedNode = tvGroups.Nodes.Item(0)
            End If
        End If

        If tvGroups.Visible Then tvGroups.Focus()
    End Sub

    Private Sub DisableForm(ByRef bEnabled As Boolean)
        cmbDomain.Enabled = bEnabled
        tvGroups.Enabled = bEnabled
        cmdCancel.Enabled = bEnabled
        cmdOK.Enabled = bEnabled
    End Sub

    Private Sub frmOUs_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        ' Dim sComputer As String
        'Dim clsComputer As New ComputerInfo

        ' sComputer = clsComputer.ComputerName
        ' Set clsComputer = Nothing
        ' If sComputer <> "" Then cmbDomain.AddItem sComputer

        tvGroups.Tag = "LDAP://" & NotUsed_frmAutoGroup.txtOU.Text
        bFirstRun = True
    End Sub

    'UPGRADE_WARNING: Form event frmOUs.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmOUs_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Dim sDomain As String
        Dim sShowUsers As String
        Dim sShowOU As String
        If bFirstRun Then

            bLoading = True

            EnumDomains(cmbDomain)

            sDomain = NotUsed_frmAutoGroup.txtOU.Text
            If sDomain <> "" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object GetShortName(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                sDomain = GetShortName(sDomain)
            Else
                sDomain = GetSetting(My.Application.Info.Title, "Settings", "Domain", sCurrentDomain)
            End If

            cmbDomain.Text = sDomain

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

            bLoading = False
            bFirstRun = False
            cmbDomain_SelectedIndexChanged(cmbDomain, New System.EventArgs())
        Else
            'UPGRADE_WARNING: Lower bound of collection tvGroups.Nodes has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
            'UPGRADE_ISSUE: MSComctlLib.Node property tvGroups.Nodes.Selected was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
            If tvGroups.Nodes.Count > 0 Then
                'tvGroups.Nodes.Item(0).Selected = True
                tvGroups.SelectedNode = tvGroups.Nodes.Item(0)
            End If
        End If
    End Sub

    Private Sub tvGroups_AfterCollapse(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles tvGroups.AfterCollapse
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        Node.ImageIndex = 1
        'UPGRADE_WARNING: MSComctlLib.Node property Node.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        'Node.SelectedImageIndex = Node.ImageKey
    End Sub

    Private Sub tvGroups_AfterExpand(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.TreeViewEventArgs) Handles tvGroups.AfterExpand
        Dim Node As System.Windows.Forms.TreeNode = eventArgs.Node
        Node.ImageIndex = 1
        'UPGRADE_WARNING: MSComctlLib.Node property Node.Image has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        'Node.SelectedImageIndex = Node.ImageKey
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

    Private Sub cmdCancel_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
        Dim sOU As String

        sOU = tvGroups.SelectedNode.Name
        If UCase(VB.Left(sOU, 7)) = "LDAP://" Then sOU = VB.Right(sOU, Len(sOU) - 7)
        NotUsed_frmAutoGroup.txtOU.Text = sOU
        Me.Close()
    End Sub
End Class