<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFolders
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSpace As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuCreate As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuOverride As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSpace3 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuEditMode As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAutoDeny As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSpace2 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuVerifyGroup As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuVerifyAccess As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSpace5 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuGroupFix As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuSpace4 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents mnuRunAs As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAutoGroup As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAuto As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuManual As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents _chkDenyAdv_CFI As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_REA As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_RA As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_LI As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_TR As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_FC As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_CFI As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_REA As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_RA As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_LI As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_TR As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_FC As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_CFO As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_WA As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_WEA As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_DSF As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_DE As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_RP As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_CP As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowAdv_TO As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_CFO As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_WA As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_WEA As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_DSF As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_DE As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_RP As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_CP As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenyAdv_TO As System.Windows.Forms.CheckBox
    Public WithEvents _lblRights_11 As System.Windows.Forms.Label
    Public WithEvents _lblRights_10 As System.Windows.Forms.Label
    Public WithEvents _lblRights_9 As System.Windows.Forms.Label
    Public WithEvents _lblRights_8 As System.Windows.Forms.Label
    Public WithEvents _lblRights_7 As System.Windows.Forms.Label
    Public WithEvents _lblRights_6 As System.Windows.Forms.Label
    Public WithEvents _lblRights_12 As System.Windows.Forms.Label
    Public WithEvents _lblRights_13 As System.Windows.Forms.Label
    Public WithEvents _lblRights_14 As System.Windows.Forms.Label
    Public WithEvents _lblRights_15 As System.Windows.Forms.Label
    Public WithEvents _lblRights_16 As System.Windows.Forms.Label
    Public WithEvents _lblRights_17 As System.Windows.Forms.Label
    Public WithEvents _lblRights_18 As System.Windows.Forms.Label
    Public WithEvents _lblRights_19 As System.Windows.Forms.Label
    Public WithEvents Picture1 As System.Windows.Forms.Panel
    Public WithEvents btnMain As System.Windows.Forms.Button
    Public WithEvents btnExitEdit As System.Windows.Forms.Button
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFolders))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpace = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOverride = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpace3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAuto = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoDeny = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpace2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuVerifyGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVerifyAccess = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpace5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuGroupFix = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSpace4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRunAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAutoGroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuManual = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Picture1 = New System.Windows.Forms.Panel()
        Me._chkDenyAdv_CFI = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_REA = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_RA = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_LI = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_TR = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_FC = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_CFI = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_REA = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_RA = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_LI = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_TR = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_FC = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_CFO = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_WA = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_WEA = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_DSF = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_DE = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_RP = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_CP = New System.Windows.Forms.CheckBox()
        Me._chkAllowAdv_TO = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_CFO = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_WA = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_WEA = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_DSF = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_DE = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_RP = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_CP = New System.Windows.Forms.CheckBox()
        Me._chkDenyAdv_TO = New System.Windows.Forms.CheckBox()
        Me._lblRights_11 = New System.Windows.Forms.Label()
        Me._lblRights_10 = New System.Windows.Forms.Label()
        Me._lblRights_9 = New System.Windows.Forms.Label()
        Me._lblRights_8 = New System.Windows.Forms.Label()
        Me._lblRights_7 = New System.Windows.Forms.Label()
        Me._lblRights_6 = New System.Windows.Forms.Label()
        Me._lblRights_12 = New System.Windows.Forms.Label()
        Me._lblRights_13 = New System.Windows.Forms.Label()
        Me._lblRights_14 = New System.Windows.Forms.Label()
        Me._lblRights_15 = New System.Windows.Forms.Label()
        Me._lblRights_16 = New System.Windows.Forms.Label()
        Me._lblRights_17 = New System.Windows.Forms.Label()
        Me._lblRights_18 = New System.Windows.Forms.Label()
        Me._lblRights_19 = New System.Windows.Forms.Label()
        Me.btnMain = New System.Windows.Forms.Button()
        Me.btnExitEdit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdRemove = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.chkInherit = New System.Windows.Forms.CheckBox()
        Me.picRights = New System.Windows.Forms.Panel()
        Me._chkDenySum_SP = New System.Windows.Forms.CheckBox()
        Me._chkDenySum_WR = New System.Windows.Forms.CheckBox()
        Me._chkDenySum_RE = New System.Windows.Forms.CheckBox()
        Me._chkDenySum_LI = New System.Windows.Forms.CheckBox()
        Me._chkDenySum_RAE = New System.Windows.Forms.CheckBox()
        Me._chkDenySum_MO = New System.Windows.Forms.CheckBox()
        Me._chkDenySum_FC = New System.Windows.Forms.CheckBox()
        Me._chkAllowSum_SP = New System.Windows.Forms.CheckBox()
        Me._chkAllowSum_WR = New System.Windows.Forms.CheckBox()
        Me._chkAllowSum_RE = New System.Windows.Forms.CheckBox()
        Me._chkAllowSum_LI = New System.Windows.Forms.CheckBox()
        Me._chkAllowSum_RAE = New System.Windows.Forms.CheckBox()
        Me._chkAllowSum_MO = New System.Windows.Forms.CheckBox()
        Me._chkAllowSum_FC = New System.Windows.Forms.CheckBox()
        Me._lblRights_5b = New System.Windows.Forms.Label()
        Me._lblRights_5 = New System.Windows.Forms.Label()
        Me._lblRights_4 = New System.Windows.Forms.Label()
        Me._lblRights_3 = New System.Windows.Forms.Label()
        Me._lblRights_2 = New System.Windows.Forms.Label()
        Me._lblRights_1 = New System.Windows.Forms.Label()
        Me._lblRights_0 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboxApplyTo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelProgress = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.grdRights = New System.Windows.Forms.DataGridView()
        Me.dgvColType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvColPermission = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvColApplyTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tvFolders = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewSubfolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu1.SuspendLayout()
        Me.Picture1.SuspendLayout()
        Me.picRights.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdRights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuView, Me.mnuAuto, Me.mnuHelp})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(999, 24)
        Me.MainMenu1.TabIndex = 87
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuSpace, Me.mnuCreate, Me.mnuOverride, Me.mnuSpace3, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(213, 22)
        Me.mnuNew.Text = "New"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(213, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(213, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(213, 22)
        Me.mnuSaveAs.Text = "Save As"
        '
        'mnuSpace
        '
        Me.mnuSpace.Name = "mnuSpace"
        Me.mnuSpace.Size = New System.Drawing.Size(210, 6)
        '
        'mnuCreate
        '
        Me.mnuCreate.Name = "mnuCreate"
        Me.mnuCreate.Size = New System.Drawing.Size(213, 22)
        Me.mnuCreate.Text = "Create Folder Structure"
        '
        'mnuOverride
        '
        Me.mnuOverride.Name = "mnuOverride"
        Me.mnuOverride.Size = New System.Drawing.Size(213, 22)
        Me.mnuOverride.Text = "Override Existing Structure"
        '
        'mnuSpace3
        '
        Me.mnuSpace3.Name = "mnuSpace3"
        Me.mnuSpace3.Size = New System.Drawing.Size(210, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(213, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditMode})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "View"
        '
        'mnuEditMode
        '
        Me.mnuEditMode.Name = "mnuEditMode"
        Me.mnuEditMode.Size = New System.Drawing.Size(128, 22)
        Me.mnuEditMode.Text = "Edit Mode"
        '
        'mnuAuto
        '
        Me.mnuAuto.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAutoDeny, Me.mnuSpace2, Me.mnuVerifyGroup, Me.mnuVerifyAccess, Me.mnuSpace5, Me.mnuGroupFix, Me.mnuSpace4, Me.mnuRunAs, Me.mnuAutoGroup})
        Me.mnuAuto.Name = "mnuAuto"
        Me.mnuAuto.Size = New System.Drawing.Size(83, 20)
        Me.mnuAuto.Text = "Automation"
        '
        'mnuAutoDeny
        '
        Me.mnuAutoDeny.Name = "mnuAutoDeny"
        Me.mnuAutoDeny.Size = New System.Drawing.Size(263, 22)
        Me.mnuAutoDeny.Text = "Auto Denies"
        '
        'mnuSpace2
        '
        Me.mnuSpace2.Name = "mnuSpace2"
        Me.mnuSpace2.Size = New System.Drawing.Size(260, 6)
        '
        'mnuVerifyGroup
        '
        Me.mnuVerifyGroup.Name = "mnuVerifyGroup"
        Me.mnuVerifyGroup.Size = New System.Drawing.Size(263, 22)
        Me.mnuVerifyGroup.Text = "Verify User/Group Exist"
        '
        'mnuVerifyAccess
        '
        Me.mnuVerifyAccess.Name = "mnuVerifyAccess"
        Me.mnuVerifyAccess.Size = New System.Drawing.Size(263, 22)
        Me.mnuVerifyAccess.Text = "Verify ""Change Permissions"" Access"
        '
        'mnuSpace5
        '
        Me.mnuSpace5.Name = "mnuSpace5"
        Me.mnuSpace5.Size = New System.Drawing.Size(260, 6)
        Me.mnuSpace5.Visible = False
        '
        'mnuGroupFix
        '
        Me.mnuGroupFix.Name = "mnuGroupFix"
        Me.mnuGroupFix.Size = New System.Drawing.Size(263, 22)
        Me.mnuGroupFix.Text = "Group Fix - Mismatch"
        Me.mnuGroupFix.Visible = False
        '
        'mnuSpace4
        '
        Me.mnuSpace4.Name = "mnuSpace4"
        Me.mnuSpace4.Size = New System.Drawing.Size(260, 6)
        Me.mnuSpace4.Visible = False
        '
        'mnuRunAs
        '
        Me.mnuRunAs.Name = "mnuRunAs"
        Me.mnuRunAs.Size = New System.Drawing.Size(263, 22)
        Me.mnuRunAs.Text = "RunAs"
        Me.mnuRunAs.Visible = False
        '
        'mnuAutoGroup
        '
        Me.mnuAutoGroup.Name = "mnuAutoGroup"
        Me.mnuAutoGroup.Size = New System.Drawing.Size(263, 22)
        Me.mnuAutoGroup.Text = "AutoGroup Creation"
        Me.mnuAutoGroup.Visible = False
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuManual, Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuManual
        '
        Me.mnuManual.Name = "mnuManual"
        Me.mnuManual.Size = New System.Drawing.Size(140, 22)
        Me.mnuManual.Text = "User Manual"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(140, 22)
        Me.mnuAbout.Text = "About"
        '
        'Picture1
        '
        Me.Picture1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Picture1.BackColor = System.Drawing.Color.Gainsboro
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Controls.Add(Me._chkDenyAdv_CFI)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_REA)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_RA)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_LI)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_TR)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_FC)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_CFI)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_REA)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_RA)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_LI)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_TR)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_FC)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_CFO)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_WA)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_WEA)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_DSF)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_DE)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_RP)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_CP)
        Me.Picture1.Controls.Add(Me._chkAllowAdv_TO)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_CFO)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_WA)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_WEA)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_DSF)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_DE)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_RP)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_CP)
        Me.Picture1.Controls.Add(Me._chkDenyAdv_TO)
        Me.Picture1.Controls.Add(Me._lblRights_11)
        Me.Picture1.Controls.Add(Me._lblRights_10)
        Me.Picture1.Controls.Add(Me._lblRights_9)
        Me.Picture1.Controls.Add(Me._lblRights_8)
        Me.Picture1.Controls.Add(Me._lblRights_7)
        Me.Picture1.Controls.Add(Me._lblRights_6)
        Me.Picture1.Controls.Add(Me._lblRights_12)
        Me.Picture1.Controls.Add(Me._lblRights_13)
        Me.Picture1.Controls.Add(Me._lblRights_14)
        Me.Picture1.Controls.Add(Me._lblRights_15)
        Me.Picture1.Controls.Add(Me._lblRights_16)
        Me.Picture1.Controls.Add(Me._lblRights_17)
        Me.Picture1.Controls.Add(Me._lblRights_18)
        Me.Picture1.Controls.Add(Me._lblRights_19)
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(319, 54)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(297, 228)
        Me.Picture1.TabIndex = 39
        Me.Picture1.TabStop = True
        '
        '_chkDenyAdv_CFI
        '
        Me._chkDenyAdv_CFI.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_CFI.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_CFI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_CFI.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_CFI.Location = New System.Drawing.Point(269, 81)
        Me._chkDenyAdv_CFI.Name = "_chkDenyAdv_CFI"
        Me._chkDenyAdv_CFI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_CFI.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_CFI.TabIndex = 67
        Me._chkDenyAdv_CFI.TabStop = False
        Me._chkDenyAdv_CFI.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_REA
        '
        Me._chkDenyAdv_REA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_REA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_REA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_REA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_REA.Location = New System.Drawing.Point(269, 65)
        Me._chkDenyAdv_REA.Name = "_chkDenyAdv_REA"
        Me._chkDenyAdv_REA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_REA.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_REA.TabIndex = 66
        Me._chkDenyAdv_REA.TabStop = False
        Me._chkDenyAdv_REA.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_RA
        '
        Me._chkDenyAdv_RA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_RA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_RA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_RA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_RA.Location = New System.Drawing.Point(269, 49)
        Me._chkDenyAdv_RA.Name = "_chkDenyAdv_RA"
        Me._chkDenyAdv_RA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_RA.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_RA.TabIndex = 65
        Me._chkDenyAdv_RA.TabStop = False
        Me._chkDenyAdv_RA.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_LI
        '
        Me._chkDenyAdv_LI.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_LI.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_LI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_LI.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_LI.Location = New System.Drawing.Point(269, 33)
        Me._chkDenyAdv_LI.Name = "_chkDenyAdv_LI"
        Me._chkDenyAdv_LI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_LI.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_LI.TabIndex = 64
        Me._chkDenyAdv_LI.TabStop = False
        Me._chkDenyAdv_LI.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_TR
        '
        Me._chkDenyAdv_TR.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_TR.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_TR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_TR.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_TR.Location = New System.Drawing.Point(269, 17)
        Me._chkDenyAdv_TR.Name = "_chkDenyAdv_TR"
        Me._chkDenyAdv_TR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_TR.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_TR.TabIndex = 63
        Me._chkDenyAdv_TR.TabStop = False
        Me._chkDenyAdv_TR.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_FC
        '
        Me._chkDenyAdv_FC.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_FC.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_FC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_FC.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_FC.Location = New System.Drawing.Point(269, 1)
        Me._chkDenyAdv_FC.Name = "_chkDenyAdv_FC"
        Me._chkDenyAdv_FC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_FC.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_FC.TabIndex = 62
        Me._chkDenyAdv_FC.TabStop = False
        Me._chkDenyAdv_FC.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_CFI
        '
        Me._chkAllowAdv_CFI.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_CFI.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_CFI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_CFI.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_CFI.Location = New System.Drawing.Point(213, 81)
        Me._chkAllowAdv_CFI.Name = "_chkAllowAdv_CFI"
        Me._chkAllowAdv_CFI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_CFI.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_CFI.TabIndex = 61
        Me._chkAllowAdv_CFI.TabStop = False
        Me._chkAllowAdv_CFI.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_REA
        '
        Me._chkAllowAdv_REA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_REA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_REA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_REA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_REA.Location = New System.Drawing.Point(213, 65)
        Me._chkAllowAdv_REA.Name = "_chkAllowAdv_REA"
        Me._chkAllowAdv_REA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_REA.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_REA.TabIndex = 60
        Me._chkAllowAdv_REA.TabStop = False
        Me._chkAllowAdv_REA.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_RA
        '
        Me._chkAllowAdv_RA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_RA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_RA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_RA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_RA.Location = New System.Drawing.Point(213, 49)
        Me._chkAllowAdv_RA.Name = "_chkAllowAdv_RA"
        Me._chkAllowAdv_RA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_RA.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_RA.TabIndex = 59
        Me._chkAllowAdv_RA.TabStop = False
        Me._chkAllowAdv_RA.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_LI
        '
        Me._chkAllowAdv_LI.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_LI.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_LI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_LI.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_LI.Location = New System.Drawing.Point(213, 33)
        Me._chkAllowAdv_LI.Name = "_chkAllowAdv_LI"
        Me._chkAllowAdv_LI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_LI.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_LI.TabIndex = 58
        Me._chkAllowAdv_LI.TabStop = False
        Me._chkAllowAdv_LI.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_TR
        '
        Me._chkAllowAdv_TR.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_TR.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_TR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_TR.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_TR.Location = New System.Drawing.Point(213, 17)
        Me._chkAllowAdv_TR.Name = "_chkAllowAdv_TR"
        Me._chkAllowAdv_TR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_TR.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_TR.TabIndex = 57
        Me._chkAllowAdv_TR.TabStop = False
        Me._chkAllowAdv_TR.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_FC
        '
        Me._chkAllowAdv_FC.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_FC.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_FC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_FC.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_FC.Location = New System.Drawing.Point(213, 1)
        Me._chkAllowAdv_FC.Name = "_chkAllowAdv_FC"
        Me._chkAllowAdv_FC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_FC.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_FC.TabIndex = 56
        Me._chkAllowAdv_FC.TabStop = False
        Me._chkAllowAdv_FC.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_CFO
        '
        Me._chkAllowAdv_CFO.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_CFO.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_CFO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_CFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_CFO.Location = New System.Drawing.Point(213, 97)
        Me._chkAllowAdv_CFO.Name = "_chkAllowAdv_CFO"
        Me._chkAllowAdv_CFO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_CFO.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_CFO.TabIndex = 55
        Me._chkAllowAdv_CFO.TabStop = False
        Me._chkAllowAdv_CFO.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_WA
        '
        Me._chkAllowAdv_WA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_WA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_WA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_WA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_WA.Location = New System.Drawing.Point(213, 113)
        Me._chkAllowAdv_WA.Name = "_chkAllowAdv_WA"
        Me._chkAllowAdv_WA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_WA.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_WA.TabIndex = 54
        Me._chkAllowAdv_WA.TabStop = False
        Me._chkAllowAdv_WA.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_WEA
        '
        Me._chkAllowAdv_WEA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_WEA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_WEA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_WEA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_WEA.Location = New System.Drawing.Point(213, 129)
        Me._chkAllowAdv_WEA.Name = "_chkAllowAdv_WEA"
        Me._chkAllowAdv_WEA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_WEA.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_WEA.TabIndex = 53
        Me._chkAllowAdv_WEA.TabStop = False
        Me._chkAllowAdv_WEA.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_DSF
        '
        Me._chkAllowAdv_DSF.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_DSF.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_DSF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_DSF.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_DSF.Location = New System.Drawing.Point(213, 145)
        Me._chkAllowAdv_DSF.Name = "_chkAllowAdv_DSF"
        Me._chkAllowAdv_DSF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_DSF.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_DSF.TabIndex = 52
        Me._chkAllowAdv_DSF.TabStop = False
        Me._chkAllowAdv_DSF.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_DE
        '
        Me._chkAllowAdv_DE.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_DE.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_DE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_DE.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_DE.Location = New System.Drawing.Point(213, 161)
        Me._chkAllowAdv_DE.Name = "_chkAllowAdv_DE"
        Me._chkAllowAdv_DE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_DE.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_DE.TabIndex = 51
        Me._chkAllowAdv_DE.TabStop = False
        Me._chkAllowAdv_DE.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_RP
        '
        Me._chkAllowAdv_RP.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_RP.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_RP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_RP.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_RP.Location = New System.Drawing.Point(213, 177)
        Me._chkAllowAdv_RP.Name = "_chkAllowAdv_RP"
        Me._chkAllowAdv_RP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_RP.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_RP.TabIndex = 50
        Me._chkAllowAdv_RP.TabStop = False
        Me._chkAllowAdv_RP.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_CP
        '
        Me._chkAllowAdv_CP.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_CP.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_CP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_CP.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_CP.Location = New System.Drawing.Point(213, 193)
        Me._chkAllowAdv_CP.Name = "_chkAllowAdv_CP"
        Me._chkAllowAdv_CP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_CP.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_CP.TabIndex = 49
        Me._chkAllowAdv_CP.TabStop = False
        Me._chkAllowAdv_CP.UseVisualStyleBackColor = False
        '
        '_chkAllowAdv_TO
        '
        Me._chkAllowAdv_TO.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowAdv_TO.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowAdv_TO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowAdv_TO.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowAdv_TO.Location = New System.Drawing.Point(213, 209)
        Me._chkAllowAdv_TO.Name = "_chkAllowAdv_TO"
        Me._chkAllowAdv_TO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowAdv_TO.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowAdv_TO.TabIndex = 48
        Me._chkAllowAdv_TO.TabStop = False
        Me._chkAllowAdv_TO.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_CFO
        '
        Me._chkDenyAdv_CFO.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_CFO.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_CFO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_CFO.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_CFO.Location = New System.Drawing.Point(269, 97)
        Me._chkDenyAdv_CFO.Name = "_chkDenyAdv_CFO"
        Me._chkDenyAdv_CFO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_CFO.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_CFO.TabIndex = 47
        Me._chkDenyAdv_CFO.TabStop = False
        Me._chkDenyAdv_CFO.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_WA
        '
        Me._chkDenyAdv_WA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_WA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_WA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_WA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_WA.Location = New System.Drawing.Point(269, 113)
        Me._chkDenyAdv_WA.Name = "_chkDenyAdv_WA"
        Me._chkDenyAdv_WA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_WA.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_WA.TabIndex = 46
        Me._chkDenyAdv_WA.TabStop = False
        Me._chkDenyAdv_WA.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_WEA
        '
        Me._chkDenyAdv_WEA.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_WEA.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_WEA.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_WEA.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_WEA.Location = New System.Drawing.Point(269, 129)
        Me._chkDenyAdv_WEA.Name = "_chkDenyAdv_WEA"
        Me._chkDenyAdv_WEA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_WEA.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_WEA.TabIndex = 45
        Me._chkDenyAdv_WEA.TabStop = False
        Me._chkDenyAdv_WEA.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_DSF
        '
        Me._chkDenyAdv_DSF.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_DSF.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_DSF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_DSF.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_DSF.Location = New System.Drawing.Point(269, 145)
        Me._chkDenyAdv_DSF.Name = "_chkDenyAdv_DSF"
        Me._chkDenyAdv_DSF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_DSF.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_DSF.TabIndex = 44
        Me._chkDenyAdv_DSF.TabStop = False
        Me._chkDenyAdv_DSF.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_DE
        '
        Me._chkDenyAdv_DE.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_DE.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_DE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_DE.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_DE.Location = New System.Drawing.Point(269, 161)
        Me._chkDenyAdv_DE.Name = "_chkDenyAdv_DE"
        Me._chkDenyAdv_DE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_DE.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_DE.TabIndex = 43
        Me._chkDenyAdv_DE.TabStop = False
        Me._chkDenyAdv_DE.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_RP
        '
        Me._chkDenyAdv_RP.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_RP.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_RP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_RP.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_RP.Location = New System.Drawing.Point(269, 177)
        Me._chkDenyAdv_RP.Name = "_chkDenyAdv_RP"
        Me._chkDenyAdv_RP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_RP.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_RP.TabIndex = 42
        Me._chkDenyAdv_RP.TabStop = False
        Me._chkDenyAdv_RP.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_CP
        '
        Me._chkDenyAdv_CP.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_CP.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_CP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_CP.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_CP.Location = New System.Drawing.Point(269, 193)
        Me._chkDenyAdv_CP.Name = "_chkDenyAdv_CP"
        Me._chkDenyAdv_CP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_CP.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_CP.TabIndex = 41
        Me._chkDenyAdv_CP.TabStop = False
        Me._chkDenyAdv_CP.UseVisualStyleBackColor = False
        '
        '_chkDenyAdv_TO
        '
        Me._chkDenyAdv_TO.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenyAdv_TO.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenyAdv_TO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenyAdv_TO.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenyAdv_TO.Location = New System.Drawing.Point(269, 209)
        Me._chkDenyAdv_TO.Name = "_chkDenyAdv_TO"
        Me._chkDenyAdv_TO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenyAdv_TO.Size = New System.Drawing.Size(17, 17)
        Me._chkDenyAdv_TO.TabIndex = 40
        Me._chkDenyAdv_TO.TabStop = False
        Me._chkDenyAdv_TO.UseVisualStyleBackColor = False
        '
        '_lblRights_11
        '
        Me._lblRights_11.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_11.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_11.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_11.Location = New System.Drawing.Point(5, 81)
        Me._lblRights_11.Name = "_lblRights_11"
        Me._lblRights_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_11.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_11.TabIndex = 81
        Me._lblRights_11.Tag = "2"
        Me._lblRights_11.Text = "Create Files / Write Data"
        '
        '_lblRights_10
        '
        Me._lblRights_10.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_10.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_10.Location = New System.Drawing.Point(5, 65)
        Me._lblRights_10.Name = "_lblRights_10"
        Me._lblRights_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_10.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_10.TabIndex = 80
        Me._lblRights_10.Tag = "8"
        Me._lblRights_10.Text = "Read Extended Attributes"
        '
        '_lblRights_9
        '
        Me._lblRights_9.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_9.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_9.Location = New System.Drawing.Point(5, 49)
        Me._lblRights_9.Name = "_lblRights_9"
        Me._lblRights_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_9.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_9.TabIndex = 79
        Me._lblRights_9.Tag = "128"
        Me._lblRights_9.Text = "Read Attributes"
        '
        '_lblRights_8
        '
        Me._lblRights_8.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_8.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_8.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_8.Location = New System.Drawing.Point(5, 33)
        Me._lblRights_8.Name = "_lblRights_8"
        Me._lblRights_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_8.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_8.TabIndex = 78
        Me._lblRights_8.Tag = "1"
        Me._lblRights_8.Text = "List Folder / Read Data"
        '
        '_lblRights_7
        '
        Me._lblRights_7.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_7.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_7.Location = New System.Drawing.Point(5, 17)
        Me._lblRights_7.Name = "_lblRights_7"
        Me._lblRights_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_7.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_7.TabIndex = 77
        Me._lblRights_7.Tag = "32"
        Me._lblRights_7.Text = "Traverse Folder / Execute File"
        '
        '_lblRights_6
        '
        Me._lblRights_6.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_6.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_6.Location = New System.Drawing.Point(5, 1)
        Me._lblRights_6.Name = "_lblRights_6"
        Me._lblRights_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_6.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_6.TabIndex = 76
        Me._lblRights_6.Tag = "983551"
        Me._lblRights_6.Text = "Full Control"
        '
        '_lblRights_12
        '
        Me._lblRights_12.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_12.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_12.Location = New System.Drawing.Point(5, 97)
        Me._lblRights_12.Name = "_lblRights_12"
        Me._lblRights_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_12.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_12.TabIndex = 75
        Me._lblRights_12.Tag = "4"
        Me._lblRights_12.Text = "Create Folders / Append Data"
        '
        '_lblRights_13
        '
        Me._lblRights_13.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_13.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_13.Location = New System.Drawing.Point(5, 113)
        Me._lblRights_13.Name = "_lblRights_13"
        Me._lblRights_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_13.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_13.TabIndex = 74
        Me._lblRights_13.Tag = "256"
        Me._lblRights_13.Text = "Write Attributes"
        '
        '_lblRights_14
        '
        Me._lblRights_14.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_14.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_14.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_14.Location = New System.Drawing.Point(5, 129)
        Me._lblRights_14.Name = "_lblRights_14"
        Me._lblRights_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_14.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_14.TabIndex = 73
        Me._lblRights_14.Tag = "16"
        Me._lblRights_14.Text = "Write Extended Attributes"
        '
        '_lblRights_15
        '
        Me._lblRights_15.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_15.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_15.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_15.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_15.Location = New System.Drawing.Point(5, 145)
        Me._lblRights_15.Name = "_lblRights_15"
        Me._lblRights_15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_15.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_15.TabIndex = 72
        Me._lblRights_15.Tag = "64"
        Me._lblRights_15.Text = "Delete Subfolders and Files"
        '
        '_lblRights_16
        '
        Me._lblRights_16.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_16.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_16.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_16.Location = New System.Drawing.Point(5, 161)
        Me._lblRights_16.Name = "_lblRights_16"
        Me._lblRights_16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_16.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_16.TabIndex = 71
        Me._lblRights_16.Tag = "65536"
        Me._lblRights_16.Text = "Delete"
        '
        '_lblRights_17
        '
        Me._lblRights_17.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_17.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_17.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_17.Location = New System.Drawing.Point(5, 177)
        Me._lblRights_17.Name = "_lblRights_17"
        Me._lblRights_17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_17.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_17.TabIndex = 70
        Me._lblRights_17.Tag = "131072"
        Me._lblRights_17.Text = "Read Permissions"
        '
        '_lblRights_18
        '
        Me._lblRights_18.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_18.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_18.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_18.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_18.Location = New System.Drawing.Point(5, 193)
        Me._lblRights_18.Name = "_lblRights_18"
        Me._lblRights_18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_18.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_18.TabIndex = 69
        Me._lblRights_18.Tag = "262144"
        Me._lblRights_18.Text = "Change Permissions"
        '
        '_lblRights_19
        '
        Me._lblRights_19.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_19.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_19.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_19.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_19.Location = New System.Drawing.Point(5, 209)
        Me._lblRights_19.Name = "_lblRights_19"
        Me._lblRights_19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_19.Size = New System.Drawing.Size(193, 17)
        Me._lblRights_19.TabIndex = 68
        Me._lblRights_19.Tag = "524288"
        Me._lblRights_19.Text = "Take Ownership"
        '
        'btnMain
        '
        Me.btnMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMain.BackColor = System.Drawing.SystemColors.Control
        Me.btnMain.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMain.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMain.Location = New System.Drawing.Point(256, 519)
        Me.btnMain.Name = "btnMain"
        Me.btnMain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMain.Size = New System.Drawing.Size(107, 28)
        Me.btnMain.TabIndex = 21
        Me.btnMain.Text = "<Main>"
        Me.btnMain.UseVisualStyleBackColor = False
        '
        'btnExitEdit
        '
        Me.btnExitEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExitEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExitEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExitEdit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitEdit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExitEdit.Location = New System.Drawing.Point(6, 250)
        Me.btnExitEdit.Name = "btnExitEdit"
        Me.btnExitEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExitEdit.Size = New System.Drawing.Size(121, 33)
        Me.btnExitEdit.TabIndex = 20
        Me.btnExitEdit.Text = "Exit ""Edit Mode"""
        Me.btnExitEdit.UseVisualStyleBackColor = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        Me.ImageList1.Images.SetKeyName(0, "FolderOpen_7140_24.bmp")
        Me.ImageList1.Images.SetKeyName(1, "FolderInherit_7140_24.bmp")
        Me.ImageList1.Images.SetKeyName(2, "FolderInheritExplicit_7140_24.bmp")
        Me.ImageList1.Images.SetKeyName(3, "FolderExplicit_7140_24.bmp")
        Me.ImageList1.Images.SetKeyName(4, "UserGroup16.bmp")
        Me.ImageList1.Images.SetKeyName(5, "UserSingle16.bmp")
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(14, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Permissions for:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(210, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Allow"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(267, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Deny"
        '
        'cmdRemove
        '
        Me.cmdRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdRemove.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRemove.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRemove.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRemove.Location = New System.Drawing.Point(78, 219)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRemove.Size = New System.Drawing.Size(65, 25)
        Me.cmdRemove.TabIndex = 5
        Me.cmdRemove.Text = "Remove"
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(6, 219)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(65, 25)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "Add..."
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'chkInherit
        '
        Me.chkInherit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkInherit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.chkInherit.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkInherit.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInherit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkInherit.Location = New System.Drawing.Point(450, 225)
        Me.chkInherit.Name = "chkInherit"
        Me.chkInherit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkInherit.Size = New System.Drawing.Size(163, 21)
        Me.chkInherit.TabIndex = 18
        Me.chkInherit.Text = "Folder Inherits from parent"
        Me.chkInherit.UseVisualStyleBackColor = False
        '
        'picRights
        '
        Me.picRights.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picRights.BackColor = System.Drawing.Color.Gainsboro
        Me.picRights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRights.Controls.Add(Me._chkDenySum_SP)
        Me.picRights.Controls.Add(Me._chkDenySum_WR)
        Me.picRights.Controls.Add(Me._chkDenySum_RE)
        Me.picRights.Controls.Add(Me._chkDenySum_LI)
        Me.picRights.Controls.Add(Me._chkDenySum_RAE)
        Me.picRights.Controls.Add(Me._chkDenySum_MO)
        Me.picRights.Controls.Add(Me._chkDenySum_FC)
        Me.picRights.Controls.Add(Me._chkAllowSum_SP)
        Me.picRights.Controls.Add(Me._chkAllowSum_WR)
        Me.picRights.Controls.Add(Me._chkAllowSum_RE)
        Me.picRights.Controls.Add(Me._chkAllowSum_LI)
        Me.picRights.Controls.Add(Me._chkAllowSum_RAE)
        Me.picRights.Controls.Add(Me._chkAllowSum_MO)
        Me.picRights.Controls.Add(Me._chkAllowSum_FC)
        Me.picRights.Controls.Add(Me._lblRights_5b)
        Me.picRights.Controls.Add(Me._lblRights_5)
        Me.picRights.Controls.Add(Me._lblRights_4)
        Me.picRights.Controls.Add(Me._lblRights_3)
        Me.picRights.Controls.Add(Me._lblRights_2)
        Me.picRights.Controls.Add(Me._lblRights_1)
        Me.picRights.Controls.Add(Me._lblRights_0)
        Me.picRights.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRights.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picRights.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picRights.Location = New System.Drawing.Point(6, 54)
        Me.picRights.Name = "picRights"
        Me.picRights.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picRights.Size = New System.Drawing.Size(304, 120)
        Me.picRights.TabIndex = 30
        Me.picRights.TabStop = True
        '
        '_chkDenySum_SP
        '
        Me._chkDenySum_SP.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenySum_SP.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenySum_SP.Enabled = False
        Me._chkDenySum_SP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenySum_SP.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenySum_SP.Location = New System.Drawing.Point(270, 99)
        Me._chkDenySum_SP.Name = "_chkDenySum_SP"
        Me._chkDenySum_SP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenySum_SP.Size = New System.Drawing.Size(17, 17)
        Me._chkDenySum_SP.TabIndex = 17
        Me._chkDenySum_SP.TabStop = False
        Me._chkDenySum_SP.UseVisualStyleBackColor = False
        '
        '_chkDenySum_WR
        '
        Me._chkDenySum_WR.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenySum_WR.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenySum_WR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenySum_WR.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenySum_WR.Location = New System.Drawing.Point(270, 82)
        Me._chkDenySum_WR.Name = "_chkDenySum_WR"
        Me._chkDenySum_WR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenySum_WR.Size = New System.Drawing.Size(17, 17)
        Me._chkDenySum_WR.TabIndex = 17
        Me._chkDenySum_WR.TabStop = False
        Me._chkDenySum_WR.UseVisualStyleBackColor = False
        '
        '_chkDenySum_RE
        '
        Me._chkDenySum_RE.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenySum_RE.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenySum_RE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenySum_RE.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenySum_RE.Location = New System.Drawing.Point(270, 66)
        Me._chkDenySum_RE.Name = "_chkDenySum_RE"
        Me._chkDenySum_RE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenySum_RE.Size = New System.Drawing.Size(17, 17)
        Me._chkDenySum_RE.TabIndex = 16
        Me._chkDenySum_RE.TabStop = False
        Me._chkDenySum_RE.UseVisualStyleBackColor = False
        '
        '_chkDenySum_LI
        '
        Me._chkDenySum_LI.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenySum_LI.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenySum_LI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenySum_LI.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenySum_LI.Location = New System.Drawing.Point(270, 50)
        Me._chkDenySum_LI.Name = "_chkDenySum_LI"
        Me._chkDenySum_LI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenySum_LI.Size = New System.Drawing.Size(17, 17)
        Me._chkDenySum_LI.TabIndex = 15
        Me._chkDenySum_LI.TabStop = False
        Me._chkDenySum_LI.UseVisualStyleBackColor = False
        '
        '_chkDenySum_RAE
        '
        Me._chkDenySum_RAE.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenySum_RAE.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenySum_RAE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenySum_RAE.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenySum_RAE.Location = New System.Drawing.Point(270, 34)
        Me._chkDenySum_RAE.Name = "_chkDenySum_RAE"
        Me._chkDenySum_RAE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenySum_RAE.Size = New System.Drawing.Size(17, 17)
        Me._chkDenySum_RAE.TabIndex = 14
        Me._chkDenySum_RAE.TabStop = False
        Me._chkDenySum_RAE.UseVisualStyleBackColor = False
        '
        '_chkDenySum_MO
        '
        Me._chkDenySum_MO.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenySum_MO.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenySum_MO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenySum_MO.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenySum_MO.Location = New System.Drawing.Point(270, 18)
        Me._chkDenySum_MO.Name = "_chkDenySum_MO"
        Me._chkDenySum_MO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenySum_MO.Size = New System.Drawing.Size(17, 17)
        Me._chkDenySum_MO.TabIndex = 13
        Me._chkDenySum_MO.TabStop = False
        Me._chkDenySum_MO.UseVisualStyleBackColor = False
        '
        '_chkDenySum_FC
        '
        Me._chkDenySum_FC.BackColor = System.Drawing.Color.Gainsboro
        Me._chkDenySum_FC.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkDenySum_FC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkDenySum_FC.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkDenySum_FC.Location = New System.Drawing.Point(270, 2)
        Me._chkDenySum_FC.Name = "_chkDenySum_FC"
        Me._chkDenySum_FC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkDenySum_FC.Size = New System.Drawing.Size(17, 17)
        Me._chkDenySum_FC.TabIndex = 12
        Me._chkDenySum_FC.TabStop = False
        Me._chkDenySum_FC.UseVisualStyleBackColor = False
        '
        '_chkAllowSum_SP
        '
        Me._chkAllowSum_SP.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowSum_SP.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowSum_SP.Enabled = False
        Me._chkAllowSum_SP.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowSum_SP.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowSum_SP.Location = New System.Drawing.Point(214, 99)
        Me._chkAllowSum_SP.Name = "_chkAllowSum_SP"
        Me._chkAllowSum_SP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowSum_SP.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowSum_SP.TabIndex = 11
        Me._chkAllowSum_SP.TabStop = False
        Me._chkAllowSum_SP.UseVisualStyleBackColor = False
        '
        '_chkAllowSum_WR
        '
        Me._chkAllowSum_WR.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowSum_WR.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowSum_WR.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowSum_WR.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowSum_WR.Location = New System.Drawing.Point(214, 82)
        Me._chkAllowSum_WR.Name = "_chkAllowSum_WR"
        Me._chkAllowSum_WR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowSum_WR.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowSum_WR.TabIndex = 11
        Me._chkAllowSum_WR.TabStop = False
        Me._chkAllowSum_WR.UseVisualStyleBackColor = False
        '
        '_chkAllowSum_RE
        '
        Me._chkAllowSum_RE.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowSum_RE.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowSum_RE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowSum_RE.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowSum_RE.Location = New System.Drawing.Point(214, 66)
        Me._chkAllowSum_RE.Name = "_chkAllowSum_RE"
        Me._chkAllowSum_RE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowSum_RE.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowSum_RE.TabIndex = 10
        Me._chkAllowSum_RE.TabStop = False
        Me._chkAllowSum_RE.UseVisualStyleBackColor = False
        '
        '_chkAllowSum_LI
        '
        Me._chkAllowSum_LI.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowSum_LI.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowSum_LI.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowSum_LI.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowSum_LI.Location = New System.Drawing.Point(214, 50)
        Me._chkAllowSum_LI.Name = "_chkAllowSum_LI"
        Me._chkAllowSum_LI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowSum_LI.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowSum_LI.TabIndex = 9
        Me._chkAllowSum_LI.TabStop = False
        Me._chkAllowSum_LI.UseVisualStyleBackColor = False
        '
        '_chkAllowSum_RAE
        '
        Me._chkAllowSum_RAE.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowSum_RAE.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowSum_RAE.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowSum_RAE.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowSum_RAE.Location = New System.Drawing.Point(214, 34)
        Me._chkAllowSum_RAE.Name = "_chkAllowSum_RAE"
        Me._chkAllowSum_RAE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowSum_RAE.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowSum_RAE.TabIndex = 8
        Me._chkAllowSum_RAE.TabStop = False
        Me._chkAllowSum_RAE.UseVisualStyleBackColor = False
        '
        '_chkAllowSum_MO
        '
        Me._chkAllowSum_MO.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowSum_MO.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowSum_MO.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowSum_MO.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowSum_MO.Location = New System.Drawing.Point(214, 18)
        Me._chkAllowSum_MO.Name = "_chkAllowSum_MO"
        Me._chkAllowSum_MO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowSum_MO.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowSum_MO.TabIndex = 7
        Me._chkAllowSum_MO.TabStop = False
        Me._chkAllowSum_MO.UseVisualStyleBackColor = False
        '
        '_chkAllowSum_FC
        '
        Me._chkAllowSum_FC.BackColor = System.Drawing.Color.Gainsboro
        Me._chkAllowSum_FC.Cursor = System.Windows.Forms.Cursors.Default
        Me._chkAllowSum_FC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._chkAllowSum_FC.ForeColor = System.Drawing.SystemColors.ControlText
        Me._chkAllowSum_FC.Location = New System.Drawing.Point(214, 2)
        Me._chkAllowSum_FC.Name = "_chkAllowSum_FC"
        Me._chkAllowSum_FC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._chkAllowSum_FC.Size = New System.Drawing.Size(17, 17)
        Me._chkAllowSum_FC.TabIndex = 6
        Me._chkAllowSum_FC.TabStop = False
        Me._chkAllowSum_FC.UseVisualStyleBackColor = False
        '
        '_lblRights_5b
        '
        Me._lblRights_5b.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_5b.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_5b.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_5b.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_5b.Location = New System.Drawing.Point(6, 99)
        Me._lblRights_5b.Name = "_lblRights_5b"
        Me._lblRights_5b.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_5b.Size = New System.Drawing.Size(129, 17)
        Me._lblRights_5b.TabIndex = 36
        Me._lblRights_5b.Text = "Special Permissions"
        '
        '_lblRights_5
        '
        Me._lblRights_5.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_5.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_5.Location = New System.Drawing.Point(6, 82)
        Me._lblRights_5.Name = "_lblRights_5"
        Me._lblRights_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_5.Size = New System.Drawing.Size(129, 17)
        Me._lblRights_5.TabIndex = 36
        Me._lblRights_5.Text = "Write"
        '
        '_lblRights_4
        '
        Me._lblRights_4.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_4.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_4.Location = New System.Drawing.Point(6, 66)
        Me._lblRights_4.Name = "_lblRights_4"
        Me._lblRights_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_4.Size = New System.Drawing.Size(129, 17)
        Me._lblRights_4.TabIndex = 35
        Me._lblRights_4.Text = "Read"
        '
        '_lblRights_3
        '
        Me._lblRights_3.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_3.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_3.Location = New System.Drawing.Point(6, 50)
        Me._lblRights_3.Name = "_lblRights_3"
        Me._lblRights_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_3.Size = New System.Drawing.Size(129, 17)
        Me._lblRights_3.TabIndex = 34
        Me._lblRights_3.Text = "List folder contents"
        '
        '_lblRights_2
        '
        Me._lblRights_2.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_2.Location = New System.Drawing.Point(6, 34)
        Me._lblRights_2.Name = "_lblRights_2"
        Me._lblRights_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_2.Size = New System.Drawing.Size(129, 17)
        Me._lblRights_2.TabIndex = 33
        Me._lblRights_2.Text = "Read && Execute"
        '
        '_lblRights_1
        '
        Me._lblRights_1.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_1.Location = New System.Drawing.Point(6, 18)
        Me._lblRights_1.Name = "_lblRights_1"
        Me._lblRights_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_1.Size = New System.Drawing.Size(129, 17)
        Me._lblRights_1.TabIndex = 32
        Me._lblRights_1.Text = "Modify"
        '
        '_lblRights_0
        '
        Me._lblRights_0.BackColor = System.Drawing.Color.Gainsboro
        Me._lblRights_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._lblRights_0.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._lblRights_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._lblRights_0.Location = New System.Drawing.Point(6, 2)
        Me._lblRights_0.Name = "_lblRights_0"
        Me._lblRights_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._lblRights_0.Size = New System.Drawing.Size(129, 17)
        Me._lblRights_0.TabIndex = 31
        Me._lblRights_0.Text = "Full Control"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox3.Controls.Add(Me.picRights)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cboxApplyTo)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Picture1)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnExitEdit)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(4, 261)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(622, 291)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Security "
        Me.GroupBox3.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 14)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Apply onto:"
        '
        'cboxApplyTo
        '
        Me.cboxApplyTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboxApplyTo.BackColor = System.Drawing.Color.Gainsboro
        Me.cboxApplyTo.FormattingEnabled = True
        Me.cboxApplyTo.Items.AddRange(New Object() {"ThisFolder", "ThisFolderSubFoldersFiles", "ThisFolderSubFolders", "ThisFolderFiles", "SubFoldersFiles", "SubFolders", "Files"})
        Me.cboxApplyTo.Location = New System.Drawing.Point(384, 14)
        Me.cboxApplyTo.Name = "cboxApplyTo"
        Me.cboxApplyTo.Size = New System.Drawing.Size(232, 22)
        Me.cboxApplyTo.TabIndex = 88
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(316, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(201, 15)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Permissions for "
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(584, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Deny"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(527, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Allow"
        '
        'LabelProgress
        '
        Me.LabelProgress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Location = New System.Drawing.Point(2, 513)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(54, 14)
        Me.LabelProgress.TabIndex = 94
        Me.LabelProgress.Text = "Progress:"
        Me.LabelProgress.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 529)
        Me.ProgressBar1.MarqueeAnimationSpeed = 30
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(247, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 93
        Me.ProgressBar1.Visible = False
        '
        'grdRights
        '
        Me.grdRights.AllowUserToAddRows = False
        Me.grdRights.AllowUserToDeleteRows = False
        Me.grdRights.AllowUserToResizeRows = False
        Me.grdRights.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdRights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grdRights.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.grdRights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdRights.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColType, Me.dgvColName, Me.dgvColPermission, Me.dgvColApplyTo})
        Me.grdRights.Location = New System.Drawing.Point(6, 19)
        Me.grdRights.MultiSelect = False
        Me.grdRights.Name = "grdRights"
        Me.grdRights.RowHeadersVisible = False
        Me.grdRights.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdRights.Size = New System.Drawing.Size(610, 194)
        Me.grdRights.TabIndex = 88
        '
        'dgvColType
        '
        Me.dgvColType.HeaderText = "Type"
        Me.dgvColType.Name = "dgvColType"
        Me.dgvColType.ReadOnly = True
        Me.dgvColType.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColType.Width = 55
        '
        'dgvColName
        '
        Me.dgvColName.HeaderText = "Name"
        Me.dgvColName.Name = "dgvColName"
        Me.dgvColName.ReadOnly = True
        Me.dgvColName.Width = 59
        '
        'dgvColPermission
        '
        Me.dgvColPermission.HeaderText = "Permission"
        Me.dgvColPermission.Name = "dgvColPermission"
        Me.dgvColPermission.ReadOnly = True
        Me.dgvColPermission.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColPermission.Width = 84
        '
        'dgvColApplyTo
        '
        Me.dgvColApplyTo.HeaderText = "Apply To"
        Me.dgvColApplyTo.Name = "dgvColApplyTo"
        Me.dgvColApplyTo.ReadOnly = True
        Me.dgvColApplyTo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvColApplyTo.Width = 74
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.grdRights)
        Me.GroupBox2.Controls.Add(Me.cmdAdd)
        Me.GroupBox2.Controls.Add(Me.cmdRemove)
        Me.GroupBox2.Controls.Add(Me.chkInherit)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(622, 252)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permission Entries"
        Me.GroupBox2.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 21)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelProgress)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMain)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ProgressBar1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvFolders)
        Me.SplitContainer1.Panel1MinSize = 366
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2MinSize = 629
        Me.SplitContainer1.Size = New System.Drawing.Size(999, 555)
        Me.SplitContainer1.SplitterDistance = 366
        Me.SplitContainer1.TabIndex = 3
        '
        'tvFolders
        '
        Me.tvFolders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tvFolders.BackColor = System.Drawing.Color.Gainsboro
        Me.tvFolders.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvFolders.ImageIndex = 0
        Me.tvFolders.ImageList = Me.ImageList1
        Me.tvFolders.LabelEdit = True
        Me.tvFolders.Location = New System.Drawing.Point(3, 3)
        Me.tvFolders.Name = "tvFolders"
        Me.tvFolders.SelectedImageIndex = 0
        Me.tvFolders.Size = New System.Drawing.Size(360, 508)
        Me.tvFolders.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.DeleteFolderToolStripMenuItem, Me.AddNewSubfolderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 22)
        Me.ToolStripMenuItem1.Text = "Rename Folder"
        '
        'DeleteFolderToolStripMenuItem
        '
        Me.DeleteFolderToolStripMenuItem.Name = "DeleteFolderToolStripMenuItem"
        Me.DeleteFolderToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DeleteFolderToolStripMenuItem.Text = "Delete Folder"
        '
        'AddNewSubfolderToolStripMenuItem
        '
        Me.AddNewSubfolderToolStripMenuItem.Name = "AddNewSubfolderToolStripMenuItem"
        Me.AddNewSubfolderToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AddNewSubfolderToolStripMenuItem.Text = "Add New Subfolder"
        '
        'frmFolders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(999, 578)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 49)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1015, 562)
        Me.Name = "frmFolders"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FolderIT - Project Directory Creator"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Picture1.ResumeLayout(False)
        Me.picRights.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.grdRights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents cmdRemove As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents chkInherit As System.Windows.Forms.CheckBox
    Public WithEvents picRights As System.Windows.Forms.Panel
    Public WithEvents _chkDenySum_WR As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenySum_RE As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenySum_LI As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenySum_RAE As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenySum_MO As System.Windows.Forms.CheckBox
    Public WithEvents _chkDenySum_FC As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowSum_WR As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowSum_RE As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowSum_LI As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowSum_RAE As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowSum_MO As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowSum_FC As System.Windows.Forms.CheckBox
    Public WithEvents _lblRights_5 As System.Windows.Forms.Label
    Public WithEvents _lblRights_4 As System.Windows.Forms.Label
    Public WithEvents _lblRights_3 As System.Windows.Forms.Label
    Public WithEvents _lblRights_2 As System.Windows.Forms.Label
    Public WithEvents _lblRights_1 As System.Windows.Forms.Label
    Public WithEvents _lblRights_0 As System.Windows.Forms.Label
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboxApplyTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents grdRights As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Public WithEvents tvFolders As System.Windows.Forms.TreeView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteFolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewSubfolderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelProgress As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents _chkDenySum_SP As System.Windows.Forms.CheckBox
    Public WithEvents _chkAllowSum_SP As System.Windows.Forms.CheckBox
    Public WithEvents _lblRights_5b As System.Windows.Forms.Label
    Friend WithEvents dgvColType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvColName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvColPermission As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvColApplyTo As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class