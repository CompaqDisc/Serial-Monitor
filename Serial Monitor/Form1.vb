Public Class SerialMonitorApp
    Dim COMList As Array
    Delegate Sub SetTextCallback(ByVal [text] As String)
    Private Sub SerialMonitorApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        COMList = IO.Ports.SerialPort.GetPortNames()
        For i = 0 To UBound(COMList)
            PortList.Items.Add(COMList(i))
        Next
        BaudList.Items.Add(9600)
        BaudList.Items.Add(19200)
        BaudList.Items.Add(38400)
        BaudList.Items.Add(57600)
        BaudList.Items.Add(115200)
        Try
            PortList.Text = PortList.Items.Item(0)
        Catch
            WarnText.Text = "No Ports Found!" & vbNewLine & "Try Refreshing?" & vbNewLine & "Click 'Ok' to Dismiss Warnings."
        End Try
        BaudList.Text = BaudList.Items.Item(0)
        DisconnectBtn.Enabled = False
    End Sub

    Private Sub ConnectBtn_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click
        Try
            SerialPort.PortName = PortList.Text
            SerialPort.BaudRate = BaudList.Text
            SerialPort.Open()
            DisconnectBtn.Enabled = True
            ConnectBtn.Enabled = False
        Catch
            WarnText.Text = "No Ports Found!" & vbNewLine & "May be Disconnected?" & vbNewLine & "Try Refreshing?" & vbNewLine & "Click 'Ok' to Dismiss Warnings."
        End Try
    End Sub

    Private Sub DisconnectBtn_Click(sender As Object, e As EventArgs) Handles DisconnectBtn.Click
        SerialPort.Close()
        ConnectBtn.Enabled = True
        DisconnectBtn.Enabled = False
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        PortList.Text = "Loading..."
        PortList.Items.Clear()
        COMList = IO.Ports.SerialPort.GetPortNames()
        For i = 0 To UBound(COMList)
            PortList.Items.Add(COMList(i))
        Next
        Try
            PortList.Text = PortList.Items.Item(0)
        Catch
            WarnText.Text = "No Ports Found!" & vbNewLine & "Try Refreshing?" & vbNewLine & "Click 'Ok' to Dismiss Warnings."
            PortList.Text = "No Ports!"
        End Try
    End Sub

    Private Sub WarnOkBtn_Click(sender As Object, e As EventArgs) Handles WarnOkBtn.Click
        WarnText.Text = ""
    End Sub

    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        Try
            SerialPort.WriteLine(SendText.Text)
            SendText.Text = ""
        Catch
            WarnText.Text = "Not Connected to Port!" & vbNewLine & "Press 'Connect' Button." & vbNewLine & "Click 'Ok' to Dismiss Warnings."
        End Try
    End Sub
    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        ReceivedText(SerialPort.ReadExisting())
    End Sub

    Private Sub ReceivedText(ByVal [text] As String)
        If Me.RecieveText.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else
            Me.RecieveText.Text &= [text]
            RecieveText.Select(RecieveText.TextLength, 0)
            RecieveText.ScrollToCaret()
        End If
    End Sub
    Private Overloads Sub SendText_Return(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SendText.KeyDown
        If e.KeyCode = Keys.Return Then
            Try
                SerialPort.WriteLine(SendText.Text)
                SendText.Text = ""
            Catch
                WarnText.Text = "Not Connected to Port!" & vbNewLine & "Press 'Connect' Button." & vbNewLine & "Click 'Ok' to Dismiss Warnings."
            End Try
        End If
    End Sub

    Private Sub RecieveText_DoubleClick(sender As Object, e As EventArgs) Handles RecieveText.DoubleClick
        RecieveText.Text = ""
    End Sub
End Class
