<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrintPreview
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
        Me.crInvBarcode = New IDM_Inventaris_HW_SW.crInvBarcode()
        Me.crBarcodeCollection = New IDM_Inventaris_HW_SW.crBarcodeCollection()
        Me.crInvBarcode1 = New IDM_Inventaris_HW_SW.crInvBarcode()
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.crLabelInventory1 = New IDM_Inventaris_HW_SW.crLabelInventory()
        Me.Tbl_inventarisTableAdapter = New IDM_Inventaris_HW_SW.dsInventarisTableAdapters.tbl_inventarisTableAdapter()
        Me.Rpt_inventarisTableAdapter = New IDM_Inventaris_HW_SW.dsInventarisTableAdapters.rpt_inventarisTableAdapter()
        Me.Rpt_checklistTableAdapter = New IDM_Inventaris_HW_SW.dsInventarisTableAdapters.rpt_checklistTableAdapter()
        Me.SuspendLayout()
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = 0
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.DisplayStatusBar = False
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.ReportSource = Me.crLabelInventory1
        Me.crViewer.Size = New System.Drawing.Size(579, 420)
        Me.crViewer.TabIndex = 0
        '
        'Tbl_inventarisTableAdapter
        '
        Me.Tbl_inventarisTableAdapter.ClearBeforeFill = True
        '
        'Rpt_inventarisTableAdapter
        '
        Me.Rpt_inventarisTableAdapter.ClearBeforeFill = True
        '
        'Rpt_checklistTableAdapter
        '
        Me.Rpt_checklistTableAdapter.ClearBeforeFill = True
        '
        'FrmPrintPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 420)
        Me.Controls.Add(Me.crViewer)
        Me.Name = "FrmPrintPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-- PRINT PREVIEW --"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents crInvBarcode As IDM_Inventaris_HW_SW.crInvBarcode
    Friend WithEvents Tbl_inventarisTableAdapter As IDM_Inventaris_HW_SW.dsInventarisTableAdapters.tbl_inventarisTableAdapter
    Friend WithEvents crBarcodeCollection As IDM_Inventaris_HW_SW.crBarcodeCollection
    Friend WithEvents crInvBarcode1 As IDM_Inventaris_HW_SW.crInvBarcode
    Friend WithEvents crLabelInventory1 As IDM_Inventaris_HW_SW.crLabelInventory
    Friend WithEvents Rpt_inventarisTableAdapter As IDM_Inventaris_HW_SW.dsInventarisTableAdapters.rpt_inventarisTableAdapter
    Friend WithEvents Rpt_checklistTableAdapter As IDM_Inventaris_HW_SW.dsInventarisTableAdapters.rpt_checklistTableAdapter
End Class
