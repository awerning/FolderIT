<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class NotUsed_frmOUs
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
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmbDomain As System.Windows.Forms.ComboBox
    Public WithEvents picRefresh As System.Windows.Forms.PictureBox
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents tvGroups As System.Windows.Forms.TreeView
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NotUsed_frmOUs))
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmdOK = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmbDomain = New System.Windows.Forms.ComboBox
        Me.picRefresh = New System.Windows.Forms.PictureBox
        Me.ImageList1 = New System.Windows.Forms.ImageList
        Me.tvGroups = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        Me.ToolTip1.Active = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Text = " Select an OU"
        Me.ClientSize = New System.Drawing.Size(312, 433)
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
        Me.Name = "frmOUs"
        Me.Frame1.Size = New System.Drawing.Size(312, 8)
        Me.Frame1.Location = New System.Drawing.Point(0, 384)
        Me.Frame1.TabIndex = 5
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Enabled = True
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Visible = True
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.Name = "Frame1"
        Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdOK.Text = "OK"
        Me.cmdOK.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK.Location = New System.Drawing.Point(152, 400)
        Me.cmdOK.TabIndex = 3
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.CausesValidation = True
        Me.cmdOK.Enabled = True
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.TabStop = True
        Me.cmdOK.Name = "cmdOK"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
        Me.cmdCancel.Location = New System.Drawing.Point(232, 400)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.CausesValidation = True
        Me.cmdCancel.Enabled = True
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.TabStop = True
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmbDomain.Size = New System.Drawing.Size(297, 21)
        Me.cmbDomain.Location = New System.Drawing.Point(7, 8)
        Me.cmbDomain.Sorted = True
        Me.cmbDomain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDomain.TabIndex = 2
        Me.cmbDomain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDomain.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDomain.CausesValidation = True
        Me.cmbDomain.Enabled = True
        Me.cmbDomain.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDomain.IntegralHeight = True
        Me.cmbDomain.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDomain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbDomain.TabStop = True
        Me.cmbDomain.Visible = True
        Me.cmbDomain.Name = "cmbDomain"
        Me.picRefresh.Size = New System.Drawing.Size(281, 49)
        Me.picRefresh.Location = New System.Drawing.Point(15, 160)
        Me.picRefresh.TabIndex = 0
        Me.picRefresh.Visible = False
        Me.picRefresh.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.picRefresh.Dock = System.Windows.Forms.DockStyle.None
        Me.picRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.picRefresh.CausesValidation = True
        Me.picRefresh.Enabled = True
        Me.picRefresh.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRefresh.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.picRefresh.TabStop = True
        Me.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
        Me.picRefresh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRefresh.Name = "picRefresh"
        Me.ImageList1.ImageSize = New System.Drawing.Size(8, 8)
        Me.ImageList1.TransparentColor = System.Drawing.Color.FromARGB(192, 192, 192)
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.tvGroups.CausesValidation = True
        Me.tvGroups.Size = New System.Drawing.Size(297, 337)
        Me.tvGroups.Location = New System.Drawing.Point(7, 40)
        Me.tvGroups.TabIndex = 1
        Me.tvGroups.HideSelection = False
        Me.tvGroups.LabelEdit = False
        Me.tvGroups.Sorted = True
        Me.tvGroups.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvGroups.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvGroups.Name = "tvGroups"
        Me.Controls.Add(Frame1)
        Me.Controls.Add(cmdOK)
        Me.Controls.Add(cmdCancel)
        Me.Controls.Add(cmbDomain)
        Me.Controls.Add(picRefresh)
        Me.Controls.Add(tvGroups)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
#End Region
End Class