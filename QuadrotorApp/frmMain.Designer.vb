<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.grp = New System.Windows.Forms.GroupBox
        Me.lblYawData = New System.Windows.Forms.Label
        Me.lblPitchData = New System.Windows.Forms.Label
        Me.lblRollData = New System.Windows.Forms.Label
        Me.lblYawTitle = New System.Windows.Forms.Label
        Me.lblPitchTitle = New System.Windows.Forms.Label
        Me.lblRollTitle = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btnSaveLog = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblAltitudeData = New System.Windows.Forms.Label
        Me.lblRightData = New System.Windows.Forms.Label
        Me.lblBackData = New System.Windows.Forms.Label
        Me.lblAltitude = New System.Windows.Forms.Label
        Me.lblRight = New System.Windows.Forms.Label
        Me.lblBack = New System.Windows.Forms.Label
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.txtSendData = New System.Windows.Forms.TextBox
        Me.lblSend = New System.Windows.Forms.Label
        Me.lblDebug1 = New System.Windows.Forms.Label
        Me.lblDebug1Data = New System.Windows.Forms.Label
        Me.lblDebug2Data = New System.Windows.Forms.Label
        Me.lblDebug2 = New System.Windows.Forms.Label
        Me.lblDebug3Data = New System.Windows.Forms.Label
        Me.lblDebug3 = New System.Windows.Forms.Label
        Me.lblDebug4Data = New System.Windows.Forms.Label
        Me.lblDebug4 = New System.Windows.Forms.Label
        Me.lblDebug5Data = New System.Windows.Forms.Label
        Me.lblDebug5 = New System.Windows.Forms.Label
        Me.grp.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp
        '
        Me.grp.Controls.Add(Me.lblYawData)
        Me.grp.Controls.Add(Me.lblPitchData)
        Me.grp.Controls.Add(Me.lblRollData)
        Me.grp.Controls.Add(Me.lblYawTitle)
        Me.grp.Controls.Add(Me.lblPitchTitle)
        Me.grp.Controls.Add(Me.lblRollTitle)
        Me.grp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.Location = New System.Drawing.Point(22, 93)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(701, 73)
        Me.grp.TabIndex = 0
        Me.grp.TabStop = False
        Me.grp.Text = "Attitude [deg]"
        '
        'lblYawData
        '
        Me.lblYawData.AutoSize = True
        Me.lblYawData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYawData.Location = New System.Drawing.Point(555, 27)
        Me.lblYawData.Name = "lblYawData"
        Me.lblYawData.Size = New System.Drawing.Size(102, 26)
        Me.lblYawData.TabIndex = 5
        Me.lblYawData.Text = "YawData"
        '
        'lblPitchData
        '
        Me.lblPitchData.AutoSize = True
        Me.lblPitchData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchData.Location = New System.Drawing.Point(325, 27)
        Me.lblPitchData.Name = "lblPitchData"
        Me.lblPitchData.Size = New System.Drawing.Size(107, 26)
        Me.lblPitchData.TabIndex = 4
        Me.lblPitchData.Text = "PitchData"
        '
        'lblRollData
        '
        Me.lblRollData.AutoSize = True
        Me.lblRollData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollData.Location = New System.Drawing.Point(59, 27)
        Me.lblRollData.Name = "lblRollData"
        Me.lblRollData.Size = New System.Drawing.Size(96, 26)
        Me.lblRollData.TabIndex = 3
        Me.lblRollData.Text = "RollData"
        '
        'lblYawTitle
        '
        Me.lblYawTitle.AutoSize = True
        Me.lblYawTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYawTitle.Location = New System.Drawing.Point(508, 31)
        Me.lblYawTitle.Name = "lblYawTitle"
        Me.lblYawTitle.Size = New System.Drawing.Size(48, 20)
        Me.lblYawTitle.TabIndex = 2
        Me.lblYawTitle.Text = "Yaw:"
        '
        'lblPitchTitle
        '
        Me.lblPitchTitle.AutoSize = True
        Me.lblPitchTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchTitle.Location = New System.Drawing.Point(272, 31)
        Me.lblPitchTitle.Name = "lblPitchTitle"
        Me.lblPitchTitle.Size = New System.Drawing.Size(54, 20)
        Me.lblPitchTitle.TabIndex = 1
        Me.lblPitchTitle.Text = "Pitch:"
        '
        'lblRollTitle
        '
        Me.lblRollTitle.AutoSize = True
        Me.lblRollTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollTitle.Location = New System.Drawing.Point(15, 31)
        Me.lblRollTitle.Name = "lblRollTitle"
        Me.lblRollTitle.Size = New System.Drawing.Size(45, 20)
        Me.lblRollTitle.TabIndex = 0
        Me.lblRollTitle.Text = "Roll:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(22, 470)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(129, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Open COM Port"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'SerialPort
        '
        Me.SerialPort.BaudRate = 115200
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(157, 470)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(129, 23)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Close COM Port"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMessage.Location = New System.Drawing.Point(22, 397)
        Me.txtMessage.MaxLength = 32767000
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(641, 60)
        Me.txtMessage.TabIndex = 8
        Me.txtMessage.TabStop = False
        '
        'btnSaveLog
        '
        Me.btnSaveLog.Location = New System.Drawing.Point(669, 405)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(54, 52)
        Me.btnSaveLog.TabIndex = 11
        Me.btnSaveLog.Text = "Save Log"
        Me.btnSaveLog.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(19, 507)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Status"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAltitudeData)
        Me.GroupBox1.Controls.Add(Me.lblRightData)
        Me.GroupBox1.Controls.Add(Me.lblBackData)
        Me.GroupBox1.Controls.Add(Me.lblAltitude)
        Me.GroupBox1.Controls.Add(Me.lblRight)
        Me.GroupBox1.Controls.Add(Me.lblBack)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 73)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sonar [cm]"
        '
        'lblAltitudeData
        '
        Me.lblAltitudeData.AutoSize = True
        Me.lblAltitudeData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltitudeData.Location = New System.Drawing.Point(555, 27)
        Me.lblAltitudeData.Name = "lblAltitudeData"
        Me.lblAltitudeData.Size = New System.Drawing.Size(131, 26)
        Me.lblAltitudeData.TabIndex = 5
        Me.lblAltitudeData.Text = "AltitudeData"
        '
        'lblRightData
        '
        Me.lblRightData.AutoSize = True
        Me.lblRightData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRightData.Location = New System.Drawing.Point(68, 27)
        Me.lblRightData.Name = "lblRightData"
        Me.lblRightData.Size = New System.Drawing.Size(109, 26)
        Me.lblRightData.TabIndex = 4
        Me.lblRightData.Text = "RightData"
        '
        'lblBackData
        '
        Me.lblBackData.AutoSize = True
        Me.lblBackData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackData.Location = New System.Drawing.Point(318, 27)
        Me.lblBackData.Name = "lblBackData"
        Me.lblBackData.Size = New System.Drawing.Size(107, 26)
        Me.lblBackData.TabIndex = 3
        Me.lblBackData.Text = "BackData"
        '
        'lblAltitude
        '
        Me.lblAltitude.AutoSize = True
        Me.lblAltitude.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltitude.Location = New System.Drawing.Point(482, 31)
        Me.lblAltitude.Name = "lblAltitude"
        Me.lblAltitude.Size = New System.Drawing.Size(76, 20)
        Me.lblAltitude.TabIndex = 2
        Me.lblAltitude.Text = "Altitude:"
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRight.Location = New System.Drawing.Point(15, 31)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(57, 20)
        Me.lblRight.TabIndex = 1
        Me.lblRight.Text = "Right:"
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(272, 31)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(54, 20)
        Me.lblBack.TabIndex = 0
        Me.lblBack.Text = "Back:"
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(22, 172)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(701, 176)
        Me.Chart1.TabIndex = 14
        '
        'txtSendData
        '
        Me.txtSendData.Location = New System.Drawing.Point(363, 472)
        Me.txtSendData.Name = "txtSendData"
        Me.txtSendData.Size = New System.Drawing.Size(300, 20)
        Me.txtSendData.TabIndex = 15
        '
        'lblSend
        '
        Me.lblSend.AutoSize = True
        Me.lblSend.Location = New System.Drawing.Point(326, 475)
        Me.lblSend.Name = "lblSend"
        Me.lblSend.Size = New System.Drawing.Size(35, 13)
        Me.lblSend.TabIndex = 16
        Me.lblSend.Text = "Send:"
        '
        'lblDebug1
        '
        Me.lblDebug1.AutoSize = True
        Me.lblDebug1.Location = New System.Drawing.Point(19, 365)
        Me.lblDebug1.Name = "lblDebug1"
        Me.lblDebug1.Size = New System.Drawing.Size(48, 13)
        Me.lblDebug1.TabIndex = 17
        Me.lblDebug1.Text = "Debug1:"
        '
        'lblDebug1Data
        '
        Me.lblDebug1Data.AutoSize = True
        Me.lblDebug1Data.Location = New System.Drawing.Point(64, 365)
        Me.lblDebug1Data.Name = "lblDebug1Data"
        Me.lblDebug1Data.Size = New System.Drawing.Size(68, 13)
        Me.lblDebug1Data.TabIndex = 18
        Me.lblDebug1Data.Text = "Debug1Data"
        '
        'lblDebug2Data
        '
        Me.lblDebug2Data.AutoSize = True
        Me.lblDebug2Data.Location = New System.Drawing.Point(199, 365)
        Me.lblDebug2Data.Name = "lblDebug2Data"
        Me.lblDebug2Data.Size = New System.Drawing.Size(68, 13)
        Me.lblDebug2Data.TabIndex = 20
        Me.lblDebug2Data.Text = "Debug2Data"
        '
        'lblDebug2
        '
        Me.lblDebug2.AutoSize = True
        Me.lblDebug2.Location = New System.Drawing.Point(154, 365)
        Me.lblDebug2.Name = "lblDebug2"
        Me.lblDebug2.Size = New System.Drawing.Size(48, 13)
        Me.lblDebug2.TabIndex = 19
        Me.lblDebug2.Text = "Debug2:"
        '
        'lblDebug3Data
        '
        Me.lblDebug3Data.AutoSize = True
        Me.lblDebug3Data.Location = New System.Drawing.Point(358, 365)
        Me.lblDebug3Data.Name = "lblDebug3Data"
        Me.lblDebug3Data.Size = New System.Drawing.Size(68, 13)
        Me.lblDebug3Data.TabIndex = 22
        Me.lblDebug3Data.Text = "Debug3Data"
        '
        'lblDebug3
        '
        Me.lblDebug3.AutoSize = True
        Me.lblDebug3.Location = New System.Drawing.Point(313, 365)
        Me.lblDebug3.Name = "lblDebug3"
        Me.lblDebug3.Size = New System.Drawing.Size(48, 13)
        Me.lblDebug3.TabIndex = 21
        Me.lblDebug3.Text = "Debug3:"
        '
        'lblDebug4Data
        '
        Me.lblDebug4Data.AutoSize = True
        Me.lblDebug4Data.Location = New System.Drawing.Point(511, 365)
        Me.lblDebug4Data.Name = "lblDebug4Data"
        Me.lblDebug4Data.Size = New System.Drawing.Size(68, 13)
        Me.lblDebug4Data.TabIndex = 24
        Me.lblDebug4Data.Text = "Debug4Data"
        '
        'lblDebug4
        '
        Me.lblDebug4.AutoSize = True
        Me.lblDebug4.Location = New System.Drawing.Point(466, 365)
        Me.lblDebug4.Name = "lblDebug4"
        Me.lblDebug4.Size = New System.Drawing.Size(48, 13)
        Me.lblDebug4.TabIndex = 23
        Me.lblDebug4.Text = "Debug4:"
        '
        'lblDebug5Data
        '
        Me.lblDebug5Data.AutoSize = True
        Me.lblDebug5Data.Location = New System.Drawing.Point(650, 365)
        Me.lblDebug5Data.Name = "lblDebug5Data"
        Me.lblDebug5Data.Size = New System.Drawing.Size(68, 13)
        Me.lblDebug5Data.TabIndex = 26
        Me.lblDebug5Data.Text = "Debug5Data"
        '
        'lblDebug5
        '
        Me.lblDebug5.AutoSize = True
        Me.lblDebug5.Location = New System.Drawing.Point(605, 365)
        Me.lblDebug5.Name = "lblDebug5"
        Me.lblDebug5.Size = New System.Drawing.Size(48, 13)
        Me.lblDebug5.TabIndex = 25
        Me.lblDebug5.Text = "Debug5:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 537)
        Me.Controls.Add(Me.lblDebug5Data)
        Me.Controls.Add(Me.lblDebug5)
        Me.Controls.Add(Me.lblDebug4Data)
        Me.Controls.Add(Me.lblDebug4)
        Me.Controls.Add(Me.lblDebug3Data)
        Me.Controls.Add(Me.lblDebug3)
        Me.Controls.Add(Me.lblDebug2Data)
        Me.Controls.Add(Me.lblDebug2)
        Me.Controls.Add(Me.lblDebug1Data)
        Me.Controls.Add(Me.lblDebug1)
        Me.Controls.Add(Me.lblSend)
        Me.Controls.Add(Me.txtSendData)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSaveLog)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grp)
        Me.Name = "frmMain"
        Me.Text = "TARA Flight Data"
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp As System.Windows.Forms.GroupBox
    Friend WithEvents lblRollTitle As System.Windows.Forms.Label
    Friend WithEvents lblYawTitle As System.Windows.Forms.Label
    Friend WithEvents lblPitchTitle As System.Windows.Forms.Label
    Friend WithEvents lblYawData As System.Windows.Forms.Label
    Friend WithEvents lblPitchData As System.Windows.Forms.Label
    Friend WithEvents lblRollData As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveLog As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAltitudeData As System.Windows.Forms.Label
    Friend WithEvents lblRightData As System.Windows.Forms.Label
    Friend WithEvents lblBackData As System.Windows.Forms.Label
    Friend WithEvents lblAltitude As System.Windows.Forms.Label
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblBack As System.Windows.Forms.Label
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents txtSendData As System.Windows.Forms.TextBox
    Friend WithEvents lblSend As System.Windows.Forms.Label
    Friend WithEvents lblDebug1 As System.Windows.Forms.Label
    Friend WithEvents lblDebug1Data As System.Windows.Forms.Label
    Friend WithEvents lblDebug2Data As System.Windows.Forms.Label
    Friend WithEvents lblDebug2 As System.Windows.Forms.Label
    Friend WithEvents lblDebug3Data As System.Windows.Forms.Label
    Friend WithEvents lblDebug3 As System.Windows.Forms.Label
    Friend WithEvents lblDebug4Data As System.Windows.Forms.Label
    Friend WithEvents lblDebug4 As System.Windows.Forms.Label
    Friend WithEvents lblDebug5Data As System.Windows.Forms.Label
    Friend WithEvents lblDebug5 As System.Windows.Forms.Label

End Class
