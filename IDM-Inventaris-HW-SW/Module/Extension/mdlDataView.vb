Imports System.Runtime.CompilerServices
Module mdlDataView

    <Extension()>
    Public Sub extSetSearchFilter(ByRef dv As DataView, colName As String, filterString As String)
        Try
            If colName.Length > 0 Then
                dv.RowFilter = myString.Replace(
                                        "convert(@filterCol,'System.String') like '%@filterID%'",
                                        "@filtercol", colName, "@filterID", filterString)
                quickMessage.DebugMessage(dv.RowFilter)
            End If
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

End Module
