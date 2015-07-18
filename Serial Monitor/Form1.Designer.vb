<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SerialMonitorApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PortList = New System.Windows.Forms.ComboBox()
        Me.PortLabel = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.BaudList = New System.Windows.Forms.ComboBox()
        Me.BaudLabel = New System.Windows.Forms.Label()
        Me.ConnectBtn = New System.Windows.Forms.Button()
        Me.DisconnectBtn = New System.Windows.Forms.Button()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        Me.SendText = New System.Windows.Forms.TextBox()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.RecieveText = New System.Windows.Forms.RichTextBox()
        Me.WarnText = New System.Windows.Forms.RichTextBox()
        Me.WarnOkBtn = New System.Windows.Forms.Button()
        Me.WarnLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PortList
        '
        Me.PortList.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PortList.FormattingEnabled = True
        Me.PortList.Location = New System.Drawing.Point(76, 12)
        Me.PortList.Name = "PortList"
        Me.PortList.Size = New System.Drawing.Size(121, 21)
        Me.PortList.TabIndex = 0
        '
        'PortLabel
        '
        Me.PortLabel.AutoSize = True
        Me.PortLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PortLabel.Location = New System.Drawing.Point(12, 15)
        Me.PortLabel.Name = "PortLabel"
        Me.PortLabel.Size = New System.Drawing.Size(53, 13)
        Me.PortLabel.TabIndex = 1
        Me.PortLabel.Text = "COM Port"
        Me.PortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialPort
        '
        '
        'BaudList
        '
        Me.BaudList.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BaudList.FormattingEnabled = True
        Me.BaudList.Location = New System.Drawing.Point(76, 39)
        Me.BaudList.Name = "BaudList"
        Me.BaudList.Size = New System.Drawing.Size(121, 21)
        Me.BaudList.TabIndex = 2
        '
        'BaudLabel
        '
        Me.BaudLabel.AutoSize = True
        Me.BaudLabel.Location = New System.Drawing.Point(12, 42)
        Me.BaudLabel.Name = "BaudLabel"
        Me.BaudLabel.Size = New System.Drawing.Size(58, 13)
        Me.BaudLabel.TabIndex = 3
        Me.BaudLabel.Text = "Baud Rate"
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Location = New System.Drawing.Point(15, 95)
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Size = New System.Drawing.Size(182, 23)
        Me.ConnectBtn.TabIndex = 4
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        '
        'DisconnectBtn
        '
        Me.DisconnectBtn.Location = New System.Drawing.Point(15, 124)
        Me.DisconnectBtn.Name = "DisconnectBtn"
        Me.DisconnectBtn.Size = New System.Drawing.Size(182, 23)
        Me.DisconnectBtn.TabIndex = 5
        Me.DisconnectBtn.Text = "Disconnect"
        Me.DisconnectBtn.UseVisualStyleBackColor = True
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(15, 66)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(182, 23)
        Me.RefreshBtn.TabIndex = 6
        Me.RefreshBtn.Text = "Refresh Ports"
        Me.RefreshBtn.UseVisualStyleBackColor = True
        '
        'SendText
        '
        Me.SendText.Location = New System.Drawing.Point(203, 560)
        Me.SendText.Name = "SendText"
        Me.SendText.Size = New System.Drawing.Size(868, 20)
        Me.SendText.TabIndex = 7
        '
        'SendBtn
        '
        Me.SendBtn.Location = New System.Drawing.Point(1077, 557)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(75, 23)
        Me.SendBtn.TabIndex = 8
        Me.SendBtn.Text = "Send"
        Me.SendBtn.UseVisualStyleBackColor = True
        '
        'RecieveText
        '
        Me.RecieveText.Location = New System.Drawing.Point(203, 12)
        Me.RecieveText.Name = "RecieveText"
        Me.RecieveText.ReadOnly = True
        Me.RecieveText.Size = New System.Drawing.Size(949, 530)
        Me.RecieveText.TabIndex = 9
        Me.RecieveText.Text = ""
        '
        'WarnText
        '
        Me.WarnText.Location = New System.Drawing.Point(15, 195)
        Me.WarnText.Name = "WarnText"
        Me.WarnText.ReadOnly = True
        Me.WarnText.Size = New System.Drawing.Size(182, 385)
        Me.WarnText.TabIndex = 10
        Me.WarnText.Text = "Click 'Ok' to Dismiss Warnings."
        '
        'WarnOkBtn
        '
        Me.WarnOkBtn.Location = New System.Drawing.Point(15, 166)
        Me.WarnOkBtn.Name = "WarnOkBtn"
        Me.WarnOkBtn.Size = New System.Drawing.Size(182, 23)
        Me.WarnOkBtn.TabIndex = 11
        Me.WarnOkBtn.Text = "Ok"
        Me.WarnOkBtn.UseVisualStyleBackColor = True
        '
        'WarnLabel
        '
        Me.WarnLabel.AutoSize = True
        Me.WarnLabel.Location = New System.Drawing.Point(12, 150)
        Me.WarnLabel.Name = "WarnLabel"
        Me.WarnLabel.Size = New System.Drawing.Size(52, 13)
        Me.WarnLabel.TabIndex = 12
        Me.WarnLabel.Text = "Warnings"
        '
        'SerialMonitorApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1164, 592)
        Me.Controls.Add(Me.WarnLabel)
        Me.Controls.Add(Me.WarnOkBtn)
        Me.Controls.Add(Me.WarnText)
        Me.Controls.Add(Me.RecieveText)
        Me.Controls.Add(Me.SendBtn)
        Me.Controls.Add(Me.SendText)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.DisconnectBtn)
        Me.Controls.Add(Me.ConnectBtn)
        Me.Controls.Add(Me.BaudLabel)
        Me.Controls.Add(Me.BaudList)
        Me.Controls.Add(Me.PortLabel)
        Me.Controls.Add(Me.PortList)
        Me.Name = "SerialMonitorApp"
        Me.Text = "Serial Monitor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PortList As System.Windows.Forms.ComboBox
    Friend WithEvents PortLabel As System.Windows.Forms.Label
    Friend WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents BaudList As System.Windows.Forms.ComboBox
    Friend WithEvents BaudLabel As System.Windows.Forms.Label
    Friend WithEvents ConnectBtn As System.Windows.Forms.Button
    Friend WithEvents DisconnectBtn As System.Windows.Forms.Button
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
    Friend WithEvents SendText As System.Windows.Forms.TextBox
    Friend WithEvents SendBtn As System.Windows.Forms.Button
    Friend WithEvents RecieveText As System.Windows.Forms.RichTextBox
    Friend WithEvents WarnText As System.Windows.Forms.RichTextBox
    Friend WithEvents WarnOkBtn As System.Windows.Forms.Button
    Friend WithEvents WarnLabel As System.Windows.Forms.Label

End Class
