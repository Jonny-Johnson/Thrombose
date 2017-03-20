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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chatText = New System.Windows.Forms.TextBox()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.message = New System.Windows.Forms.TextBox()
        Me.tmrGetChatText = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(83, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 83)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(83, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(111, 20)
        Me.TextBox1.TabIndex = 1
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
        'Form1
        '
        Me.AcceptButton = Me.btnSendMessage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 554)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.btnSendMessage)
        Me.Controls.Add(Me.chatText)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents chatText As TextBox
    Friend WithEvents btnSendMessage As Button
    Friend WithEvents message As TextBox
    Friend WithEvents tmrGetChatText As Timer
End Class
