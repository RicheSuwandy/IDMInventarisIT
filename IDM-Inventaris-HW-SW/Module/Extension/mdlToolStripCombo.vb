Imports System.Runtime.CompilerServices
Module mdlToolStripCombo

    ''' <summary>
    ''' Get DataTable Column Name to ToolStripCombo
    ''' </summary>
    <Extension()>
    Public Sub PopulateFromDT(cbo As ToolStripComboBox, dt As DataTable, Optional reset As Boolean = True)
        If reset Then
            cbo.Items.Clear()
        End If
        For Each col As DataColumn In dt.Columns
            cbo.Items.Add(col.ColumnName)
        Next
    End Sub

End Module
