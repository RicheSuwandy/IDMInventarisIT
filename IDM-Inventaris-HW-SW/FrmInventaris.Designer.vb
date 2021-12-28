<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventaris
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventaris))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnTambah = New System.Windows.Forms.ToolStripButton()
        Me.btnSimpan = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnView = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintINV = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintHW = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintChkList = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboCari = New System.Windows.Forms.ToolStripComboBox()
        Me.txtCari = New System.Windows.Forms.ToolStripTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnCmd = New System.Windows.Forms.Button()
        Me.rbtnEnable = New System.Windows.Forms.RadioButton()
        Me.rbtnDisable = New System.Windows.Forms.RadioButton()
        Me.dtpTgl = New System.Windows.Forms.DateTimePicker()
        Me.nudVersion = New System.Windows.Forms.NumericUpDown()
        Me.chkSuspend = New System.Windows.Forms.CheckBox()
        Me.txtSoftware = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtScanner = New System.Windows.Forms.TextBox()
        Me.txtPrinter = New System.Windows.Forms.TextBox()
        Me.txtMonitor = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudRAM = New System.Windows.Forms.NumericUpDown()
        Me.nudHD = New System.Windows.Forms.NumericUpDown()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProsesor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDepartemen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCurUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.nudVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTambah, Me.btnSimpan, Me.btnDelete, Me.btnView, Me.btnPrintINV, Me.btnPrintHW, Me.btnPrintChkList, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cboCari, Me.txtCari})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(879, 43)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnTambah
        '
        Me.btnTambah.Image = CType(resources.GetObject("btnTambah.Image"), System.Drawing.Image)
        Me.btnTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(73, 40)
        Me.btnTambah.Text = "&TAMBAH"
        Me.btnTambah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(66, 40)
        Me.btnSimpan.Text = "&SIMPAN"
        Me.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(60, 40)
        Me.btnDelete.Text = "&HAPUS"
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnView
        '
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Image)
        Me.btnView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(52, 40)
        Me.btnView.Text = "&LIHAT"
        Me.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnPrintINV
        '
        Me.btnPrintINV.Image = CType(resources.GetObject("btnPrintINV.Image"), System.Drawing.Image)
        Me.btnPrintINV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintINV.Name = "btnPrintINV"
        Me.btnPrintINV.Size = New System.Drawing.Size(81, 40)
        Me.btnPrintINV.Text = "&PRINT INV"
        Me.btnPrintINV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPrintINV.Visible = False
        '
        'btnPrintHW
        '
        Me.btnPrintHW.Image = CType(resources.GetObject("btnPrintHW.Image"), System.Drawing.Image)
        Me.btnPrintHW.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintHW.Name = "btnPrintHW"
        Me.btnPrintHW.Size = New System.Drawing.Size(82, 40)
        Me.btnPrintHW.Text = "&PRINT HW"
        Me.btnPrintHW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnPrintChkList
        '
        Me.btnPrintChkList.Image = CType(resources.GetObject("btnPrintChkList.Image"), System.Drawing.Image)
        Me.btnPrintChkList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrintChkList.Name = "btnPrintChkList"
        Me.btnPrintChkList.Size = New System.Drawing.Size(134, 40)
        Me.btnPrintChkList.Text = "&PRINT CHECK LIST"
        Me.btnPrintChkList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 43)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Image = CType(resources.GetObject("ToolStripLabel1.Image"), System.Drawing.Image)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(89, 40)
        Me.ToolStripLabel1.Text = "PENCARIAN"
        Me.ToolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'cboCari
        '
        Me.cboCari.Name = "cboCari"
        Me.cboCari.Size = New System.Drawing.Size(121, 43)
        '
        'txtCari
        '
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(100, 43)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 43)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(879, 499)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.btnCmd)
        Me.TabPage1.Controls.Add(Me.rbtnEnable)
        Me.TabPage1.Controls.Add(Me.rbtnDisable)
        Me.TabPage1.Controls.Add(Me.dtpTgl)
        Me.TabPage1.Controls.Add(Me.nudVersion)
        Me.TabPage1.Controls.Add(Me.chkSuspend)
        Me.TabPage1.Controls.Add(Me.txtSoftware)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtKeterangan)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtIP)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtDepartemen)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtCurUser)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtNo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(871, 470)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(473, 410)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(367, 116)
        Me.ListBox1.TabIndex = 19
        '
        'btnCmd
        '
        Me.btnCmd.Location = New System.Drawing.Point(183, 405)
        Me.btnCmd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCmd.Name = "btnCmd"
        Me.btnCmd.Size = New System.Drawing.Size(100, 28)
        Me.btnCmd.TabIndex = 18
        Me.btnCmd.Text = "Lock USB"
        Me.btnCmd.UseVisualStyleBackColor = True
        '
        'rbtnEnable
        '
        Me.rbtnEnable.AutoSize = True
        Me.rbtnEnable.Location = New System.Drawing.Point(96, 410)
        Me.rbtnEnable.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnEnable.Name = "rbtnEnable"
        Me.rbtnEnable.Size = New System.Drawing.Size(73, 21)
        Me.rbtnEnable.TabIndex = 17
        Me.rbtnEnable.TabStop = True
        Me.rbtnEnable.Text = "Enable"
        Me.rbtnEnable.UseVisualStyleBackColor = True
        '
        'rbtnDisable
        '
        Me.rbtnDisable.AutoSize = True
        Me.rbtnDisable.Location = New System.Drawing.Point(8, 410)
        Me.rbtnDisable.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtnDisable.Name = "rbtnDisable"
        Me.rbtnDisable.Size = New System.Drawing.Size(76, 21)
        Me.rbtnDisable.TabIndex = 16
        Me.rbtnDisable.TabStop = True
        Me.rbtnDisable.Text = "Disable"
        Me.rbtnDisable.UseVisualStyleBackColor = True
        '
        'dtpTgl
        '
        Me.dtpTgl.CustomFormat = "dd-MMM-yyyy"
        Me.dtpTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTgl.Location = New System.Drawing.Point(615, 9)
        Me.dtpTgl.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTgl.Name = "dtpTgl"
        Me.dtpTgl.Size = New System.Drawing.Size(132, 22)
        Me.dtpTgl.TabIndex = 4
        '
        'nudVersion
        '
        Me.nudVersion.Location = New System.Drawing.Point(615, 37)
        Me.nudVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.nudVersion.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudVersion.Name = "nudVersion"
        Me.nudVersion.ReadOnly = True
        Me.nudVersion.Size = New System.Drawing.Size(100, 22)
        Me.nudVersion.TabIndex = 5
        '
        'chkSuspend
        '
        Me.chkSuspend.AutoSize = True
        Me.chkSuspend.Location = New System.Drawing.Point(624, 385)
        Me.chkSuspend.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSuspend.Name = "chkSuspend"
        Me.chkSuspend.Size = New System.Drawing.Size(115, 21)
        Me.chkSuspend.TabIndex = 15
        Me.chkSuspend.Text = "SUSPENDED"
        Me.chkSuspend.UseVisualStyleBackColor = True
        '
        'txtSoftware
        '
        Me.txtSoftware.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSoftware.Location = New System.Drawing.Point(473, 276)
        Me.txtSoftware.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSoftware.Multiline = True
        Me.txtSoftware.Name = "txtSoftware"
        Me.txtSoftware.Size = New System.Drawing.Size(273, 101)
        Me.txtSoftware.TabIndex = 14
        Me.txtSoftware.Text = "KINGSOFT, OPEN OFFICE, DEEP FREEZE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(381, 279)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "SOFTWARE"
        '
        'txtKeterangan
        '
        Me.txtKeterangan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKeterangan.Location = New System.Drawing.Point(140, 276)
        Me.txtKeterangan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(232, 101)
        Me.txtKeterangan.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 279)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 17)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "KETERANGAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtScanner)
        Me.GroupBox2.Controls.Add(Me.txtPrinter)
        Me.GroupBox2.Controls.Add(Me.txtMonitor)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 107)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(360, 155)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SUPPORT HARDWARE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 91)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 17)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "SCANNER"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 59)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "PRINTER"
        '
        'txtScanner
        '
        Me.txtScanner.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtScanner.Location = New System.Drawing.Point(173, 87)
        Me.txtScanner.Margin = New System.Windows.Forms.Padding(4)
        Me.txtScanner.Name = "txtScanner"
        Me.txtScanner.Size = New System.Drawing.Size(172, 22)
        Me.txtScanner.TabIndex = 12
        '
        'txtPrinter
        '
        Me.txtPrinter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrinter.Location = New System.Drawing.Point(173, 55)
        Me.txtPrinter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrinter.Name = "txtPrinter"
        Me.txtPrinter.Size = New System.Drawing.Size(172, 22)
        Me.txtPrinter.TabIndex = 11
        '
        'txtMonitor
        '
        Me.txtMonitor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonitor.Location = New System.Drawing.Point(173, 23)
        Me.txtMonitor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMonitor.Name = "txtMonitor"
        Me.txtMonitor.Size = New System.Drawing.Size(132, 22)
        Me.txtMonitor.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 27)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 17)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "MONITOR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nudRAM)
        Me.GroupBox1.Controls.Add(Me.nudHD)
        Me.GroupBox1.Controls.Add(Me.txtOS)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtProsesor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 107)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(360, 155)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SPESIFIKASI KOMPUTER"
        '
        'nudRAM
        '
        Me.nudRAM.DecimalPlaces = 2
        Me.nudRAM.Location = New System.Drawing.Point(129, 86)
        Me.nudRAM.Margin = New System.Windows.Forms.Padding(4)
        Me.nudRAM.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudRAM.Name = "nudRAM"
        Me.nudRAM.Size = New System.Drawing.Size(100, 22)
        Me.nudRAM.TabIndex = 8
        Me.nudRAM.ThousandsSeparator = True
        '
        'nudHD
        '
        Me.nudHD.DecimalPlaces = 2
        Me.nudHD.Location = New System.Drawing.Point(129, 55)
        Me.nudHD.Margin = New System.Windows.Forms.Padding(4)
        Me.nudHD.Maximum = New Decimal(New Integer() {1215752191, 23, 0, 0})
        Me.nudHD.Name = "nudHD"
        Me.nudHD.Size = New System.Drawing.Size(100, 22)
        Me.nudHD.TabIndex = 7
        Me.nudHD.ThousandsSeparator = True
        '
        'txtOS
        '
        Me.txtOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOS.Location = New System.Drawing.Point(129, 119)
        Me.txtOS.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(221, 22)
        Me.txtOS.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 123)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(28, 17)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "OS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(237, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 17)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "MB"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 59)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 17)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "GB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "RAM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 59)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "HARD DISK"
        '
        'txtProsesor
        '
        Me.txtProsesor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProsesor.Location = New System.Drawing.Point(129, 23)
        Me.txtProsesor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProsesor.Name = "txtProsesor"
        Me.txtProsesor.Size = New System.Drawing.Size(221, 22)
        Me.txtProsesor.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PROSESOR"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(484, 43)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "VERSION"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(484, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "LAST UPDATE"
        '
        'txtIP
        '
        Me.txtIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP.Location = New System.Drawing.Point(615, 69)
        Me.txtIP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(132, 22)
        Me.txtIP.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(484, 73)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "IP"
        '
        'txtDepartemen
        '
        Me.txtDepartemen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepartemen.Location = New System.Drawing.Point(140, 69)
        Me.txtDepartemen.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDepartemen.Name = "txtDepartemen"
        Me.txtDepartemen.Size = New System.Drawing.Size(132, 22)
        Me.txtDepartemen.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "DEPARTEMEN"
        '
        'txtCurUser
        '
        Me.txtCurUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCurUser.Location = New System.Drawing.Point(140, 37)
        Me.txtCurUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurUser.Name = "txtCurUser"
        Me.txtCurUser.Size = New System.Drawing.Size(132, 22)
        Me.txtCurUser.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CURRENT USER"
        '
        'txtNo
        '
        Me.txtNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNo.Location = New System.Drawing.Point(140, 5)
        Me.txtNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNo.MaxLength = 50
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(132, 22)
        Me.txtNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NO. INVENTORY"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.dgvData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(871, 470)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "View"
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvData.Location = New System.Drawing.Point(4, 4)
        Me.dgvData.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(859, 458)
        Me.dgvData.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 517)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(879, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(59, 20)
        Me.lblStatus.Text = "STATUS"
        '
        'FrmInventaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 542)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmInventaris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " -- INVENTARIS --"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.nudVersion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudRAM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnView As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintChkList As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboCari As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents txtCari As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnTambah As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nudRAM As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudHD As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtProsesor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDepartemen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCurUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtScanner As System.Windows.Forms.TextBox
    Friend WithEvents txtPrinter As System.Windows.Forms.TextBox
    Friend WithEvents txtMonitor As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents nudVersion As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkSuspend As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnCmd As System.Windows.Forms.Button
    Friend WithEvents rbtnEnable As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDisable As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrintHW As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintINV As System.Windows.Forms.ToolStripButton
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox

End Class
