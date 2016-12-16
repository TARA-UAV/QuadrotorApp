Public Class frmMain

    Dim strData As String
    ' Dim boolConnect As Boolean
    'Dim boolReady As Boolean


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'boolReady = False
        'boolConnect = False

        'Clear data labels
        lblRollData.Text = ""
        lblPitchData.Text = ""
        lblYawData.Text = ""
        lblLongData.Text = ""
        lblLatData.Text = ""
        lblAltData.Text = ""
        txtMessage.Text = ""
        lblFrontData.Text = ""
        lblBackData.Text = ""
        lblRightData.Text = ""
        lblLeftData.Text = ""

        'Set buttons
        btnStart.Enabled = True
        btnConnect.Enabled = False
        btnDisconnect.Enabled = False

    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        strData = String.Empty

        Try

            If SerialPort.IsOpen Then
                SerialPort.Close()
            End If

            With SerialPort
                .PortName = "COM1"
                .BaudRate = 115200
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
            End With
            SerialPort.Open()

            txtMessage.ForeColor = Color.Black
            txtMessage.AppendText("COM1 connected" & vbCrLf)

            btnStart.Enabled = False
            btnConnect.Enabled = True
            btnDisconnect.Enabled = True

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




            'strData = SerialPort.ReadLine
            'lblMessage.Text = strData

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Try

            SerialPort.Close()
            txtMessage.ForeColor = Color.Black
            txtMessage.AppendText(SerialPort.PortName & " disconnected" & vbCrLf)
            btnStart.Enabled = True
            btnConnect.Enabled = False
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
        'strData = SerialPort.ReadExisting
        Try
            strData = SerialPort.ReadLine()
            With txtMessage
                .ForeColor = Color.Green
                .AppendText(strData & vbCrLf)
            End With

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


            ElseIf strData.StartsWith("$GPGGA") Then
                'Example - $GPGGA,163610.000,4521.6445,N,07538.7722,W,1,05,2.9,104.6,M,-34.1,M,,0000*63
                strParse = strData.Split(",")
                lblLatData.Text = strParse(2).ToString & " " & strParse(3).ToString
                lblLongData.Text = strParse(4).ToString & " " & strParse(5).ToString
                lblAltData.Text = strParse(9).ToString
                'End If

            ElseIf strData.StartsWith("MOTOR") Then
                'Example: "MOTOR: fr=%d, bk=%d, rt=%d, lf=%d\r\n"
                strData = strData.Remove(0, 7)
                strParse = strData.Split(",")

                For Each s As String In strParse
                    s = s.Trim()
                    If s.StartsWith("fr=") Then
                        s = s.Remove(0, 3)
                        lblFrontData.Text = s
                    ElseIf s.StartsWith("bk=") Then
                        s = s.Remove(0, 3)
                        lblBackData.Text = s
                    ElseIf s.StartsWith("rt=") Then
                        s = s.Remove(0, 3)
                        lblRightData.Text = s
                    ElseIf s.StartsWith("lf=") Then
                        s = s.Remove(0, 3)
                        lblLeftData.Text = s
                    End If
                Next
            ElseIf strData.Equals("AT-ZV ConnectionUp") Then
                SerialPort.WriteLine("")
                'boolReady = True
                ' ''ElseIf boolConnect Then
                ' ''    strData = ""
                ' ''    SerialPort.WriteLine(strData)

                ' ''Else
                ' ''    strData = "AT+ZV SPPConnect 00043e018409"
                ' ''    SerialPort.WriteLine(strData)
                ' ''    With lblMessage
                ' ''        .ForeColor = Color.Blue
                ' ''        .Text = strData
                ' ''    End With
           
            End If
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            strData = "AT+ZV SPPConnect 00043e018400"
            SerialPort.WriteLine(strData)
            'SerialPort.WriteLine("")
            With txtMessage
                .ForeColor = Color.Blue
                .AppendText(strData & vbCrLf)
            End With
            'boolConnect = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
