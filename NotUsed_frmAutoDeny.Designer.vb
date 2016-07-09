<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class NotUsed_frmAutoDeny
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
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents chkSub As System.Windows.Forms.CheckBox
    Public WithEvents chkFolder As System.Windows.Forms.CheckBox
    Public WithEvents chkFile As System.Windows.Forms.CheckBox
    Public WithEvents chkDel As System.Windows.Forms.CheckBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NotUsed_frmAutoDeny))
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.chkSub = New System.Windows.Forms.CheckBox
        Me.chkFolder = New System.Windows.Forms.CheckBox
        Me.chkFile = New System.Windows.Forms.CheckBox
        Me.chkDel = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        Me.ToolTip1.Active = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Text = " Automatically DENY"
        Me.ClientSize = New System.Drawing.Size(345, 256)
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ControlBox = True
        Me.Enabled = True
        Me.KeyPreview = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HelpButton = False
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Name = "frmAutoDeny"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
        Me.cmdCancel.Location = New System.Drawing.Point(264, 224)
        Me.cmdCancel.TabIndex = 5
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.CausesValidation = True
        Me.cmdCancel.Enabled = True
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.TabStop = True
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdOK.Text = "OK"
        Me.cmdOK.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK.Location = New System.Drawing.Point(184, 224)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.CausesValidation = True
        Me.cmdOK.Enabled = True
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.TabStop = True
        Me.cmdOK.Name = "cmdOK"
        Me.Frame1.Size = New System.Drawing.Size(344, 8)
        Me.Frame1.Location = New System.Drawing.Point(2, 208)
        Me.Frame1.TabIndex = 7
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Enabled = True
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Visible = True
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.Name = "Frame1"
        Me.chkSub.Text = "Propegate to SubFolders (if Inheritance set)"
        Me.chkSub.Size = New System.Drawing.Size(241, 17)
        Me.chkSub.Location = New System.Drawing.Point(24, 184)
        Me.chkSub.TabIndex = 3
        Me.chkSub.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSub.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkSub.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.chkSub.BackColor = System.Drawing.SystemColors.Control
        Me.chkSub.CausesValidation = True
        Me.chkSub.Enabled = True
        Me.chkSub.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkSub.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkSub.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkSub.Appearance = System.Windows.Forms.Appearance.Normal
        Me.chkSub.TabStop = True
        Me.chkSub.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkSub.Visible = True
        Me.chkSub.Name = "chkSub"
        Me.chkFolder.Text = "Create Folders  (if SubFolders Exist)"
        Me.chkFolder.Size = New System.Drawing.Size(201, 17)
        Me.chkFolder.Location = New System.Drawing.Point(24, 144)
        Me.chkFolder.TabIndex = 2
        Me.chkFolder.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFolder.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkFolder.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.chkFolder.BackColor = System.Drawing.SystemColors.Control
        Me.chkFolder.CausesValidation = True
        Me.chkFolder.Enabled = True
        Me.chkFolder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFolder.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFolder.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFolder.Appearance = System.Windows.Forms.Appearance.Normal
        Me.chkFolder.TabStop = True
        Me.chkFolder.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFolder.Visible = True
        Me.chkFolder.Name = "chkFolder"
        Me.chkFile.Text = "Create Files (if SubFolders Exist)"
        Me.chkFile.Size = New System.Drawing.Size(201, 17)
        Me.chkFile.Location = New System.Drawing.Point(24, 120)
        Me.chkFile.TabIndex = 1
        Me.chkFile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFile.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkFile.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.chkFile.BackColor = System.Drawing.SystemColors.Control
        Me.chkFile.CausesValidation = True
        Me.chkFile.Enabled = True
        Me.chkFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkFile.Appearance = System.Windows.Forms.Appearance.Normal
        Me.chkFile.TabStop = True
        Me.chkFile.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkFile.Visible = True
        Me.chkFile.Name = "chkFile"
        Me.chkDel.Text = "Delete"
        Me.chkDel.Size = New System.Drawing.Size(129, 17)
        Me.chkDel.Location = New System.Drawing.Point(24, 96)
        Me.chkDel.TabIndex = 0
        Me.chkDel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDel.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkDel.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.chkDel.BackColor = System.Drawing.SystemColors.Control
        Me.chkDel.CausesValidation = True
        Me.chkDel.Enabled = True
        Me.chkDel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkDel.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkDel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkDel.Appearance = System.Windows.Forms.Appearance.Normal
        Me.chkDel.TabStop = True
        Me.chkDel.CheckState = System.Windows.Forms.CheckState.Unchecked
        Me.chkDel.Visible = True
        Me.chkDel.Name = "chkDel"
        Me.Label1.Text = "This will automatically Add ""Deny"" for ""This Folder Only"" for any User or Group with ""Modify"" Access."
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Size = New System.Drawing.Size(329, 73)
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.TabIndex = 6
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Enabled = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.UseMnemonic = True
        Me.Label1.Visible = True
        Me.Label1.AutoSize = False
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Label1.Name = "Label1"
        Me.Controls.Add(cmdCancel)
        Me.Controls.Add(cmdOK)
        Me.Controls.Add(Frame1)
        Me.Controls.Add(chkSub)
        Me.Controls.Add(chkFolder)
        Me.Controls.Add(chkFile)
        Me.Controls.Add(chkDel)
        Me.Controls.Add(Label1)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
End Class