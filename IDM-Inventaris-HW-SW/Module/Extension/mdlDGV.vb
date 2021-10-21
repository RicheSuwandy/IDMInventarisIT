Imports System.Runtime.CompilerServices
Module mdlDGV
    Private fillPos1() As SByte
    Private fillPos2() As SByte
    Private fillPos3() As SByte
    Private fillPos4() As SByte
    Private fillPos5() As SByte

    <Extension()>
    Public Sub extSetSortingLocked(dgv As DataGridView)
        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub

    <Extension()>
    Public Sub extUserTypeLock(dgv As DataGridView, Optional state As Boolean = True)
        For i As Byte = 0 To 1
            dgv.Columns(i).ReadOnly = state
        Next
    End Sub

    ''' <summary>
    ''' Lock all feature, Full Row Select
    ''' </summary>
    <Extension()>
    Public Sub extSetCustomFormat1(dgv As DataGridView)
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToOrderColumns = False
        dgv.AllowUserToResizeColumns = False
        dgv.AllowUserToResizeRows = False
        dgv.MultiSelect = False
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.AutoGenerateColumns = False
    End Sub

    ''' <summary>
    ''' Lock all feature, Cell Select
    ''' </summary>
    <Extension()>
    Public Sub extSetCustomFormat2(dgv As DataGridView)
        dgv.ReadOnly = True
        dgv.SelectionMode = DataGridViewSelectionMode.CellSelect
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.AllowUserToOrderColumns = False
        dgv.AllowUserToResizeColumns = False
        dgv.AllowUserToResizeRows = False
        dgv.MultiSelect = False
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgv.AutoGenerateColumns = False
    End Sub

    <Extension()>
    Public Sub extLockColumnByIndex(dgv As DataGridView, ParamArray colIndex() As Byte)
        Try
            For Each pos As Byte In colIndex
                dgv.Columns(pos).ReadOnly = True
            Next
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    <Extension()>
    Public Sub extLockColumnByName(dgv As DataGridView, ParamArray colName() As String)
        Try
            For Each str As String In colName
                dgv.Columns(str).ReadOnly = True
            Next
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    <Extension()>
    Public Sub UnlockColumnByIndex(dgv As DataGridView, ParamArray colIndex() As Byte)
        Try
            For Each pos As Byte In colIndex
                dgv.Columns(pos).ReadOnly = False
            Next
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    <Extension()>
    Public Sub extUnlockColumnByName(dgv As DataGridView, ParamArray colName() As String)
        Try
            For Each str As String In colName
                dgv.Columns(str).ReadOnly = False
            Next
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    <Extension()>
    Public Sub extUnlockAllColumn(dgv As DataGridView)
        Try
            For Each col As DataGridViewColumn In dgv.Columns
                col.ReadOnly = False
            Next
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    <Extension()>
    Public Sub extLockAllColumn(dgv As DataGridView)
        Try
            For Each col As DataGridViewColumn In dgv.Columns
                col.ReadOnly = True
            Next
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    <Extension()>
    Public Function extRememberFillPos(dgv As DataGridView, Optional memSlot As Byte = 1) As Object
        Try
            Dim index As Byte = 0
            Dim fp() As SByte
            If memSlot < 1 Or memSlot > 5 Then
                Throw New FormatException
            End If
            ReDim fp(0)
            fp(0) = -1
            For i As Byte = 0 To dgv.Columns.Count - 1
                Dim col As DataGridViewColumn = dgv.Columns(i)
                If col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill Then
                    ReDim Preserve fp(index)
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                    fp(index) = i
                    index += 1
                End If
            Next
            Select Case memSlot
                Case 1
                    ReDim fillPos1(fp.GetUpperBound(0))
                    fillPos1 = fp
                Case 2
                    ReDim fillPos2(fp.GetUpperBound(0))
                    fillPos2 = fp
                Case 3
                    ReDim fillPos3(fp.GetUpperBound(0))
                    fillPos3 = fp
                Case 4
                    ReDim fillPos4(fp.GetUpperBound(0))
                    fillPos4 = fp
                Case 5
                    ReDim fillPos5(fp.GetUpperBound(0))
                    fillPos5 = fp
            End Select
        Catch ex As Exception
            If TypeOf ex Is FormatException Then
                quickMessage.showError("RememberFillPos() : Only memSlot 1 to 5 is available. Please refrain from using others!")
            Else
                quickMessage.showError(ex.ToString)
            End If
            Return Nothing
        End Try
        Return Nothing
    End Function

    <Extension()>
    Public Function extRecallFillPos(dgv As DataGridView, Optional memSlot As Byte = 1) As Object
        Try
            Dim fp() As SByte
            Select Case memSlot
                Case 1
                    fp = fillPos1
                Case 2
                    fp = fillPos2
                Case 3
                    fp = fillPos3
                Case 4
                    fp = fillPos4
                Case 5
                    fp = fillPos5
                Case Else
                    Throw New FormatException
            End Select
            For i As Byte = 0 To fp.GetUpperBound(0)
                If fp(i) = -1 Then
                    Return Nothing
                End If
                Dim col As DataGridViewColumn = dgv.Columns(fp(i))
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next
        Catch ex As Exception
            If TypeOf ex Is FormatException Then
                quickMessage.showError("RecallFillPos() : Only memSlot number 1 to 5 memSlot is available. Please refrain from using others!")
            Else
                quickMessage.showError(ex.ToString)
            End If
            Return Nothing
        End Try
        Return Nothing
    End Function
End Module
