Public Class clsSettings

    Public Sub SetColumnSortMode(dgv As DataGridView, sortMode As DataGridViewColumnSortMode)
        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = sortMode
        Next
    End Sub

    Public Function SetMasterViewDGV(ByRef dgv As DataGridView) As Object
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToOrderColumns = False
        dgv.AllowUserToResizeColumns = False
        dgv.AllowUserToResizeRows = False
        dgv.MultiSelect = False
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Return Nothing
    End Function

End Class
