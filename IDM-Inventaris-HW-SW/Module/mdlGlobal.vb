Module mdlGlobal
    'Public Const StrServername As String = "192.168.0.250"
    'Public Const StrDataBase As String = "Production"
    ''Public Const StrPlant As String = "FrmPlant"
    ''Public Const StrUom As String = "FrmUoM"
    ''Public Const StrProduct As String = "FrmProduct"
    ''Public Const StrProses As String = "FrmProsesFrame"
    ''Public Const StrTransactionProcess As String = "FrmTransactionProcess"
    ''Public Const StrReportWasteByProcess As String = "FrmRptWasteByProses"
    ''Public Const StrReportWasteByPlant As String = "FrmWasteByPlant"
    ''Public Const StrLapWaste As String = "FrmLapWaste"

    Public KeyID As New clsKeyID
    Public ObjConn As New SqlClient.SqlConnection()
    'Public inOut As Boolean

    Public crypter As New clsCrypter
    Public clipper As New clsClipper
    Public myString As New clsStrings

    Public Const def_serverName As String = "192.168.0.250\SQL2012"
    'Public Const serverName As String = "192.168.0.250"
    Public Const def_dBaseName As String = "IDMInventaris"
    Public Const def_userName As String = "ccS+LmuP8yucrwI2dgqSmw=="
    Public Const def_password As String = "I65sd65T6fMlzvyHoIxXKg=="

    Public useDefault As Boolean = True
    'Public serverName As String = "192.168.0.150\SQLEXPRESS"
    Public serverName As String = "192.168.0.250\SQL2012"
    Public dBaseName As String = "IDMInventaris"
    Public userName As String = "ccS+LmuP8yucrwI2dgqSmw=="
    Public password As String = "I65sd65T6fMlzvyHoIxXKg=="
    Public Const key1 As String = "Benson"
    Public Const key2 As String = "Indomas"

    Public query As String = ""
    Public fullQuery As String = ""
    Public dFile As New clsDataFile
    Public ModuleName As New clsModuleName
    Public quickMessage As New clsMessageBox
    Public Settings As New clsSettings
    'Public Timbangan As New clsTimbangan

    Public sessionUser As String = ""
    Public isAdmin As Boolean = False
    Public isDebug As Boolean = False

    Public JenisLap As String
End Module
