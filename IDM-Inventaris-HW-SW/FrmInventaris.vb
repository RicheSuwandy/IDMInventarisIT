Imports System
Imports Microsoft.Win32
Imports System.Management
Imports System.Management.Instrumentation
Imports System.Text
Imports System.IO

Public Class FrmInventaris
#Region "Variabel"
    Dim dt As DataTable
    Dim dv As DataView
    Dim SoftwareKey As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Installer\UserData\S-1-5-18\Products"
    Dim skName As String
    Dim rk As RegistryKey
    Dim sname As String = String.Empty
    Dim folder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
    Dim fileinfo As FileInfo
#End Region

#Region "Sub & Function"
    Sub ResetField()
        txtCurUser.Clear()
        txtDepartemen.Clear()
        txtIP.Clear()
        txtKeterangan.Clear()
        txtMonitor.Clear()
        txtNo.Clear()
        txtOS.Clear()
        txtPrinter.Clear()
        txtProsesor.Clear()
        txtScanner.Clear()
        txtSoftware.Clear()
        nudHD.Value = 0
        nudRAM.Value = 0
        nudVersion.Value = 0
        chkSuspend.Checked = False
    End Sub

    Sub LoadInv()
        query = "SELECT NO_INV, CUR_USER, DEPARTEMEN, PROSESOR, STORAGE, RAM, OS, MONITOR, PRINTER, SCANNER, IP, KETERANGAN, LIST_SOFTWARE, SUSPEND, VERSION, LASTUPDATE FROM dbo.tbl_inventaris  order by no_inv"
        dt = dFile.Load(query)
        dt.extPopulateToCombo(cboCari)
        dv = New DataView(dt)
        dgvData.DataSource = dv
    End Sub

    Sub ResetPencarian()
        cboCari.Items.Clear()
        cboCari.Text = ""
        txtCari.Clear()
    End Sub

    Sub SimpanData()
        Dim bolchkstatus As Integer
        If chkSuspend.Checked = False Then
            bolchkstatus = 0
        Else
            bolchkstatus = 1
        End If
        Try
            Dim newversion As Integer
            If dFile.CheckExist("Select * From Tbl_inventaris Where No_Inv = '" & txtNo.Text & "' and version = '" & nudVersion.Value & "'") Then
                newversion = nudVersion.Value + 1
                query = "INSERT INTO dbo.tbl_inventaris (No_Inv, Cur_User, Departemen, Prosesor, Storage, Ram, OS, Monitor, Printer, Scanner, ip, Keterangan, List_Software, Suspend, Version, LastUpdate) VALUES ('@no_inv', '@cur_user', '@departemen', '@prosesor', @storage, @ram, '@os', '@monitor', '@printer', '@scanner', '@ip', '@keterangan', '@list_software', @suspend, @version, '@lastupdate')"
                query = myString.Replace(query, "@no_inv", txtNo.Text, "@cur_user", txtCurUser.Text, "@departemen", txtDepartemen.Text, "@prosesor", txtProsesor.Text, "@storage", nudHD.Value, "@ram", nudRAM.Value, "@os", txtOS.Text, "@monitor", txtMonitor.Text, "@printer", txtPrinter.Text, "@scanner", txtScanner.Text, "@ip", txtIP.Text, "@keterangan", txtKeterangan.Text, "@list_software", txtSoftware.Text, "@suspend", bolchkstatus, "@version", newversion, "@lastupdate", Format(dtpTgl.Value, "dd-MMM-yyyy"))
            Else
                query = "INSERT INTO dbo.tbl_inventaris (No_Inv, Cur_User, Departemen, Prosesor, Storage, Ram, OS, Monitor, Printer, Scanner, ip, Keterangan, List_Software, Suspend, Version, LastUpdate) VALUES ('@no_inv', '@cur_user', '@departemen', '@prosesor', @storage, @ram, '@os', '@monitor', '@printer', '@scanner', '@ip', '@keterangan', '@list_software', @suspend, @version, '@lastupdate')"
                query = myString.Replace(query, "@no_inv", txtNo.Text, "@cur_user", txtCurUser.Text, "@departemen", txtDepartemen.Text, "@prosesor", txtProsesor.Text, "@storage", nudHD.Value, "@ram", nudRAM.Value, "@os", txtOS.Text, "@monitor", txtMonitor.Text, "@printer", txtPrinter.Text, "@scanner", txtScanner.Text, "@ip", txtIP.Text, "@keterangan", txtKeterangan.Text, "@list_software", txtSoftware.Text, "@suspend", bolchkstatus, "@version", nudVersion.Value, "@lastupdate", Format(dtpTgl.Value, "dd-MMM-yyyy"))
            End If
            dFile.Save(query, True)
            lblStatus.Text = "DATA TERSIMPAN / TERUPDATE"
            'MessageBox.Show("TESTING", Me.Text, MessageBoxButtons.OK) 'Tambahan
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    Sub HapusData()
        Try
            If (quickMessage.confirmAction("Apakah Inventori dengan No." & txtNo.Text & " dan Version " & nudVersion.Value & " yakin untuk dihapus ?")) Then
                query = "Delete From tbl_inventaris where no_inv = '" & txtNo.Text & "' and version = '" & nudVersion.Value & "'"
                dFile.Load(query, True)
                lblStatus.Text = "DATA TERHAPUS"
            End If
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    Sub checkField()
        If dFile.CheckExist("Select * From tbl_inventaris where no_inv = '" & txtNo.Text & "' And version = " & nudVersion.Value) Then
            btnPrintChkList.Enabled = True
        Else
            btnPrintChkList.Enabled = False
        End If
    End Sub


    Private Sub GetIPAddress()

        Dim strHostName As String
        Dim strIPAddress As String
        txtCurUser.Text = System.Net.Dns.GetHostName() & "/" & Environment.UserName
        strHostName = System.Net.Dns.GetHostName()
        txtIP.Text = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()
        'MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)
    End Sub



#End Region

    Private Sub FrmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim decHDTotal, decHD As Decimal
        GetIPAddress()
        rk = Registry.LocalMachine.OpenSubKey(SoftwareKey)
        TabControl1.SelectedIndex = 1
        decHDTotal = 0
        decHD = 0
        decHD = My.Computer.FileSystem.Drives.Count
        For i As Integer = 0 To decHD - 1
            If (My.Computer.FileSystem.Drives.Item(i).DriveType.ToString <> "Removable" And My.Computer.FileSystem.Drives.Item(i).DriveType.ToString <> "Network" And My.Computer.FileSystem.Drives.Item(i).DriveType.ToString <> "CDRom") Then
                decHDTotal += My.Computer.FileSystem.Drives.Item(i).TotalSize
            End If
        Next
        nudHD.Value = Math.Round(decHDTotal / 1073741824, 2)
        btnPrintChkList.Enabled = False
        txtOS.Text = My.Computer.Info.OSFullName
        txtNo.Text = "IDM-IT-" & Environment.MachineName & "-" & Format(dtpTgl.Value, "yyyyMMdd")
        'txtCurUser.Text = Environment.UserName
        txtDepartemen.Text = Mid(txtNo.Text, 8, 2)
        Select Case txtDepartemen.Text
            Case "AC"
                txtDepartemen.Text = "ACCOUNTING"
            Case "DG"
                txtDepartemen.Text = "DESIGN"
            Case "FT"
                txtDepartemen.Text = "FACTORY"
            Case "HR"
                txtDepartemen.Text = "HRD"
            Case "IT"
                txtDepartemen.Text = "IT"
            Case "MC"
                txtDepartemen.Text = "MAINTENANCE"
            Case "MK"
                txtDepartemen.Text = "MARKETING"
            Case "PD"
                txtDepartemen.Text = "PRODUKSI"
            Case "PP"
                txtDepartemen.Text = "PPIC"
            Case "PR"
                txtDepartemen.Text = "PURCHASING"
            Case "WH"
                txtDepartemen.Text = "WAREHOUSE"
        End Select
        'txtIP.Text = "192.168.0." & Mid(txtNo.Text, 11, 3)
        nudRAM.Value = Math.Round(My.Computer.Info.TotalPhysicalMemory / 1048576, 2)
        txtProsesor.Text = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0", "ProcessorNameString", "") & " " & My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Session Manager\Environment", "NUMBER_OF_PROCESSORS", "")


        'For Each skName In rk.GetSubKeyNames
        '    Try
        '        sname = Registry.LocalMachine.OpenSubKey(SoftwareKey).OpenSubKey(skName).OpenSubKey("InstallProperties").GetValue("DisplayName")
        '        txtScanner.Text += sname
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'Next
        'Dim intDir As Integer = 0
        'Dim strDir As Object
        'Dim strSubDir As String = ""
        'txtSoftware.Text = My.Computer.FileSystem.GetDirectories("C:\Program Files\")
        'intDir = My.Computer.FileSystem.SpecialDirectories.ProgramFiles.Length
        'For i = 0 To My.Computer.FileSystem.SpecialDirectories.ProgramFiles.Length
        'ListBox1.Items.Add(My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.SpecialDirectories.ProgramFiles))
        'strDir = My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.SpecialDirectories.ProgramFiles).ToString
        'txtSoftware.Text += strDir
        'strSubDir = strDir.Substring(17) + ", "

        'Next
        For Each foundFile As String In My.Computer.FileSystem.GetDirectories(My.Computer.FileSystem.SpecialDirectories.ProgramFiles)
            substrfoundfile = foundFile.Substring(17) + "; "
            txtSoftware.Text += substrfoundfile
            ListBox1.Items.Add(substrfoundfile)
        Next
        Call LoadInv()

    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call ResetField()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Call SimpanData()
        Call ResetField()
        Call LoadInv()
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Call HapusData()
        Call ResetField()
        Call LoadInv()
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        TabControl1.SelectedIndex = 1
        Call LoadInv()
    End Sub

    Private Sub dgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellDoubleClick
        Try
            Dim baris As Integer
            baris = dgvData.CurrentCell.RowIndex
            txtNo.Text = dgvData.Item(0, baris).Value
            txtCurUser.Text = dgvData.Item(1, baris).Value
            txtDepartemen.Text = dgvData.Item(2, baris).Value
            txtProsesor.Text = dgvData.Item(3, baris).Value
            nudHD.Value = CDec(dgvData.Item(4, baris).Value)
            nudRAM.Value = CDec(dgvData.Item(5, baris).Value)
            txtOS.Text = dgvData.Item(6, baris).Value
            txtMonitor.Text = dgvData.Item(7, baris).Value
            txtPrinter.Text = dgvData.Item(8, baris).Value
            txtScanner.Text = dgvData.Item(9, baris).Value
            txtIP.Text = dgvData.Item(10, baris).Value
            txtKeterangan.Text = dgvData.Item(11, baris).Value
            txtSoftware.Text = dgvData.Item(12, baris).Value
            chkSuspend.Checked = dgvData.Item(13, baris).Value
            nudVersion.Value = dgvData.Item(14, baris).Value
            dtpTgl.Value = dgvData.Item(15, baris).Value
            TabControl1.SelectedIndex = 0
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try
    End Sub

    Private Sub txtNo_TextChanged(sender As Object, e As EventArgs) Handles txtNo.TextChanged
        Call checkField()
    End Sub

    Private Sub dgvData_SelectionChanged(sender As Object, e As EventArgs) Handles dgvData.SelectionChanged
        If dgvData.SelectedCells.Count > 0 Then
            btnPrintChkList.Enabled = True
        End If
    End Sub

    Private Sub cboCari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCari.SelectedIndexChanged
        Call dv.extSetSearchFilter(cboCari.Text, txtCari.Text)
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Call dv.extSetSearchFilter(cboCari.Text, txtCari.Text)
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Call LoadInv()
    End Sub

    Private Sub chkSuspend_CheckedChanged(sender As Object, e As EventArgs) Handles chkSuspend.CheckedChanged

        If chkSuspend.Checked Then
            query = "Update Tbl_inventaris Set Suspend = 1 where No_Inv = '@no_inv' and version = 0"
            query = myString.Replace(query, "@no_inv", txtNo.Text)
            dFile.Save(query, True)
            lblStatus.Text = "DATA TERSIMPAN / TERUPDATE"
            chkSuspend.Checked = True
        Else

        End If

    End Sub

    Private Sub chkSuspend_CheckStateChanged(sender As Object, e As EventArgs) Handles chkSuspend.CheckStateChanged
    End Sub

    'Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
    '    JenisLap = "Label"
    '    FrmPrintPreview.ShowDialog()
    'End Sub

    Private Sub btnPrintInv_Click(sender As Object, e As EventArgs) Handles btnPrintChkList.Click
        JenisLap = "Inventaris"
        FrmPrintPreview.ShowDialog()
    End Sub

    Private Sub btnCmd_Click(sender As Object, e As EventArgs) Handles btnCmd.Click
        Dim regKey As RegistryKey
        Dim ver As Decimal
        'opens the path USBSTOR from regedit
        Try
            If rbtnDisable.Checked Then
                If MsgBox("All USB Ports Will Be Disabled Except The Presently Connected Ports (Ex.,USB Mouse,Printer etc !) ", MsgBoxStyle.OkCancel, "ARE YOU SURE ?!") = MsgBoxResult.Ok Then
                    regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
                    regKey.SetValue("Start", 4) ' 4(To disable the ports)
                End If
            Else
                regKey = Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\USBSTOR", True)
                regKey.SetValue("Start", 3) ' 3(To enable the ports)
                MsgBox("Ports Are Enabled !", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            quickMessage.showError(ex.ToString)
        End Try

    End Sub

    Private Sub btnDepartemen_Click(sender As Object, e As EventArgs)
        JenisLap = "Departemen"
        FrmPrintPreview.ShowDialog()
    End Sub

    Private Sub btnPrintHW_Click(sender As Object, e As EventArgs) Handles btnPrintHW.Click
        JenisLap = "HW"
        FrmPrintPreview.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnPrintINV.Click
        JenisLap = ""
    End Sub
End Class
