<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class NotUsed_frmAutoGroup
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
    Public WithEvents cmdClear As System.Windows.Forms.Button
    Public WithEvents cmbType As System.Windows.Forms.ComboBox
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents cmdOK As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents chkAddGroup As System.Windows.Forms.CheckBox
    Public WithEvents chkPrefix As System.Windows.Forms.CheckBox
    Public WithEvents cmdBrowse As System.Windows.Forms.Button
    Public WithEvents txtOU As System.Windows.Forms.TextBox
    Public WithEvents txtSuffix As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdOK = New System.Windows.Forms.Button()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chkAddGroup = New System.Windows.Forms.CheckBox()
        Me.chkPrefix = New System.Windows.Forms.CheckBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.txtOU = New System.Windows.Forms.TextBox()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.SystemColors.Control
        Me.cmdClear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdClear.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdClear.Location = New System.Drawing.Point(8, 216)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdClear.Size = New System.Drawing.Size(49, 25)
        Me.cmdClear.TabIndex = 6
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbType.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbType.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbType.Items.AddRange(New Object() {"Domain local", "Global", "Universal"})
        Me.cmbType.Location = New System.Drawing.Point(80, 120)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbType.Size = New System.Drawing.Size(217, 22)
        Me.cmbType.TabIndex = 3
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(224, 216)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 25)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdOK
        '
        Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdOK.Location = New System.Drawing.Point(144, 216)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(73, 25)
        Me.cmdOK.TabIndex = 7
        Me.cmdOK.Text = "OK"
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 200)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(304, 8)
        Me.Frame1.TabIndex = 12
        Me.Frame1.TabStop = False
        '
        'chkAddGroup
        '
        Me.chkAddGroup.BackColor = System.Drawing.SystemColors.Control
        Me.chkAddGroup.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAddGroup.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAddGroup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAddGroup.Location = New System.Drawing.Point(8, 176)
        Me.chkAddGroup.Name = "chkAddGroup"
        Me.chkAddGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAddGroup.Size = New System.Drawing.Size(297, 17)
        Me.chkAddGroup.TabIndex = 5
        Me.chkAddGroup.Text = "Add Group to Root Folder with ""Read && Execute"" Access"
        Me.chkAddGroup.UseVisualStyleBackColor = False
        '
        'chkPrefix
        '
        Me.chkPrefix.BackColor = System.Drawing.SystemColors.Control
        Me.chkPrefix.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkPrefix.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrefix.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkPrefix.Location = New System.Drawing.Point(8, 152)
        Me.chkPrefix.Name = "chkPrefix"
        Me.chkPrefix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkPrefix.Size = New System.Drawing.Size(217, 17)
        Me.chkPrefix.TabIndex = 4
        Me.chkPrefix.Text = "Prompt for Prefix"
        Me.chkPrefix.UseVisualStyleBackColor = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBrowse.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBrowse.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBrowse.Location = New System.Drawing.Point(248, 96)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBrowse.Size = New System.Drawing.Size(49, 19)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Text = "..."
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'txtOU
        '
        Me.txtOU.AcceptsReturn = True
        Me.txtOU.BackColor = System.Drawing.SystemColors.Window
        Me.txtOU.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOU.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOU.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOU.Location = New System.Drawing.Point(80, 96)
        Me.txtOU.MaxLength = 0
        Me.txtOU.Name = "txtOU"
        Me.txtOU.ReadOnly = True
        Me.txtOU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOU.Size = New System.Drawing.Size(161, 19)
        Me.txtOU.TabIndex = 1
        '
        'txtSuffix
        '
        Me.txtSuffix.AcceptsReturn = True
        Me.txtSuffix.BackColor = System.Drawing.SystemColors.Window
        Me.txtSuffix.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSuffix.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuffix.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSuffix.Location = New System.Drawing.Point(80, 72)
        Me.txtSuffix.MaxLength = 0
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSuffix.Size = New System.Drawing.Size(217, 19)
        Me.txtSuffix.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Type:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "AD Path:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Group Suffix:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(281, 49)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "If set the Folder Structure will create the listed Security Group."
        '
        'frmAutoGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(306, 247)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.chkAddGroup)
        Me.Controls.Add(Me.chkPrefix)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtOU)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Location = New System.Drawing.Point(120, 67)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAutoGroup"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Auto Group Creation"
        Me.ResumeLayout(False)

    End Sub
#End Region
End Class