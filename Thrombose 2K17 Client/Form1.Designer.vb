<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThrombose
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
        Me.btnNewPlayer = New System.Windows.Forms.Button()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.tmrGetChatText = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.tmrGetGame = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnNewPlayer
        '
        Me.btnNewPlayer.Location = New System.Drawing.Point(25, 60)
        Me.btnNewPlayer.Name = "btnNewPlayer"
        Me.btnNewPlayer.Size = New System.Drawing.Size(136, 83)
        Me.btnNewPlayer.TabIndex = 0
        Me.btnNewPlayer.Text = "Neuer Spieler"
        Me.btnNewPlayer.UseVisualStyleBackColor = True
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(56, 396)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtChat.Size = New System.Drawing.Size(627, 106)
        Me.txtChat.TabIndex = 2
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Location = New System.Drawing.Point(349, 508)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(120, 34)
        Me.btnSendMessage.TabIndex = 3
        Me.btnSendMessage.Text = "Senden"
        Me.btnSendMessage.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(56, 516)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(138, 20)
        Me.txtMessage.TabIndex = 4
        '
        'tmrGetChatText
        '
        Me.tmrGetChatText.Enabled = True
        Me.tmrGetChatText.Interval = 1000
        '
        'lblPlayer
        '
        Me.lblPlayer.Location = New System.Drawing.Point(558, 22)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(168, 23)
        Me.lblPlayer.TabIndex = 5
        Me.lblPlayer.Text = "Not connected"
        Me.lblPlayer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(25, 34)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(103, 20)
        Me.txtPlayerName.TabIndex = 6
        '
        'tmrGetGame
        '
        Me.tmrGetGame.Enabled = True
        Me.tmrGetGame.Interval = 1000
        '
        'frmThrombose
        '
        Me.AcceptButton = Me.btnSendMessage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 554)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnSendMessage)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.btnNewPlayer)
        Me.Name = "frmThrombose"
        Me.Text = "Thrombose!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewPlayer As Button
    Friend WithEvents txtChat As TextBox
    Friend WithEvents btnSendMessage As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents tmrGetChatText As Timer
    Friend WithEvents lblPlayer As Label
    Friend WithEvents txtPlayerName As TextBox
    Friend WithEvents tmrGetGame As Timer
    Friend WithEvents Timer1 As Timer
End Class
