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
    	Me.SuspendLayout
    	'
    	'btnNewPlayer
    	'
    	Me.btnNewPlayer.Location = New System.Drawing.Point(29, 54)
    	Me.btnNewPlayer.Name = "btnNewPlayer"
    	Me.btnNewPlayer.Size = New System.Drawing.Size(136, 83)
    	Me.btnNewPlayer.TabIndex = 0
    	Me.btnNewPlayer.Text = "Neuer Spieler"
    	Me.btnNewPlayer.UseVisualStyleBackColor = true
    	AddHandler Me.btnNewPlayer.Click, AddressOf Me.btnNewPlayer_Click
    	'
    	'chatText
    	'
    	Me.chatText.Location = New System.Drawing.Point(56, 352)
    	Me.chatText.Multiline = true
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
    	Me.btnSendMessage.UseVisualStyleBackColor = true
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
    	Me.tmrGetChatText.Enabled = true
    	Me.tmrGetChatText.Interval = 1000
    	'
    	'Form1
    	'
    	Me.AcceptButton = Me.btnSendMessage
    	Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    	Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    	Me.ClientSize = New System.Drawing.Size(747, 554)
    	Me.Controls.Add(Me.message)
    	Me.Controls.Add(Me.btnSendMessage)
    	Me.Controls.Add(Me.chatText)
    	Me.Controls.Add(Me.btnNewPlayer)
    	Me.Name = "Form1"
    	Me.Text = "Form1"
    	Me.ResumeLayout(false)
    	Me.PerformLayout
    End Sub

    Friend WithEvents btnNewPlayer As Button
    Friend WithEvents chatText As TextBox
    Friend WithEvents btnSendMessage As Button
    Friend WithEvents message As TextBox
    Friend WithEvents tmrGetChatText As Timer
End Class
