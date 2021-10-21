Public Class clsStrings

    ''' <summary>
    ''' Parameter must be even.
    ''' Replace 1st string with 2nd string, 3rd string with 4th string, and so on.
    ''' Occurence will repeat from the start.
    ''' </summary>
    Public Function Replace(ByVal sourceString As String, ByVal ParamArray replaceString As String()) As String
        Try
            If replaceString.Length Mod 2 = 1 Then
                Throw New ArgumentException
            End If
            For i As Integer = 0 To (replaceString.Length / 2) - 1
                sourceString = Strings.Replace(sourceString, replaceString(i * 2), replaceString((i * 2) + 1), 1, -1, Constants.vbTextCompare)
            Next
        Catch ex As Exception
            If TypeOf ex Is ArgumentException Then
                quickMessage.showError("Argument count must be even ( multiple of 2 ) to be used on Replace. ")
            Else
                quickMessage.showError(ex.ToString)
            End If
            Return Nothing
        End Try
        Return sourceString
    End Function

End Class
