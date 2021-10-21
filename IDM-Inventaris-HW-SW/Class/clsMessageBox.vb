Public Class clsMessageBox

    Public Function DebugMessage(ByVal content As String, Optional ByVal title As String = "DEBUG MESSAGE") As Object
        If isDebug Then
            Clipboard.SetText(content)
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
        Return Nothing
    End Function

    Public Function YesNoAction(ByVal content As String, Optional ByVal title As String = "Action Required") As MsgBoxResult
        Return MessageBox.Show(content, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Function

    Public Function showError(ByVal content As String, Optional ByVal title As String = "SYSTEM ERROR!") As Object
        MessageBox.Show("Harap Hubungi Programmer anda disertai dengan Error dibawah ini : " & vbCrLf & content, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Return Nothing
    End Function

    Public Function showInfo(ByVal content As String, Optional ByVal title As String = "Information") As Object
        MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return Nothing
    End Function

    Public Function showWarning(ByVal content As String, Optional ByVal title As String = "Warning") As Object
        MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return Nothing
    End Function

    Public Function confirmAction(ByVal content As String, Optional ByVal title As String = "Confirmation Required") As DialogResult
        Return MessageBox.Show(content, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    End Function

End Class
