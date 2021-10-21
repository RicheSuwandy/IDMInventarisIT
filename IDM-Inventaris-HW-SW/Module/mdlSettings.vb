Imports System.Data.SqlClient
Module mdlSettings

    Public Function setPermission(ByRef frm As Form, ByVal isCall As Boolean) As Boolean
        Dim tsm As New ToolStrip
        Dim isReport As Boolean = False
        Dim query As String
        Dim dr As DataRow
        Try
            query = "SELECT a.Lihat, a.Simpan, a.Edit, a.Hapus, a.Cetak  FROM userNET u " &
                        "LEFT OUTER join UserAccessNET a " &
                        "ON u.typekey = a.TypeKey " &
                        "WHERE u.UserNm = '@usernm' and  a.Key_ID = '@keyid'"
            query = myString.Replace(query, "@usernm", sessionUser, "@keyid", frm.Tag)
            quickMessage.DebugMessage(query)
            dr = dFile.Load(query).Rows(0)

            If Not isReport Then
                For Each obj As Object In frm.Controls
                    If obj.GetType Is GetType(System.Windows.Forms.ToolStrip) Then
                        If obj.tag = "Button" Then
                            tsm = obj
                            Exit For
                        End If
                    End If
                Next
                For Each btn As Object In tsm.Items
                    If btn.tag = "Lihat" Then
                        btn.Enabled = dr.Item("Lihat")
                    ElseIf btn.tag = "Simpan" Then
                        btn.Enabled = dr.Item("Simpan")
                    ElseIf btn.tag = "Edit" Then
                        btn.Enabled = dr.Item("Edit")
                    ElseIf btn.tag = "Hapus" Then
                        btn.Enabled = dr.Item("Hapus")
                    ElseIf btn.tag = "Cetak" Then
                        btn.Enabled = dr.Item("Cetak")
                    ElseIf btn.tag = "OK" Then
                        btn.Enabled = (dr.Item("Lihat") And isCall)
                        btn.visible = (dr.Item("Lihat") And isCall)
                    End If
                Next
                tsm.Visible = dr("Lihat")
            End If
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
            Return False
        End Try
        Return True
    End Function

End Module