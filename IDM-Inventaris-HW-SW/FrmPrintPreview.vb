Imports System.Data.SqlClient
Public Class FrmPrintPreview
    Dim rep As crInvBarcode
    Dim repcol As crLabelInventory
    Dim crChkList As crCheckListMaster
    Dim baris As Integer
    Dim dt As New DataTable
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Public kondisi As String


    Private Sub FrmPrintPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim baris As Integer
            baris = FrmInventaris.dgvData.CurrentCell.RowIndex
            If JenisLap = "Label" Then
                repcol = New crLabelInventory
                dt = Me.Rpt_inventarisTableAdapter.GetDataByInv(FrmInventaris.txtCari.Text)
                repcol.SetDataSource(dt)
                crViewer.ReportSource = repcol
            ElseIf JenisLap = "Inventaris" Then
                crChkList = New crCheckListMaster
                dt = Me.Rpt_checklistTableAdapter.GetData()
                crChkList.SetDataSource(dt)
                crViewer.ReportSource = crChkList
            ElseIf JenisLap = "HW" Then
                repcol = New crLabelInventory
                'dt = Me.Rpt_inventarisTableAdapter.GetDataByInv(FrmInventaris.dgvData.Item(0, baris).Value)
                dt = Me.Rpt_inventarisTableAdapter.GetDataByInv(FrmInventaris.txtNo.Text)
                repcol.SetDataSource(dt)
                crViewer.ReportSource = repcol
            Else
                repcol = New crLabelInventory
                dt = Me.Rpt_inventarisTableAdapter.GetDataByDepartemen(FrmInventaris.txtCari.Text)
                repcol.SetDataSource(dt)
                crViewer.ReportSource = repcol
            End If

            'baris = FrmInventaris.dgvData.CurrentCell.RowIndex

            'rep = New crInvBarcode
            'If FrmInventaris.txtNo.Text = "" Then
            '    dtbarcode = Me.Tbl_inventarisTableAdapter.GetDataByNoInv(FrmInventaris.txtNo.Text)
            'End If
            'If FrmInventaris.dgvData.SelectedCells.Count > 0 Then
            '    dtbarcode = Me.Tbl_inventarisTableAdapter.GetDataByNoInv(FrmInventaris.dgvData.Item(0, baris).Value)
            'End If

            'rep.SetDataSource(dtbarcode)
            'crViewer.ReportSource = rep

            'Else

            'repcol = New crLabelInventory
            'dtbarcode = Me.Rpt_inventarisTableAdapter.GetData()
            'repcol.SetDataSource(dtbarcode)
            'crViewer.ReportSource = repcol

            'End If

        Catch ex As Exception
            MessageBox.Show("Database Gagal Diproses.." & vbCrLf & ex.ToString, "Informasi..", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class