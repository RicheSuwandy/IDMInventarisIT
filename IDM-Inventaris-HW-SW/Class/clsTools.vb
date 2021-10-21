#Region "Reference"
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Imports System.Management
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Net.NetworkInformation
#End Region

Public Class clsTools

    Public Function initReminder(ByVal obj As clsReminder) As Object
        With obj.Item
            .ChequeCode.name = "ChequeCode"
            .Value.name = "Value"
            .BankOrigin.name = "BankOrigin"
            .CashingDate.name = "CashingDate"
            .BankTarget.name = "BankTarget"
            .AccountTarget.name = "AccountTarget"
            .RemindStatus.name = "RemindStatus"
            .RemindStart.name = "RemindStart"
            .RemindLast.name = "RemindLast"
        End With
        Return obj
    End Function

    Public Function GetMAC() As String
        Dim networkcard() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        GetMAC = networkcard(0).GetPhysicalAddress.ToString & vbCrLf
        Return GetMAC
    End Function

    Public Function Encrypt(ByVal plainText As String) As String
        Dim creatorKey As String = "uy3n"
        Dim companyKey As String = "uy3n"
        Dim hashAlgorithm As String = "SHA1"
        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(companyKey)
        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)
        Dim password As New PasswordDeriveBytes(creatorKey, saltValueBytes, hashAlgorithm, passwordIterations)
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC
        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)
        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function

    Public Function CheckFolderExist(ByVal _fileloc As String) As Object
        If Directory.Exists(_fileloc) Then
            Return True
        End If
        Return False
    End Function

    Public Function CheckFileExist(ByVal _filename As String) As Object
        If File.Exists(_filename) Then
            Return True
        End If
        Return False
    End Function

    Public Function CreateDefaultConfig(ByVal fLoc As String, ByVal fName As String) As Object
        Dim sw As StreamWriter
        Try
            If Not CheckFolderExist(fLoc) Then
                Directory.CreateDirectory(fLoc)
            End If
            sw = New StreamWriter(fLoc & fName, False)
            sw.Write(fileDefault)
        Catch ex As Exception
            MessageBox.Show("Failed to create default config, please ensure Drive C:\ is not protected.")
            Return False
        Finally
            sw.Close()
        End Try
        Return True
    End Function

    Public Function GetServerConfig(ByVal _filename As String) As Object
        Dim res As New ServerConfig
        Dim sr As StreamReader
        Try
            sr = New StreamReader(_filename)
            For i = 1 To 3
                sr.ReadLine()
            Next
            res.server = sr.ReadLine
            For i = 1 To 2
                sr.ReadLine()
            Next
            res.database = sr.ReadLine
        Catch ex As Exception
            MessageBox.Show("Failed to get config, please ensure Drive C:\ is not protected.")
        Finally
            sr.Close()
        End Try
        Return res
    End Function

    Public Function CreateVersion() As Object
        Dim regKey As RegistryKey
        Dim key1 As String = GetMAC()
        regKey = Registry.LocalMachine.OpenSubKey("Software", True)
        regKey.CreateSubKey("PRJ_RMD")
        regKey = Registry.LocalMachine.OpenSubKey("Software\PRJ_RMD", True)
        regKey.SetValue("key1", key1)
        regKey.SetValue("version", version)
        Return Nothing
    End Function

    Public Function CheckVersion() As Boolean
        Dim regKey As RegistryKey
        Dim key1 As String
        Try
            regKey = Registry.LocalMachine.OpenSubKey("Software\Prj_Rmd", True)
            key1 = regKey.GetValue("key1")
            If Encrypt(GetMAC) = key1 Then
                Return True
            End If
        Catch ex As Exception
            Call CreateVersion()
            Return False
        End Try
        Return False
    End Function

    Public Function TryConnect(ByVal ReturnMessage As Boolean) As Boolean
        Try
            dataFile.myConn.Open()
        Catch ex As Exception
            If ReturnMessage Then
                MessageBox.Show("Connection error : mySql database is not ready" & vbCrLf & "- Please launch the XAMPP-APACHE/MYSQL_SERVER " & vbCrLf &
                            "- Make sure database is available." & vbCrLf & vbCrLf & "Please contact the administrator." & vbCrLf & "System is exiting.",
                            "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Return False
        Finally
            dataFile.myConn.Close()
        End Try
        Return True
    End Function

End Class
