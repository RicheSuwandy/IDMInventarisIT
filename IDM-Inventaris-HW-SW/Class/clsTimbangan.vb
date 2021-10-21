Imports System.Threading
Imports System.IO.Ports

Public Class clsTimbangan
    'Dim myPort As Array  'COM Ports detected on the system will be stored here
    'Delegate Sub SetTextCallback(ByVal [text] As String) 'Added to prevent threading errors during receiveing of data

    'Sub scaleConnection()
    '    Dim serialPort As New SerialPort
    '    Try
    '        myPort = IO.Ports.SerialPort.GetPortNames()
    '        MessageBox.Show(myPort(2).ToString) 'Check Serial Port
    '        serialPort.PortName = myPort(2).ToString 'Set SerialPort1 to the selected COM port at startup
    '        If serialPort.IsOpen = False Then

    '            serialPort.BaudRate = 9600       'Set Baud rate to the selected value on 

    '            'Other Serial Port Property
    '            serialPort.Parity = IO.Ports.Parity.None
    '            serialPort.StopBits = IO.Ports.StopBits.One
    '            serialPort.DataBits = 8 'Open our serial port
    '            serialPort.Open()
    '        End If
    '    Catch ex As Exception
    '        quickMessage.showError(ex.ToString)
    '    End Try
    'End Sub

    'Sub ReceivedText(ByVal Text As String, ByVal Label As Label)
    '    Try
    '        If Label.InvokeRequired Then
    '            Dim x As New SetTextCallback(AddressOf ReceivedText)
    '            Me.Invoke(x, New Object() {(Text)})
    '        Else
    '            lblBerat.Text = Mid(Text, 8, 7)
    '            nilai = Mid(Text, 8, 7).Trim
    '        End If
    '    Catch ex As Exception
    '        quickMessage.showError(ex.ToString)
    '    End Try
    '    '  compares the ID of the creating Thread to the ID of the calling Thread
    'End Sub

End Class
