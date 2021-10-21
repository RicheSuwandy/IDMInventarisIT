Imports System.Data.SqlClient

Public Class clsDataFile
    Public myAdap As New sqlDataAdapter
    Public myTrans As sqlTransaction
    Public myConn As New SqlConnection
    Public myCmd As New sqlCommand
    Public dt As New DataTable
    Public dr As SqlDataReader

    Public Sub New()
        myConn = New SqlConnection("server=" & serverName & "; user id=" & crypter.Decrypt(userName) & " ; password=" & crypter.Decrypt(password) & "; database=" & dBaseName)
    End Sub

    Public Sub ChangeConnection(newServer As String, newDBase As String, newUser As String, newPass As String)
        myConn = New SqlConnection("server=" & newServer & "; user id=" & crypter.Decrypt(newUser) & " ; password=" & crypter.Decrypt(newPass) & "; database=" & newDBase)
    End Sub

    Public Function CheckConnection() As Boolean
        Try
            myConn.Open()
            myConn.Close()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function Load(ByVal query As String, Optional ByVal return_message As Boolean = False) As DataTable
        Try
            dt = New DataTable
            myAdap = New SqlDataAdapter(query, myConn)
            myAdap.Fill(dt)
            If return_message Then MessageBox.Show(query, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM" & vbCrLf & vbCrLf & ex.ToString, _
                                 "HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return dt
    End Function

    Public Function Delete(ByVal query As String, Optional ByVal return_message As Boolean = False) As Boolean
        Try
            myConn.Open()
            myTrans = myConn.BeginTransaction()
            myCmd.Connection = myConn
            myCmd.CommandText = query
            myCmd.Transaction = myTrans
            myCmd.ExecuteNonQuery()
            myTrans.Commit()
            If return_message Then MessageBox.Show("Data telah terhapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            myTrans.Rollback()
            MessageBox.Show("HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM" & vbCrLf & vbCrLf & ex.GetType.ToString & vbCrLf & ex.ToString, _
                                 "HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Finally
            myConn.Close()
        End Try
        Return True
    End Function

    Public Function DeleteUncommit(ByVal query As String, Optional ByVal return_message As Boolean = False) As Boolean
        Try
            myCmd.Connection = myConn
            myCmd.CommandText = query
            myCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM" & vbCrLf & vbCrLf & ex.GetType.ToString & vbCrLf & ex.ToString, _
                                 "HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End Try
        Return True
    End Function

    Public Function BeginTransaction()
        myConn.Open()
        myTrans = myConn.BeginTransaction()
        myCmd.Transaction = myTrans
        Return Nothing
    End Function

    Public Function RollBack()
        myTrans.Rollback()
        myConn.Close()
        Return Nothing
    End Function

    Public Function Commit()
        myTrans.Commit()
        myConn.Close()
        Return Nothing
    End Function

    Public Function Save(ByVal query As String, Optional ByVal return_message As Boolean = False) As Boolean
        Try
            myConn.Open()
            myTrans = myConn.BeginTransaction()
            myCmd = New SqlCommand(query, myConn)
            myCmd.Transaction = myTrans
            myCmd.ExecuteNonQuery()
            myTrans.Commit()
            If return_message Then MessageBox.Show("Data telah tersimpan/terupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            myTrans.Rollback()
            MessageBox.Show("HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM" & vbCrLf & vbCrLf & ex.GetType.ToString & vbCrLf & ex.ToString, _
                                 "HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Finally
            myConn.Close()
        End Try
        Return True
    End Function

    Public Function SaveUncommit(ByVal query As String, Optional ByVal return_message As Boolean = False) As Boolean
        Try
            myCmd.Connection = myConn
            myCmd.CommandText = query
            myCmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM" & vbCrLf & vbCrLf & ex.GetType.ToString & vbCrLf & ex.ToString, _
                                 "HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End Try
        Return True
    End Function

    Public Function CheckExist(query As String, Optional ByVal return_message As Boolean = False) As Boolean
        Try
            dt = New DataTable
            myAdap = New SqlDataAdapter(query, myConn)
            myAdap.Fill(dt)
            If return_message Then MessageBox.Show(query, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If dt.Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM" & vbCrLf & vbCrLf & ex.ToString, _
                                 "HARAP DICATAT DAN LAPORKAN KEPADA PEMBUAT PROGRAM", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return False
    End Function
End Class