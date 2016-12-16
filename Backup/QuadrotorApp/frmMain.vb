Public Class frmMain

    Dim strData As String
    Dim intCounter As Integer


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Clear data labels
        lblRollData.Text = ""
        lblPitchData.Text = ""
        lblYawData.Text = ""
        txtMessage.Text = ""


        'Set buttons
        btnStart.Enabled = True
        'btnDisconnect.Enabled = False
        btnDisconnect.Enabled = True


        intCounter = 0



    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        strData = String.Empty

        Try

            If SerialPort.IsOpen Then
                SerialPort.Close()
            End If

            With SerialPort
                .PortName = "COM4"
                .BaudRate = 115200
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
            End With
            SerialPort.Open()

            txtMessage.ForeColor = Color.Black
            txtMessage.AppendText("COM4 connected" & vbCrLf)

            btnStart.Enabled = False

            'For i As Integer = 0 To 100
            '    strData = SerialPort.ReadExisting
            '    If strData.Equals(String.Empty) Then
            '        lblMessage.Text = "No data found"
            '    Else
            '        intCount = intCount + 1
            '        lblMessage.Text = strData
            '    End If
            'Next


            'lblMessage.Text = intCount


            btnDisconnect.Enabled = True

            'strData = SerialPort.ReadLine
            'lblMessage.Text = strData

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Try

            With SerialPort
                .PortName = "COM4"
                .BaudRate = 115200
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
            End With

            SerialPort.Close()
            txtMessage.AppendText(SerialPort.PortName & " disconnected" & vbCrLf)
            btnStart.Enabled = True
            btnDisconnect.Enabled = False

            Process.Start(Application.ExecutablePath)
            Me.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived

        txtMessage.Invoke(New _
                               myDelegate(AddressOf updateLabel), _
                               New Object() {})

   

    End Sub

    Public Delegate Sub myDelegate()
    Public Sub updateLabel()
        Dim strParse() As String = Nothing

        intCounter = intCounter + 1
        Try

            strData = SerialPort.ReadLine()
            'strData = SerialPort.ReadExisting
            txtMessage.AppendText(strData & vbCrLf)


            strData = strData.Trim()

            'If boolReady Then
            'Parse data
            'Example - ATTITUDE: Pitch=0, Roll=2, Yaw=439
            If strData.StartsWith("ATTITUDE:") Then
                strData = strData.Remove(0, 10)
                strParse = strData.Split(",")

                For Each s As String In strParse
                    s = s.Trim()
                    If s.StartsWith("Roll=") Then
                        s = s.Remove(0, 5)
                        lblRollData.Text = s
                    ElseIf s.StartsWith("Yaw=") Then
                        s = s.Remove(0, 4)
                        lblYawData.Text = s
                    ElseIf s.StartsWith("Pitch=") Then
                        s = s.Remove(0, 6)
                        lblPitchData.Text = s
                    End If
                Next

                'strData = "AT+ZV SPPConnect 00043e018400"
                'SerialPort.WriteLine(strData)


            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub






    Private Sub btnSaveLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveLog.Click
        Dim TargetFile As StreamWriter

        Try
            TargetFile = New StreamWriter("QuadrotorDataLog.txt", True)
       
            TargetFile.WriteLine(Now())
            TargetFile.Write(txtMessage.Text)
            TargetFile.WriteLine()
            TargetFile.WriteLine()

            TargetFile.Close()
            MessageBox.Show("Text saved to " & "QuadrotorDataLog.txt")
        Catch ex As Exception
            MsgBox(ex.ToString)
            'MessageBox.Show("Error writing file")
        End Try

        
    End Sub

End Class
