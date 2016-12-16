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
        Me.grp = New System.Windows.Forms.GroupBox
        Me.lblYawData = New System.Windows.Forms.Label
        Me.lblPitchData = New System.Windows.Forms.Label
        Me.lblRollData = New System.Windows.Forms.Label
        Me.lblYawTitle = New System.Windows.Forms.Label
        Me.lblPitchTitle = New System.Windows.Forms.Label
        Me.lblRollTitle = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.lblMain = New System.Windows.Forms.Label
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.btnDisconnect = New System.Windows.Forms.Button
        Me.txtMessage = New System.Windows.Forms.TextBox
        Me.btnSaveLog = New System.Windows.Forms.Button
        Me.grp.SuspendLayout()
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
        Me.grp.Location = New System.Drawing.Point(22, 59)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(689, 73)
        Me.grp.TabIndex = 0
        Me.grp.TabStop = False
        Me.grp.Text = "Attitude"
        '
        'lblYawData
        '
        Me.lblYawData.AutoSize = True
        Me.lblYawData.Location = New System.Drawing.Point(550, 31)
        Me.lblYawData.Name = "lblYawData"
        Me.lblYawData.Size = New System.Drawing.Size(75, 20)
        Me.lblYawData.TabIndex = 5
        Me.lblYawData.Text = "YawData"
        '
        'lblPitchData
        '
        Me.lblPitchData.AutoSize = True
        Me.lblPitchData.Location = New System.Drawing.Point(68, 31)
        Me.lblPitchData.Name = "lblPitchData"
        Me.lblPitchData.Size = New System.Drawing.Size(79, 20)
        Me.lblPitchData.TabIndex = 4
        Me.lblPitchData.Text = "PitchData"
        '
        'lblRollData
        '
        Me.lblRollData.AutoSize = True
        Me.lblRollData.Location = New System.Drawing.Point(307, 31)
        Me.lblRollData.Name = "lblRollData"
        Me.lblRollData.Size = New System.Drawing.Size(71, 20)
        Me.lblRollData.TabIndex = 3
        Me.lblRollData.Text = "RollData"
        '
        'lblYawTitle
        '
        Me.lblYawTitle.AutoSize = True
        Me.lblYawTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYawTitle.Location = New System.Drawing.Point(503, 31)
        Me.lblYawTitle.Name = "lblYawTitle"
        Me.lblYawTitle.Size = New System.Drawing.Size(48, 20)
        Me.lblYawTitle.TabIndex = 2
        Me.lblYawTitle.Text = "Yaw:"
        '
        'lblPitchTitle
        '
        Me.lblPitchTitle.AutoSize = True
        Me.lblPitchTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPitchTitle.Location = New System.Drawing.Point(15, 31)
        Me.lblPitchTitle.Name = "lblPitchTitle"
        Me.lblPitchTitle.Size = New System.Drawing.Size(54, 20)
        Me.lblPitchTitle.TabIndex = 1
        Me.lblPitchTitle.Text = "Pitch:"
        '
        'lblRollTitle
        '
        Me.lblRollTitle.AutoSize = True
        Me.lblRollTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRollTitle.Location = New System.Drawing.Point(261, 31)
        Me.lblRollTitle.Name = "lblRollTitle"
        Me.lblRollTitle.Size = New System.Drawing.Size(45, 20)
        Me.lblRollTitle.TabIndex = 0
        Me.lblRollTitle.Text = "Roll:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(22, 245)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(129, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Open COM Port"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.Black
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.White
        Me.lblMain.Location = New System.Drawing.Point(322, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(119, 29)
        Me.lblMain.TabIndex = 3
        Me.lblMain.Text = "IMU Data"
        '
        'SerialPort
        '
        Me.SerialPort.BaudRate = 115200
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(157, 245)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(129, 23)
        Me.btnDisconnect.TabIndex = 5
        Me.btnDisconnect.Text = "Close COM Port"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.BackColor = System.Drawing.Color.White
        Me.txtMessage.Location = New System.Drawing.Point(22, 167)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessage.Size = New System.Drawing.Size(625, 52)
        Me.txtMessage.TabIndex = 8
        '
        'btnSaveLog
        '
        Me.btnSaveLog.Location = New System.Drawing.Point(653, 167)
        Me.btnSaveLog.Name = "btnSaveLog"
        Me.btnSaveLog.Size = New System.Drawing.Size(54, 52)
        Me.btnSaveLog.TabIndex = 11
        Me.btnSaveLog.Text = "Save Log"
        Me.btnSaveLog.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 289)
        Me.Controls.Add(Me.btnSaveLog)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.grp)
        Me.Name = "frmMain"
        Me.Text = "IMU Data"
        Me.grp.ResumeLayout(False)
        Me.grp.PerformLayout()
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
    Friend WithEvents lblMain As System.Windows.Forms.Label
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveLog As System.Windows.Forms.Button

End Class
