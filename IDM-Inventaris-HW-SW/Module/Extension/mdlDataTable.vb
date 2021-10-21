Imports System.Runtime.CompilerServices
Module mdlDataTable

    ''' <summary>
    ''' Populate DataTable Column Name to ToolStripCombo
    ''' </summary>
    <Extension()>
    Public Sub extPopulateToCombo(dt As DataTable, cbo As ToolStripComboBox, Optional reset As Boolean = True)
        If reset Then
            cbo.Items.Clear()
        End If
        For Each col As DataColumn In dt.Columns
            cbo.Items.Add(col.ColumnName)
        Next
    End Sub

End Module
