Public Class clsMode

    Public Event Changed()
    Public Event ChangedToIdle()
    Public Event ChangedToLoading()
    Public Event ChangedToNew()
    Public Event ChangedToEdit()
    Public Event ChangedToView()
    Public Event ChangedToLock()
    Private mstrname As String

    Public Sub New(Optional ByVal mode As String = "idle")
        Name = mode
    End Sub

    Public Property Name() As String
        Get
            Name = mstrname
        End Get
        Set(ByVal value As String)
            mstrname = value
            RaiseEvent Changed()
        End Set
    End Property

    Public Function setLoading() As Object
        Name = "loading"
        RaiseEvent ChangedToLoading()
        Return Nothing
    End Function

    Public Function setIdle() As Object
        Name = "idle"
        RaiseEvent ChangedToIdle()
        Return Nothing
    End Function

    Public Function setNew() As Object
        Name = "new"
        RaiseEvent ChangedToNew()
        Return Nothing
    End Function

    Public Function setEdit() As Object
        Name = "edit"
        RaiseEvent ChangedToEdit()
        Return Nothing
    End Function

    Public Function setView() As Object
        Name = "view"
        RaiseEvent ChangedToView()
        Return Nothing
    End Function

    Public Function setLock() As Object
        Name = "lock"
        RaiseEvent ChangedToLock()
        Return Nothing
    End Function

    Public Function isLoading() As Boolean
        If Name = "loading" Then
            Return True
        End If
        Return False
    End Function

    Public Function isIdle() As Boolean
        If Name = "idle" Then
            Return True
        End If
        Return False
    End Function

    Public Function isNew() As Boolean
        If Name = "new" Then
            Return True
        End If
        Return False
    End Function

    Public Function isEdit() As Boolean
        If Name = "edit" Then
            Return True
        End If
        Return False
    End Function

    Public Function isView() As Boolean
        If Name = "view" Then
            Return True
        End If
        Return False
    End Function

    Public Function isLock() As Boolean
        If Name = "lock" Then
            Return True
        End If
        Return False
    End Function

End Class
