Public Class frmMain

    Dim strIncoming As String
    Dim intCounter As Integer


    Dim srsBack As New DataVisualization.Charting.Series
    Dim srsRight As New DataVisualization.Charting.Series
    Dim srsAltitude As New DataVisualization.Charting.Series
    Dim intLastPrinted(5) As Integer
    Dim swTemp As StreamWriter

    Dim boolDisconnect As Boolean

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If
    End Sub
    'Dim dblLastTime As Double


    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Clear data labels
        lblRollData.Text = ""
        lblPitchData.Text = ""
        lblYawData.Text = ""
        txtMessage.Text = ""
        lblBackData.Text = ""
        lblRightData.Text = ""
        lblAltitudeData.Text = ""
        lblStatus.Text = ""
        lblDebug1Data.Text = ""
        lblDebug2Data.Text = ""
        lblDebug3Data.Text = ""
        lblDebug4Data.Text = ""
        lblDebug5Data.Text = ""
        lblStatus.Text = Now()
        txtSendData.Enabled = False

        ' Initialize Chart
        Chart1.Series.Clear()
        Chart1.Titles.Add("Sonar range")
        Chart1.ChartAreas(0).AxisX.ScrollBar.Enabled = True
        Chart1.ChartAreas(0).AxisX.Title = "Time [0.002 sec]" 'Chart1.ChartAreas("ChartArea1").AxisX.Title = "Time"
        Chart1.ChartAreas(0).AxisY.Title = "Position [cm]"
        Chart1.ChartAreas(0).AxisX.ScaleView.Size = 100


        srsBack.Name = "Back"
        srsBack.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        srsRight.Name = "Right"
        srsRight.ChartType = DataVisualization.Charting.SeriesChartType.FastLine
        srsAltitude.Name = "Altitude"
        srsAltitude.ChartType = DataVisualization.Charting.SeriesChartType.FastLine

        Chart1.Series.Add(srsBack)
        Chart1.Series.Add(srsRight)
        Chart1.Series.Add(srsAltitude)

        Chart1.Series("Back").Color = Color.Blue
        Chart1.Series("Right").Color = Color.Red
        Chart1.Series("Altitude").Color = Color.Black

        Chart1.Series("Back").BorderWidth = 3
        Chart1.Series("Right").BorderWidth = 3
        Chart1.Series("Altitude").BorderWidth = 3

        'Set buttons
        btnStart.Enabled = True
        btnDisconnect.Enabled = False


        'Data counters
        intCounter = 0

        intLastPrinted(0) = intCounter
        intLastPrinted(1) = intCounter
        intLastPrinted(2) = intCounter
        intLastPrinted(3) = intCounter
        intLastPrinted(4) = intCounter

        'dblLastTime = 0.0


    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        strIncoming = String.Empty

        Try
            boolDisconnect = False
            If SerialPort.IsOpen Then
                SerialPort.Close()
            End If

            With SerialPort
                .PortName = "COM3"
                .BaudRate = 115200
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .ReadTimeout = 10000
            End With
            SerialPort.Open()



            txtMessage.ForeColor = Color.Black
            'txtMessage.AppendText("COM3 connected" & vbCrLf)
            lblStatus.Text = SerialPort.PortName & " connected"

            btnStart.Enabled = False
            btnDisconnect.Enabled = True
            txtSendData.Enabled = True
            txtSendData.Text = ""
            txtSendData.Focus()

        Catch ex As TimeoutException
            lblStatus.Text = "Error: Serial Port read timed out."
        Catch ex2 As Exception
            lblStatus.Text = ex2.ToString
        End Try
    End Sub

    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
        Try

            'With SerialPort
            '.PortName = "COM3"
            '.BaudRate = 115200
            '.Parity = IO.Ports.Parity.None
            '.DataBits = 8
            '.StopBits = IO.Ports.StopBits.One
            'End With

            btnSaveLog_Click(sender, e)

            boolDisconnect = True
            RemoveHandler SerialPort.DataReceived, AddressOf SerialPort_DataReceived
            'SerialPort.DiscardInBuffer()
            Application.DoEvents()
            System.Threading.Thread.Sleep(1000)


            'If SerialPort.IsOpen Then
            SerialPort.Close()
            'End If

            lblStatus.Text = SerialPort.PortName & " disconnected"
            btnStart.Enabled = True
            btnDisconnect.Enabled = False
            txtSendData.Enabled = False

            'Process.Start(Application.ExecutablePath)
            'Me.Close()


        Catch ex As Exception
            lblStatus.Text = ex.ToString
        End Try
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        If Not boolDisconnect Then
            txtMessage.Invoke(New  _
                               myDelegate(AddressOf updateLabel), _
                               New Object() {})
        End If

        'BeginInvoke


    End Sub

    Public Delegate Sub myDelegate()
    Public Sub updateLabel()
        Dim strParse() As String = Nothing
        Dim intPrintRate As Integer = 3 '10

        intCounter = intCounter + 1
        'lblStatus.Text = intCounter & " lines received"

        Try

            strIncoming = SerialPort.ReadLine()
            'strIncoming = SerialPort.ReadExisting
            txtMessage.AppendText(strIncoming & Chr(10)) 'vbCrLf 'CHr(10)


            strIncoming = strIncoming.Trim()

            'If boolReady Then
            'Parse data
            'Example - ATTITUDE: Pitch=0, Roll=2, Yaw=439
            'If intCounter >= 10 And intCounter <= 14 Then
            Dim strArray() As String = Split(strIncoming, ",")
            'dblLastTime = dblLastTime + 1 / CDbl(strArray(1))

            'numData = CSng(strArray(2))
            Select Case strArray(0)
                Case "Xaxis"
                    If intLastPrinted(0) = 0 Or (intCounter - intLastPrinted(0)) > intPrintRate Then
                        lblBackData.Text = Format(CSng(strArray(5)) / 10.0, "0.0")
                        intLastPrinted(0) = intCounter
                    End If
                    srsBack.Points.AddY(CSng(strArray(5)) / 10.0)
                    'srsBack.Points.AddXY(dblLastTime, CDbl(strArray(5)) / 10.0)
                Case "Yaxis"
                    If intLastPrinted(1) = 0 Or (intCounter - intLastPrinted(1)) > intPrintRate Then
                        lblRightData.Text = Format(CSng(strArray(5)) / 10.0, "0.0") 'numData / 10.0
                        intLastPrinted(1) = intCounter
                    End If
                    srsRight.Points.AddY(CSng(strArray(5)) / 10.0)
                    'srsRight.Points.AddXY(dblLastTime, CDbl(strArray(5)) / 10.0)
                Case "Zaxis"
                    If intLastPrinted(2) = 0 Or (intCounter - intLastPrinted(2)) > intPrintRate Then
                        lblAltitudeData.Text = Format(CSng(strArray(5)) / 10.0, "0.0")
                        intLastPrinted(2) = intCounter
                    End If
                    srsAltitude.Points.AddY(CSng(strArray(5)) / 10.0)
                    'srsAltitude.Points.AddXY(dblLastTime, CDbl(strArray(5)) / 10.0)
                Case "Attit"
                    If intLastPrinted(3) = 0 Or (intCounter - intLastPrinted(3)) > intPrintRate Then
                        lblPitchData.Text = Format(CSng(strArray(2)) / 10.0, "0.0")
                        lblRollData.Text = Format(CSng(strArray(3)) / 10.0, "0.0")
                        lblYawData.Text = Format(CSng(strArray(4)), "0.0")
                        intLastPrinted(3) = intCounter
                    End If
                Case "Gdata"
                    If intLastPrinted(4) = 0 Or (intCounter - intLastPrinted(4)) > intPrintRate Then
                        lblDebug1Data.Text = Format(CSng(strArray(2)) / 100.0, "0.00")
                        lblDebug2Data.Text = Format(CSng(strArray(3)) / 100.0, "0.00")
                        lblDebug3Data.Text = Format(CSng(strArray(4)) / 100.0, "0.00")
                        lblDebug4Data.Text = Format(CSng(strArray(5)) / 100.0, "0.00")
                        lblDebug5Data.Text = Format(CSng(strArray(6)) / 100.0, "0.00")
                        intLastPrinted(4) = intCounter
                    End If
            End Select

            If (Chart1.ChartAreas(0).AxisX.Maximum > Chart1.ChartAreas(0).AxisX.ScaleView.Size) Then
                Chart1.ChartAreas(0).AxisX.ScaleView.Scroll(Chart1.ChartAreas(0).AxisX.Maximum)

            End If

            'Using swTemp As StreamWriter = File.AppendText("TaraLog.txt")
            'swTemp.WriteLine(strIncoming)
            'End Using

            'If strIncoming.StartsWith("ATTITUDE:") Then
            'strIncoming = strIncoming.Remove(0, 10)
            'strParse = strIncoming.Split(",")

            'For Each s As String In strParse
            's = s.Trim()
            'If s.StartsWith("Roll=") Then
            's = s.Remove(0, 5)
            'lblRollData.Text = s
            'ElseIf s.StartsWith("Yaw=") Then
            's = s.Remove(0, 4)
            'lblYawData.Text = s
            'ElseIf s.StartsWith("Pitch=") Then
            's = s.Remove(0, 6)
            'lblPitchData.Text = s
            'End If
            'Next

            'strIncoming = "AT+ZV SPPConnect 00043e018400"
            'SerialPort.WriteLine(strIncoming)


            'End If

        Catch ex As TimeoutException
            lblStatus.Text = "Error: Serial Port read timed out."
        Catch ex2 As Exception
            'MsgBox(ex.ToString)
            lblStatus.Text = ex2.ToString
        End Try
    End Sub

    Private Sub btnSaveLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveLog.Click
        Dim TargetFile As StreamWriter
        Dim saveFileLog As New SaveFileDialog()
        Dim strSuggestedName As String
        Dim thisDate As Date

        thisDate = Now()
        strSuggestedName = "output_" & Format(Year(thisDate) - 2000, "00") & Format(Month(thisDate), "00") & Format(Microsoft.VisualBasic.DateAndTime.Day(thisDate), "00") & "_"


        Try

            saveFileLog.Filter = "Text File|*.txt"
            saveFileLog.Title = "Create Log File"
            saveFileLog.FileName = strSuggestedName


            ' If the file name is not an empty string save the name.
            If saveFileLog.ShowDialog() = DialogResult.OK Then
                TargetFile = New StreamWriter(saveFileLog.FileName, True)
                'TargetFile.WriteLine(Now())
                TargetFile.Write(txtMessage.Text)
                TargetFile.Close()

                lblStatus.Text = "Log saved to " & saveFileLog.FileName
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub txtSendData_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSendData.KeyPress
        Dim allowedChars As String = "azsxdcfvgb"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    
    Private Sub txtSendData_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSendData.TextChanged
        Dim charTransmit As Char
        Dim strSendText As String

        Try

            strSendText = txtSendData.Text

            If strSendText.Length > 0 Then
                charTransmit = strSendText(strSendText.Length - 1)
                SerialPort.Write(charTransmit & vbCr)
                lblStatus.Text = "Character transmitted: " & charTransmit
            End If
        Catch ex As Exception
            lblStatus.Text = ex.ToString
        End Try
    End Sub

    

End Class
