Imports System.Security.AccessControl
Imports System.Security.Principal
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO

Friend Class frmFolders
    Inherits System.Windows.Forms.Form

    Const AdminGroups As String = "Domain Admins" 'Seperated by semi-colon

    Dim bEditMode As Boolean
    Dim previousSelectedNode As TreeNode

    Dim bFirstRun As Boolean
    Dim iKeys As Short
    Dim bUpdateRights As Boolean
    Dim bUpdateInherit As Boolean
    Dim bReset As Boolean
    Dim bReset2 As Boolean
    Dim bUnload As Boolean
    Dim bAdmin As Boolean
    Dim bStart As Boolean
    Dim bSkipEventHandlers As Boolean = False

    Private Sub frmFolders_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim pfsFile As IniReader = New IniReader("E:\Aarons Stuff\.NET Development\_Projects\CodeTest\FolderTest\test.pfs")

        SplitContainer1.Panel2Collapsed = True
        SplitContainer1.Panel1MinSize = 0
        SplitContainer1.Panel2MinSize = 0
        Me.MinimumSize = New Size(381, 562)
        Me.Width -= 634

        btnMain.Text = "Create Folders"

        tvFolders.HideSelection = False

        'temp code so that we are always in edit mode
        mnuEditMode_Click(Nothing, Nothing)

    End Sub

    Private Sub mnuEditMode_Click(sender As System.Object, e As System.EventArgs) Handles mnuEditMode.Click
        If Not bEditMode Then

            bEditMode = True

            'rename main button
            btnMain.Text = "Import Structure"

            AddHandler _chkAllowSum_FC.MouseClick, AddressOf AllowSum_CheckChanged
            AddHandler _chkAllowSum_MO.MouseClick, AddressOf AllowSum_CheckChanged
            AddHandler _chkAllowSum_RAE.MouseClick, AddressOf AllowSum_CheckChanged
            AddHandler _chkAllowSum_LI.MouseClick, AddressOf AllowSum_CheckChanged
            AddHandler _chkAllowSum_RE.MouseClick, AddressOf AllowSum_CheckChanged
            AddHandler _chkAllowSum_WR.MouseClick, AddressOf AllowSum_CheckChanged
            AddHandler _chkAllowSum_SP.MouseClick, AddressOf AllowSum_CheckChanged

            AddHandler _chkDenySum_FC.MouseClick, AddressOf DenySum_CheckChanged
            AddHandler _chkDenySum_MO.MouseClick, AddressOf DenySum_CheckChanged
            AddHandler _chkDenySum_RAE.MouseClick, AddressOf DenySum_CheckChanged
            AddHandler _chkDenySum_LI.MouseClick, AddressOf DenySum_CheckChanged
            AddHandler _chkDenySum_RE.MouseClick, AddressOf DenySum_CheckChanged
            AddHandler _chkDenySum_WR.MouseClick, AddressOf DenySum_CheckChanged
            AddHandler _chkDenySum_SP.MouseClick, AddressOf DenySum_CheckChanged

            AddHandler _chkAllowAdv_FC.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_TR.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_LI.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_RA.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_REA.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_CFI.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_CFO.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_WA.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_WEA.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_DSF.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_DE.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_RP.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_CP.MouseClick, AddressOf AllowAdv_CheckChanged
            AddHandler _chkAllowAdv_TO.MouseClick, AddressOf AllowAdv_CheckChanged

            AddHandler _chkDenyAdv_FC.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_TR.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_LI.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_RA.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_REA.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_CFI.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_CFO.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_WA.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_WEA.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_DSF.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_DE.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_RP.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_CP.MouseClick, AddressOf DenyAdv_CheckChanged
            AddHandler _chkDenyAdv_TO.MouseClick, AddressOf DenyAdv_CheckChanged

            'show right pannel of dialog box
            Me.Width += 634
            Me.MinimumSize = New System.Drawing.Size(1015, 562)
            SplitContainer1.Panel2Collapsed = False
            SplitContainer1.Panel1MinSize = 366
            SplitContainer1.Panel2MinSize = 629
            GroupBox2.Visible = True
            GroupBox3.Visible = True
        End If
    End Sub

    Private Sub btnExitEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnExitEdit.Click
        bEditMode = False
        btnMain.Text = "Create Folders"

        'hide right pannel of dialog box
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        Me.MinimumSize = New Size(381, 562)
        Me.Width -= 634

    End Sub

    Private Sub btnMain_Click(sender As System.Object, e As System.EventArgs) Handles btnMain.Click
        If bEditMode Then

            btnMain.Enabled = False

            LabelProgress.Visible = True
            LabelProgress.Text = "Reading Folder Structure: "
            ProgressBar1.Visible = True
            ProgressBar1.Style = ProgressBarStyle.Marquee

            BackgroundWorker1.RunWorkerAsync(sFolder)

        Else

        End If
    End Sub

    Private Sub tvFolders_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles tvFolders.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim NodeClicked As TreeNode = Me.tvFolders.GetNodeAt(e.X, e.Y)
            Me.tvFolders.SelectedNode = NodeClicked
            ContextMenuStrip1.Show(tvFolders, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub tvFolders_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles tvFolders.AfterSelect
        If Not bSkipEventHandlers Then
            Dim inherit As Boolean = False
            Dim explicit As Boolean = False
            Dim applyTo As permApplyTo
            Dim advFlags As String
            Dim sumFlags As String

            grdRights.Rows.Clear()

            Dim fSecurity As AuthorizationRuleCollection = tvFolders.SelectedNode.Tag.GetAccessRules(True, True, GetType(System.Security.Principal.NTAccount))
            For Each acc As FileSystemAccessRule In fSecurity

                applyTo = getApplyTo(acc)
                advFlags = accRuleToAdvFlags(acc)
                sumFlags = advFlagsToSumFlags(advFlags & "|" & applyTo.ToString)

                If acc.IsInherited = True Then
                    inherit = True
                Else
                    bSkipEventHandlers = True
                    grdRights.Rows.Add(IIf(acc.AccessControlType = AccessControlType.Allow, "Allow", "Deny"), _
                                                  acc.IdentityReference.Value, _
                                                  sumFlagsToSring(sumFlags), _
                                                  applyTo.ToString)
                    bSkipEventHandlers = False
                    grdRights.Rows.Item(grdRights.Rows.Count - 1).Tag = acc
                    explicit = True
                End If
            Next

            If inherit = True Then chkInherit.Checked = True Else chkInherit.Checked = False

            If grdRights.Rows.Count > 0 Then
                If Not grdRights.SelectedRows(0).Tag Is Nothing Then
                    populatePermControls(grdRights.SelectedRows(0).Tag)
                End If
            Else
                enablePermControls(False)
            End If
            previousSelectedNode = tvFolders.SelectedNode
        End If
    End Sub

    Private Sub grdRights_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRights.RowEnter
        If Not bSkipEventHandlers Then
            Dim currentSelectedRow As DataGridViewRow = grdRights.Rows(e.RowIndex)

            If Not currentSelectedRow.Tag Is Nothing Then
                populatePermControls(currentSelectedRow.Tag)
            End If
        End If
    End Sub

    Private Sub grdRights_RowsAdded(sender As Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles grdRights.RowsAdded
        If Not bSkipEventHandlers Then
            updateTviewNode()
        End If
    End Sub

    Private Sub grdRights_RowsRemoved(sender As Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grdRights.RowsRemoved
        If Not bSkipEventHandlers Then
            updateTviewNode()
        End If
    End Sub

    Private Sub updateTviewNode()
        Dim rowCount As Integer = grdRights.Rows.Count
        Dim inherit As Boolean = chkInherit.Checked
        Dim explicit As Boolean = IIf(rowCount > 0, True, False)
        If Not tvFolders.SelectedNode Is Nothing And rowCount > 0 Then
            Select Case True
                Case inherit And explicit
                    chkInherit.Checked = True
                    tvFolders.SelectedNode.ImageIndex = 2
                    tvFolders.SelectedNode.SelectedImageIndex = 2
                Case inherit
                    chkInherit.Checked = True
                    tvFolders.SelectedNode.ImageIndex = 1
                    tvFolders.SelectedNode.SelectedImageIndex = 1
                Case explicit
                    chkInherit.Checked = False
                    tvFolders.SelectedNode.ImageIndex = 3
                    tvFolders.SelectedNode.SelectedImageIndex = 3
                Case Else
                    chkInherit.Checked = False
                    tvFolders.SelectedNode.ImageIndex = 0
                    tvFolders.SelectedNode.SelectedImageIndex = 0
            End Select
        End If

    End Sub

    'Private Sub grdRights_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles grdRights.MouseClick
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        If grdRights.SelectedRows.Count > 0 Then
    '            populatePermissions(grdRights.SelectedRows(0).Tag)
    '        End If
    '    End If
    'End Sub

    'Private Sub populatePermControls(ByVal acc As FileSystemAccessRule)
    '    Dim allowDeny As AccessControlType = acc.AccessControlType
    '    Dim applyTo As permApplyTo = getApplyTo(acc)
    '    Dim advFlags As String = accRuleToAdvFlags(acc)
    '    Dim sumFlags As String = advFlagsToSumFlags(advFlags, applyTo)

    Private Sub populatePermControls(ByVal acc As FileSystemAccessRule)
        Dim allowDeny As AccessControlType = acc.AccessControlType
        Dim applyTo As permApplyTo = getApplyTo(acc)
        Dim advFlags As String = accRuleToAdvFlags(acc)
        Dim sumFlags As String = advFlagsToSumFlags(advFlags & "|" & applyTo.ToString)

        cboxApplyTo.Enabled = True
        cboxApplyTo.Text = applyTo.ToString

        If allowDeny = AccessControlType.Allow Then
            writeAdvDenyChecks("0|0|0|0|0|0|0|0|0|0|0|0|0|0|0") 'clear advanced DENY check boxes
            writeSumDenyChecks("0|0|0|0|0|0|0")                 'clear summary DENY check boxes
            DenyChecksState(False)                              'disable all DENY check boxes
            AllowChecksState(True)
            writeAdvAllowChecks(advFlags)
            writeSumAllowChecks(sumFlags)
        Else
            writeAdvAllowChecks("0|0|0|0|0|0|0|0|0|0|0|0|0|0|0") 'clear advanced ALLOW check boxes
            writeSumAllowChecks("0|0|0|0|0|0|0")                 'clear summary ALLOW check boxes
            AllowChecksState(False)                              'disable all ALLOW check boxes
            DenyChecksState(True)
            writeAdvDenyChecks(advFlags)
            writeSumDenyChecks(sumFlags)
        End If
    End Sub

    Private Sub enablePermControls(ByVal enable As Boolean)
        If enable Then
            AllowChecksState(True)
            DenyChecksState(True)
            cboxApplyTo.Enabled = True
        Else
            writeAdvAllowChecks("0|0|0|0|0|0|0|0|0|0|0|0|0|0|0")
            writeSumAllowChecks("0|0|0|0|0|0|0")
            writeAdvDenyChecks("0|0|0|0|0|0|0|0|0|0|0|0|0|0|0")
            writeSumDenyChecks("0|0|0|0|0|0|0")
            AllowChecksState(False)
            DenyChecksState(False)
            cboxApplyTo.Text = ""
            cboxApplyTo.Enabled = False
        End If
    End Sub

    Private Sub AllowChecksState(ByVal enable As Boolean)

        If enable Then _chkAllowSum_FC.Enabled = True Else _chkAllowSum_FC.Enabled = False
        If enable Then _chkAllowSum_MO.Enabled = True Else _chkAllowSum_MO.Enabled = False
        If enable Then _chkAllowSum_RAE.Enabled = True Else _chkAllowSum_RAE.Enabled = False
        If enable Then _chkAllowSum_LI.Enabled = True Else _chkAllowSum_LI.Enabled = False
        If enable Then _chkAllowSum_RE.Enabled = True Else _chkAllowSum_RE.Enabled = False
        If enable Then _chkAllowSum_WR.Enabled = True Else _chkAllowSum_WR.Enabled = False

        If enable Then _chkAllowAdv_FC.Enabled = True Else _chkAllowAdv_FC.Enabled = False
        If enable Then _chkAllowAdv_TR.Enabled = True Else _chkAllowAdv_TR.Enabled = False
        If enable Then _chkAllowAdv_LI.Enabled = True Else _chkAllowAdv_LI.Enabled = False
        If enable Then _chkAllowAdv_RA.Enabled = True Else _chkAllowAdv_RA.Enabled = False
        If enable Then _chkAllowAdv_REA.Enabled = True Else _chkAllowAdv_REA.Enabled = False
        If enable Then _chkAllowAdv_CFI.Enabled = True Else _chkAllowAdv_CFI.Enabled = False
        If enable Then _chkAllowAdv_CFO.Enabled = True Else _chkAllowAdv_CFO.Enabled = False
        If enable Then _chkAllowAdv_WA.Enabled = True Else _chkAllowAdv_WA.Enabled = False
        If enable Then _chkAllowAdv_WEA.Enabled = True Else _chkAllowAdv_WEA.Enabled = False
        If enable Then _chkAllowAdv_DSF.Enabled = True Else _chkAllowAdv_DSF.Enabled = False
        If enable Then _chkAllowAdv_DE.Enabled = True Else _chkAllowAdv_DE.Enabled = False
        If enable Then _chkAllowAdv_RP.Enabled = True Else _chkAllowAdv_RP.Enabled = False
        If enable Then _chkAllowAdv_CP.Enabled = True Else _chkAllowAdv_CP.Enabled = False
        If enable Then _chkAllowAdv_TO.Enabled = True Else _chkAllowAdv_TO.Enabled = False

    End Sub

    Private Sub DenyChecksState(ByVal enable As Boolean)

        If enable Then _chkDenySum_FC.Enabled = True Else _chkDenySum_FC.Enabled = False
        If enable Then _chkDenySum_MO.Enabled = True Else _chkDenySum_MO.Enabled = False
        If enable Then _chkDenySum_RAE.Enabled = True Else _chkDenySum_RAE.Enabled = False
        If enable Then _chkDenySum_LI.Enabled = True Else _chkDenySum_LI.Enabled = False
        If enable Then _chkDenySum_RE.Enabled = True Else _chkDenySum_RE.Enabled = False
        If enable Then _chkDenySum_WR.Enabled = True Else _chkDenySum_WR.Enabled = False

        If enable Then _chkDenyAdv_FC.Enabled = True Else _chkDenyAdv_FC.Enabled = False
        If enable Then _chkDenyAdv_TR.Enabled = True Else _chkDenyAdv_TR.Enabled = False
        If enable Then _chkDenyAdv_LI.Enabled = True Else _chkDenyAdv_LI.Enabled = False
        If enable Then _chkDenyAdv_RA.Enabled = True Else _chkDenyAdv_RA.Enabled = False
        If enable Then _chkDenyAdv_REA.Enabled = True Else _chkDenyAdv_REA.Enabled = False
        If enable Then _chkDenyAdv_CFI.Enabled = True Else _chkDenyAdv_CFI.Enabled = False
        If enable Then _chkDenyAdv_CFO.Enabled = True Else _chkDenyAdv_CFO.Enabled = False
        If enable Then _chkDenyAdv_WA.Enabled = True Else _chkDenyAdv_WA.Enabled = False
        If enable Then _chkDenyAdv_WEA.Enabled = True Else _chkDenyAdv_WEA.Enabled = False
        If enable Then _chkDenyAdv_DSF.Enabled = True Else _chkDenyAdv_DSF.Enabled = False
        If enable Then _chkDenyAdv_DE.Enabled = True Else _chkDenyAdv_DE.Enabled = False
        If enable Then _chkDenyAdv_RP.Enabled = True Else _chkDenyAdv_RP.Enabled = False
        If enable Then _chkDenyAdv_CP.Enabled = True Else _chkDenyAdv_CP.Enabled = False
        If enable Then _chkDenyAdv_TO.Enabled = True Else _chkDenyAdv_TO.Enabled = False

    End Sub

    Private Sub writeSumAllowChecks(ByVal bitCodes As String)
        Dim bits As String() = bitCodes.Split("|")
        If bits(0) = "1" Then _chkAllowSum_FC.Checked = True Else _chkAllowSum_FC.Checked = False
        If bits(1) = "1" Then _chkAllowSum_MO.Checked = True Else _chkAllowSum_MO.Checked = False
        If bits(2) = "1" Then _chkAllowSum_RAE.Checked = True Else _chkAllowSum_RAE.Checked = False
        If bits(3) = "1" Then _chkAllowSum_LI.Checked = True Else _chkAllowSum_LI.Checked = False
        If bits(4) = "1" Then _chkAllowSum_RE.Checked = True Else _chkAllowSum_RE.Checked = False
        If bits(5) = "1" Then _chkAllowSum_WR.Checked = True Else _chkAllowSum_WR.Checked = False
        If bits(6) = "1" Then _chkAllowSum_SP.Checked = True Else _chkAllowSum_SP.Checked = False
    End Sub

    Private Function readSumAllowChecks() As String
        readSumAllowChecks = _
            IIf(_chkAllowSum_FC.Checked, "1", "0") & _
            IIf(_chkAllowSum_MO.Checked, "|1", "|0") & _
            IIf(_chkAllowSum_RAE.Checked, "|1", "|0") & _
            IIf(_chkAllowSum_LI.Checked, "|1", "|0") & _
            IIf(_chkAllowSum_RE.Checked, "|1", "|0") & _
            IIf(_chkAllowSum_WR.Checked, "|1", "|0") & _
            IIf(_chkAllowSum_SP.Checked, "|1", "|0")
    End Function

    Private Sub writeAdvAllowChecks(ByVal bitCodes As String)
        Dim bits As String() = bitCodes.Split("|")
        If bits(0) = "1" Then _chkAllowAdv_FC.Checked = True Else _chkAllowAdv_FC.Checked = False
        If bits(1) = "1" Then _chkAllowAdv_TR.Checked = True Else _chkAllowAdv_TR.Checked = False
        If bits(2) = "1" Then _chkAllowAdv_LI.Checked = True Else _chkAllowAdv_LI.Checked = False
        If bits(3) = "1" Then _chkAllowAdv_RA.Checked = True Else _chkAllowAdv_RA.Checked = False
        If bits(4) = "1" Then _chkAllowAdv_REA.Checked = True Else _chkAllowAdv_REA.Checked = False
        If bits(5) = "1" Then _chkAllowAdv_CFI.Checked = True Else _chkAllowAdv_CFI.Checked = False
        If bits(6) = "1" Then _chkAllowAdv_CFO.Checked = True Else _chkAllowAdv_CFO.Checked = False
        If bits(7) = "1" Then _chkAllowAdv_WA.Checked = True Else _chkAllowAdv_WA.Checked = False
        If bits(8) = "1" Then _chkAllowAdv_WEA.Checked = True Else _chkAllowAdv_WEA.Checked = False
        If bits(9) = "1" Then _chkAllowAdv_DSF.Checked = True Else _chkAllowAdv_DSF.Checked = False
        If bits(10) = "1" Then _chkAllowAdv_DE.Checked = True Else _chkAllowAdv_DE.Checked = False
        If bits(11) = "1" Then _chkAllowAdv_RP.Checked = True Else _chkAllowAdv_RP.Checked = False
        If bits(12) = "1" Then _chkAllowAdv_CP.Checked = True Else _chkAllowAdv_CP.Checked = False
        If bits(13) = "1" Then _chkAllowAdv_TO.Checked = True Else _chkAllowAdv_TO.Checked = False
    End Sub

    Private Function readAdvAllowChecks() As String
        readAdvAllowChecks = _
            IIf(_chkAllowSum_FC.Checked, "1", "0") & _
            IIf(_chkAllowAdv_TR.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_LI.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_RA.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_REA.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_CFI.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_CFO.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_WA.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_WEA.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_DSF.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_DE.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_RP.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_CP.Checked, "|1", "|0") & _
            IIf(_chkAllowAdv_TO.Checked, "|1", "|0")
    End Function

    Private Sub writeSumDenyChecks(ByVal bitCodes As String)
        Dim bits As String() = bitCodes.Split("|")
        If bits(0) = "1" Then _chkDenySum_FC.Checked = True Else _chkDenySum_FC.Checked = False
        If bits(1) = "1" Then _chkDenySum_MO.Checked = True Else _chkDenySum_MO.Checked = False
        If bits(2) = "1" Then _chkDenySum_RAE.Checked = True Else _chkDenySum_RAE.Checked = False
        If bits(3) = "1" Then _chkDenySum_LI.Checked = True Else _chkDenySum_LI.Checked = False
        If bits(4) = "1" Then _chkDenySum_RE.Checked = True Else _chkDenySum_RE.Checked = False
        If bits(5) = "1" Then _chkDenySum_WR.Checked = True Else _chkDenySum_WR.Checked = False
        If bits(6) = "1" Then _chkDenySum_SP.Checked = True Else _chkDenySum_SP.Checked = False
    End Sub

    Private Function readSumDenyChecks() As String
        readSumDenyChecks = _
            IIf(_chkDenySum_FC.Checked, "1", "0") & _
            IIf(_chkDenySum_MO.Checked, "|1", "|0") & _
            IIf(_chkDenySum_RAE.Checked, "|1", "|0") & _
            IIf(_chkDenySum_LI.Checked, "|1", "|0") & _
            IIf(_chkDenySum_RE.Checked, "|1", "|0") & _
            IIf(_chkDenySum_WR.Checked, "|1", "|0") & _
            IIf(_chkDenySum_SP.Checked, "|1", "|0")
    End Function

    Private Sub writeAdvDenyChecks(ByVal bitCodes As String)
        Dim bits As String() = bitCodes.Split("|")
        If bits(0) = "1" Then _chkDenyAdv_FC.Checked = True Else _chkDenyAdv_FC.Checked = False
        If bits(1) = "1" Then _chkDenyAdv_TR.Checked = True Else _chkDenyAdv_TR.Checked = False
        If bits(2) = "1" Then _chkDenyAdv_LI.Checked = True Else _chkDenyAdv_LI.Checked = False
        If bits(3) = "1" Then _chkDenyAdv_RA.Checked = True Else _chkDenyAdv_RA.Checked = False
        If bits(4) = "1" Then _chkDenyAdv_REA.Checked = True Else _chkDenyAdv_REA.Checked = False
        If bits(5) = "1" Then _chkDenyAdv_CFI.Checked = True Else _chkDenyAdv_CFI.Checked = False
        If bits(6) = "1" Then _chkDenyAdv_CFO.Checked = True Else _chkDenyAdv_CFO.Checked = False
        If bits(7) = "1" Then _chkDenyAdv_WA.Checked = True Else _chkDenyAdv_WA.Checked = False
        If bits(8) = "1" Then _chkDenyAdv_WEA.Checked = True Else _chkDenyAdv_WEA.Checked = False
        If bits(9) = "1" Then _chkDenyAdv_DSF.Checked = True Else _chkDenyAdv_DSF.Checked = False
        If bits(10) = "1" Then _chkDenyAdv_DE.Checked = True Else _chkDenyAdv_DE.Checked = False
        If bits(11) = "1" Then _chkDenyAdv_RP.Checked = True Else _chkDenyAdv_RP.Checked = False
        If bits(12) = "1" Then _chkDenyAdv_CP.Checked = True Else _chkDenyAdv_CP.Checked = False
        If bits(13) = "1" Then _chkDenyAdv_TO.Checked = True Else _chkDenyAdv_TO.Checked = False
    End Sub

    Private Function readAdvDenyChecks() As String
        readAdvDenyChecks = _
            IIf(_chkDenySum_FC.Checked, "1", "0") & _
            IIf(_chkDenyAdv_TR.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_LI.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_RA.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_REA.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_CFI.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_CFO.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_WA.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_WEA.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_DSF.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_DE.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_RP.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_CP.Checked, "|1", "|0") & _
            IIf(_chkDenyAdv_TO.Checked, "|1", "|0")
    End Function

    Private Sub AllowSum_CheckChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not bSkipEventHandlers Then
            Dim CheckBoxObj As CheckBox = CType(sender, CheckBox)
            Dim strFlags As String = readSumAllowChecks()
            Dim boxChecked As Boolean = CheckBoxObj.Checked
            Dim boxCntlName As String = CheckBoxObj.Name.ToString()

            bSkipEventHandlers = True

            If boxChecked Then
                Select Case boxCntlName
                    Case "_chkAllowSum_FC"
                        writeSumAllowChecks("1|1|1|1|1|1|0")
                    Case "_chkAllowSum_MO"
                        _chkAllowSum_RAE.Checked = True
                        _chkAllowSum_LI.Checked = True
                        _chkAllowSum_RE.Checked = True
                        _chkAllowSum_WR.Checked = True
                    Case "_chkAllowSum_RAE"
                        _chkAllowSum_LI.Checked = True
                        _chkAllowSum_RE.Checked = True
                End Select
            Else
                Select Case boxCntlName
                    Case "_chkAllowSum_FC"
                    Case "_chkAllowSum_MO"
                        _chkAllowSum_FC.Checked = False
                    Case "_chkAllowSum_RAE"
                        _chkAllowSum_FC.Checked = False
                        _chkAllowSum_MO.Checked = False
                    Case "_chkAllowSum_LI" Or "_chkAllowSum_RE"
                        _chkAllowSum_FC.Checked = False
                        _chkAllowSum_MO.Checked = False
                        _chkAllowSum_RAE.Checked = False
                    Case "_chkAllowSum_WR"
                        _chkAllowSum_FC.Checked = False
                        _chkAllowSum_MO.Checked = False
                End Select
            End If

            For Each flags As String In sumFlagsToAdvFlags(readSumAllowChecks())
                writeAdvAllowChecks(flags)
            Next

            bSkipEventHandlers = False

            'MsgBox("AllowSum: " & readSumAllowChecks())
        End If

    End Sub

    Private Sub DenySum_CheckChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not bSkipEventHandlers Then
            Dim CheckBoxObj As CheckBox = CType(sender, CheckBox)
            Dim strFlags As String = readSumDenyChecks()
            Dim boxState As Boolean = CheckBoxObj.Checked
            Dim boxCntlName As String = CheckBoxObj.Name.ToString()

            bSkipEventHandlers = True

            If boxState Then
                Select Case boxCntlName
                    Case "_chkDenySum_FC"
                        writeSumDenyChecks("1|1|1|1|1|1|0")
                    Case "_chkDenySum_MO"
                        writeSumDenyChecks("0|1|1|1|1|1|0")
                    Case "_chkDenySum_RAE"
                    Case "_chkDenySum_LI"
                    Case "_chkDenySum_RE"
                    Case "_chkDenySum_WR"
                End Select
            Else
                Select Case boxCntlName
                    Case "_chkAllowSum_FC"
                    Case "_chkAllowSum_MO"
                    Case "_chkAllowSum_RAE"
                    Case "_chkAllowSum_LI"
                    Case "_chkAllowSum_RE"
                    Case "_chkAllowSum_WR"
                    Case "_chkAllowSum_SP"
                End Select
            End If

            bSkipEventHandlers = False

            'MsgBox("DenySum: " & readSumDenyChecks())
        End If

    End Sub

    Private Sub AllowAdv_CheckChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not bSkipEventHandlers Then
            Dim CheckBoxObj As CheckBox = CType(sender, CheckBox)
            Dim strFlags As String = readAdvAllowChecks()
            Dim boxState As Boolean = CheckBoxObj.Checked
            Dim boxCntlName As String = CheckBoxObj.Name.ToString()

            bSkipEventHandlers = True

            If boxState Then
                Select Case boxCntlName
                    Case "_chkAllowSum_FC"
                    Case "_chkAllowSum_MO"
                    Case "_chkAllowSum_RAE"
                    Case "_chkAllowSum_LI"
                    Case "_chkAllowSum_RE"
                    Case "_chkAllowSum_WR"
                    Case "_chkAllowSum_SP"
                End Select
            Else
                Select Case boxCntlName
                    Case "_chkAllowSum_FC"
                    Case "_chkAllowSum_MO"
                    Case "_chkAllowSum_RAE"
                    Case "_chkAllowSum_LI"
                    Case "_chkAllowSum_RE"
                    Case "_chkAllowSum_WR"
                    Case "_chkAllowSum_SP"
                End Select
            End If

            bSkipEventHandlers = False

            'MsgBox("AllowAdv: " & readAdvAllowChecks())
        End If

    End Sub

    Private Sub DenyAdv_CheckChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Not bSkipEventHandlers Then
            Dim CheckBoxObj As CheckBox = CType(sender, CheckBox)
            Dim strFlags As String = readAdvDenyChecks()
            Dim boxState As Boolean = CheckBoxObj.Checked
            Dim boxCntlName As String = CheckBoxObj.Name.ToString()

            bSkipEventHandlers = True

            If boxState Then
                Select Case boxCntlName
                    Case "_chkAllowSum_FC"
                    Case "_chkAllowSum_MO"
                    Case "_chkAllowSum_RAE"
                    Case "_chkAllowSum_LI"
                    Case "_chkAllowSum_RE"
                    Case "_chkAllowSum_WR"
                    Case "_chkAllowSum_SP"
                End Select
            Else
                Select Case boxCntlName
                    Case "_chkAllowSum_FC"
                    Case "_chkAllowSum_MO"
                    Case "_chkAllowSum_RAE"
                    Case "_chkAllowSum_LI"
                    Case "_chkAllowSum_RE"
                    Case "_chkAllowSum_WR"
                    Case "_chkAllowSum_SP"
                End Select
            End If

            bSkipEventHandlers = False

            'MsgBox("DenyAdv: " & readAdvDenyChecks())
        End If

    End Sub

End Class