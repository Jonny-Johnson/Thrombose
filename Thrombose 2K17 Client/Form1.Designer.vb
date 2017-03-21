<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.chatText = New System.Windows.Forms.TextBox()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.message = New System.Windows.Forms.TextBox()
        Me.tmrGetChatText = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNewPlayer
        '
        Me.btnNewPlayer.Location = New System.Drawing.Point(34, 65)
        Me.btnNewPlayer.Name = "btnNewPlayer"
        Me.btnNewPlayer.Size = New System.Drawing.Size(136, 83)
        Me.btnNewPlayer.TabIndex = 0
        Me.btnNewPlayer.Text = "Neuer Spieler"
        Me.btnNewPlayer.UseVisualStyleBackColor = True
        '
        'chatText
        '
        Me.chatText.Location = New System.Drawing.Point(56, 352)
        Me.chatText.Multiline = True
        Me.chatText.Name = "chatText"
        Me.chatText.Size = New System.Drawing.Size(627, 138)
        Me.chatText.TabIndex = 2
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Location = New System.Drawing.Point(234, 508)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(79, 20)
        Me.btnSendMessage.TabIndex = 3
        Me.btnSendMessage.Text = "Senden"
        Me.btnSendMessage.UseVisualStyleBackColor = True
        '
        'message
        '
        Me.message.Location = New System.Drawing.Point(56, 509)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(138, 20)
        Me.message.TabIndex = 4
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
        Me.txtPlayerName.Location = New System.Drawing.Point(25, 25)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(103, 20)
        Me.txtPlayerName.TabIndex = 6
        '
        'Form1
        '
        Me.AcceptButton = Me.btnSendMessage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 554)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblPlayer)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.btnSendMessage)
        Me.Controls.Add(Me.chatText)
        Me.Controls.Add(Me.btnNewPlayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewPlayer As Button
    Friend WithEvents chatText As TextBox
    Friend WithEvents btnSendMessage As Button
    Friend WithEvents message As TextBox
    Friend WithEvents tmrGetChatText As Timer
    Friend WithEvents lblPlayer As Label
    Friend WithEvents txtPlayerName As TextBox
End Class
