Public Class clsClipper
#Region "Encryption & Description"
    Private avarSeedValues() As String
    Private astrEncryptionKey(0 To 131) As String
    Private lngSeedLevel As Long
    Private lngDecryptPointer As Long
    Public Function Decrypt(ByVal strData As String, ByVal strCryptKey As String) As String
        Dim strDecryptionChunk As String
        Dim strDecryptedText As String = ""
        On Error Resume Next
        InitCrypt(strCryptKey)
        Do Until Len(strData) < 16
            strDecryptionChunk = ""
            strDecryptionChunk = Left$(strData, 16)
            strData = Right$(strData, Len(strData) - 16)
            If Len(strDecryptionChunk) > 0 Then
                strDecryptedText = strDecryptedText + PerformClipperDecryption(strDecryptionChunk)
            End If
        Loop
        Return strDecryptedText
    End Function

    Private Sub InitCrypt(ByRef strEncryptionKey As String)
        Dim m() As String = New String(255) {"A3", "D7", "09", "83", "F8", "48", "F6", "F4", "B3", "21", "15", "78", "99", "B1", "AF", _
        "F9", "E7", "2D", "4D", "8A", "CE", "4C", "CA", "2E", "52", "95", "D9", "1E", "4E", "38", "44", "28", "0A", "DF", _
        "02", "A0", "17", "F1", "60", "68", "12", "B7", "7A", "C3", "E9", "FA", "3D", "53", "96", "84", "6B", "BA", "F2", _
        "63", "9A", "19", "7C", "AE", "E5", "F5", "F7", "16", "6A", "A2", "39", "B6", "7B", "0F", "C1", "93", "81", "1B", _
        "EE", "B4", "1A", "EA", "D0", "91", "2F", "B8", "55", "B9", "DA", "85", "3F", "41", "BF", "E0", "5A", "58", "80", _
        "5F", "66", "0B", "D8", "90", "35", "D5", "C0", "A7", "33", "06", "65", "69", "45", "00", "94", "56", "6D", "98", _
        "9B", "76", "97", "FC", "B2", "C2", "B0", "FE", "DB", "20", "E1", "EB", "D6", "E4", "DD", "47", "4A", "1D", "42", _
        "ED", "9E", "6E", "49", "3C", "CD", "43", "27", "D2", "07", "D4", "DE", "C7", "67", "18", "89", "CB", "30", "1F", _
        "8D", "C6", "8F", "AA", "C8", "74", "DC", "C9", "5D", "5C", "31", "A4", "70", "88", "61", "2C", "9F", "0D", "2B", _
        "87", "50", "82", "54", "64", "26", "7D", "03", "40", "34", "4B", "1C", "73", "D1", "C4", "FD", "3B", "CC", "FB", _
        "7F", "AB", "E6", "3E", "5B", "A5", "AD", "04", "23", "9C", "14", "51", "22", "F0", "29", "79", "71", "7E", "FF", _
        "8C", "0E", "E2", "0C", "EF", "BC", "72", "75", "6F", "37", "A1", "EC", "D3", "8E", "62", "8B", "86", "10", "E8", _
        "08", "77", "11", "BE", "92", "4F", "24", "C5", "32", "36", "9D", "CF", "F3", "A6", "BB", "AC", "5E", "6C", "A9", _
        "13", "57", "25", "B5", "E3", "BD", "A8", "3A", "01", "05", "59", "2A", "46"}
        avarSeedValues = m
        SetKey(strEncryptionKey)
    End Sub
    Private Sub SetKey(ByVal strEncryptionKey As String)
        Dim intEncryptionKeyIterator As Integer
        For intEncryptionKeyIterator = 0 To 131 Step 10
            If intEncryptionKeyIterator = 130 Then
                astrEncryptionKey(intEncryptionKeyIterator + 0) = Mid(strEncryptionKey, 1, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 1) = Mid(strEncryptionKey, 3, 2)
            Else
                astrEncryptionKey(intEncryptionKeyIterator + 0) = Mid(strEncryptionKey, 1, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 1) = Mid(strEncryptionKey, 3, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 2) = Mid(strEncryptionKey, 5, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 3) = Mid(strEncryptionKey, 7, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 4) = Mid(strEncryptionKey, 9, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 5) = Mid(strEncryptionKey, 11, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 6) = Mid(strEncryptionKey, 13, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 7) = Mid(strEncryptionKey, 15, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 8) = Mid(strEncryptionKey, 17, 2)
                astrEncryptionKey(intEncryptionKeyIterator + 9) = Mid(strEncryptionKey, 19, 2)
            End If
        Next
    End Sub

    Private Function PerformClipperDecryption(ByVal strData As String) As String
        Dim bytChunk(0 To 4, 0 To 32) As String
        Dim bytCounter(0 To 32) As Byte
        Dim lngIterator As Long
        Dim strDecryptedData As String
        On Error Resume Next
        bytChunk(0, 32) = Mid(strData, 1, 4)
        bytChunk(1, 32) = Mid(strData, 5, 4)
        bytChunk(2, 32) = Mid(strData, 9, 4)
        bytChunk(3, 32) = Mid(strData, 13, 4)
        lngSeedLevel = 32
        lngDecryptPointer = 31
        For lngIterator = 0 To 32
            bytCounter(lngIterator) = lngIterator + 1
        Next lngIterator
        For lngIterator = 1 To 8
            bytChunk(0, lngSeedLevel - 1) = PerformClipperDecryptionChunk(bytChunk(1, lngSeedLevel), astrEncryptionKey)
            bytChunk(1, lngSeedLevel - 1) = PerformXOR(PerformClipperDecryptionChunk(bytChunk(1, lngSeedLevel), astrEncryptionKey), PerformXOR(bytChunk(2, lngSeedLevel), Hex(bytCounter(lngSeedLevel - 1))))
            bytChunk(2, lngSeedLevel - 1) = bytChunk(3, lngSeedLevel)
            bytChunk(3, lngSeedLevel - 1) = bytChunk(0, lngSeedLevel)
            lngDecryptPointer = lngDecryptPointer - 1
            lngSeedLevel = lngSeedLevel - 1
        Next lngIterator
        For lngIterator = 1 To 8
            bytChunk(0, lngSeedLevel - 1) = PerformClipperDecryptionChunk(bytChunk(1, lngSeedLevel), astrEncryptionKey)
            bytChunk(1, lngSeedLevel - 1) = bytChunk(2, lngSeedLevel)
            bytChunk(2, lngSeedLevel - 1) = bytChunk(3, lngSeedLevel)
            bytChunk(3, lngSeedLevel - 1) = PerformXOR(PerformXOR(bytChunk(0, lngSeedLevel), bytChunk(1, lngSeedLevel)), Hex(bytCounter(lngSeedLevel - 1)))
            lngDecryptPointer = lngDecryptPointer - 1
            lngSeedLevel = lngSeedLevel - 1
        Next lngIterator
        For lngIterator = 1 To 8
            bytChunk(0, lngSeedLevel - 1) = PerformClipperDecryptionChunk(bytChunk(1, lngSeedLevel), astrEncryptionKey)
            bytChunk(1, lngSeedLevel - 1) = PerformXOR(PerformClipperDecryptionChunk(bytChunk(1, lngSeedLevel), astrEncryptionKey), PerformXOR(bytChunk(2, lngSeedLevel), Hex(bytCounter(lngSeedLevel - 1))))
            bytChunk(2, lngSeedLevel - 1) = bytChunk(3, lngSeedLevel)
            bytChunk(3, lngSeedLevel - 1) = bytChunk(0, lngSeedLevel)
            lngDecryptPointer = lngDecryptPointer - 1
            lngSeedLevel = lngSeedLevel - 1
        Next lngIterator
        For lngIterator = 1 To 8
            bytChunk(0, lngSeedLevel - 1) = PerformClipperDecryptionChunk(bytChunk(1, lngSeedLevel), astrEncryptionKey)
            bytChunk(1, lngSeedLevel - 1) = bytChunk(2, lngSeedLevel)
            bytChunk(2, lngSeedLevel - 1) = bytChunk(3, lngSeedLevel)
            bytChunk(3, lngSeedLevel - 1) = PerformXOR(PerformXOR(bytChunk(0, lngSeedLevel), bytChunk(1, lngSeedLevel)), Hex(bytCounter(lngSeedLevel - 1)))
            lngDecryptPointer = lngDecryptPointer - 1
            lngSeedLevel = lngSeedLevel - 1
        Next lngIterator
        strDecryptedData = HexToString(bytChunk(0, 0) & bytChunk(1, 0) & bytChunk(2, 0) & bytChunk(3, 0))
        If InStr(strDecryptedData, "" & Chr(0)) > 0 Then
            strDecryptedData = Left$(strDecryptedData, InStr(strDecryptedData, Chr(0)) - 1)
        End If
        Return strDecryptedData
    End Function


    Private Function PerformClipperDecryptionChunk(ByVal strData As String, ByRef strEncryptionKey() As String) As String
        Dim astrDecryptionLevel(0 To 5) As String
        Dim strDecryptedString As String
        astrDecryptionLevel(4) = Mid(strData, 1, 2)
        astrDecryptionLevel(5) = Mid(strData, 3, 2)
        strDecryptedString = avarSeedValues(CByte(PerformTranslation(PerformXOR(astrDecryptionLevel(4), strEncryptionKey((4 * lngDecryptPointer) + 3)))))
        astrDecryptionLevel(3) = PerformXOR(strDecryptedString, astrDecryptionLevel(5))
        strDecryptedString = avarSeedValues(CByte(PerformTranslation(PerformXOR(astrDecryptionLevel(3), strEncryptionKey((4 * lngDecryptPointer) + 2)))))
        astrDecryptionLevel(2) = PerformXOR(strDecryptedString, astrDecryptionLevel(4))
        strDecryptedString = avarSeedValues(CByte(PerformTranslation(PerformXOR(astrDecryptionLevel(2), strEncryptionKey((4 * lngDecryptPointer) + 1)))))
        astrDecryptionLevel(1) = PerformXOR(strDecryptedString, astrDecryptionLevel(3))
        strDecryptedString = avarSeedValues(CByte(PerformTranslation(PerformXOR(astrDecryptionLevel(1), strEncryptionKey(4 * lngDecryptPointer)))))
        astrDecryptionLevel(0) = PerformXOR(strDecryptedString, astrDecryptionLevel(2))
        strDecryptedString = astrDecryptionLevel(0) & astrDecryptionLevel(1)
        Return strDecryptedString
    End Function

    Private Function PerformTranslation(ByVal strData As String) As Double
        Dim strTranslationString As String
        Dim strTranslationChunk As String
        Dim lngTranslationIterator As Long
        Dim lngHexConversion As Long
        Dim lngHexConversionIterator As Long
        Dim dblTranslation As Double
        Dim lngTranslationMarker As Long
        Dim lngTranslationModifier As Long
        Dim lngTranslationLayerModifier As Long
        strTranslationString = strData
        strTranslationString = Right$(strTranslationString, 8)
        strTranslationChunk = New String("0", 8 - Len(strTranslationString)) & strTranslationString
        strTranslationString = ""
        For lngTranslationIterator = 1 To 8
            lngHexConversion = Val("&H" + Mid$(strTranslationChunk, lngTranslationIterator, 1))
            For lngHexConversionIterator = 3 To 0 Step -1
                If lngHexConversion And 2 ^ lngHexConversionIterator Then
                    strTranslationString = strTranslationString + "1"
                Else
                    strTranslationString = strTranslationString + "0"
                End If
            Next lngHexConversionIterator
        Next lngTranslationIterator
        dblTranslation = 0
        For lngTranslationIterator = Len(strTranslationString) To 1 Step -1
            If Mid(strTranslationString, lngTranslationIterator, 1) = "1" Then
                lngTranslationLayerModifier = 1
                lngTranslationMarker = (Len(strTranslationString) - lngTranslationIterator)
                lngTranslationModifier = 2
                Do While lngTranslationMarker > 0
                    Do While (lngTranslationMarker / 2) = (lngTranslationMarker \ 2)
                        lngTranslationModifier = (lngTranslationModifier * lngTranslationModifier) Mod 255
                        lngTranslationMarker = lngTranslationMarker / 2
                    Loop
                    lngTranslationLayerModifier = (lngTranslationModifier * lngTranslationLayerModifier) Mod 255
                    lngTranslationMarker = lngTranslationMarker - 1
                Loop
                dblTranslation = dblTranslation + lngTranslationLayerModifier
            End If
        Next lngTranslationIterator
        Return dblTranslation
    End Function
    Private Function PerformXOR(ByVal strData As String, ByVal strMask As String) As String
        Dim strXOR As String = ""
        Dim lngXORIterator As Long
        Dim lngXORMarker As Long
        lngXORMarker = Len(strData) - Len(strMask)
        If lngXORMarker < 0 Then
            strXOR = Left$(strMask, Math.Abs(lngXORMarker))
            strMask = Mid$(strMask, Math.Abs(lngXORMarker) + 1)
        ElseIf lngXORMarker > 0 Then
            strXOR = Left$(strData, Math.Abs(lngXORMarker))
            strData = Mid$(strData, lngXORMarker + 1)
        End If
        For lngXORIterator = 1 To Len(strData)
            strXOR = strXOR + Hex$(Val("&H" + Mid$(strData, lngXORIterator, 1)) Xor Val("&H" + Mid$(strMask, lngXORIterator, 1)))
        Next lngXORIterator
        Return Right(strXOR, 8)
    End Function
    Private Function HexToString(ByVal strData As String) As String
        Dim strOutput As String = ""
        Do Until Len(strData) < 2
            strOutput = strOutput + Chr(CLng("&H" + Left$(strData, 2)))
            strData = Right$(strData, Len(strData) - 2)
        Loop
        Return strOutput
    End Function
#End Region
End Class
