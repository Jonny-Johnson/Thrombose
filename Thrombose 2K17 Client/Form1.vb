Imports System
Imports System.ServiceModel
Imports WindowsApplication1.ServiceReference1

Public Class Form1
    Dim Client As New Service1Client("internet")
    Dim ownPlayer As Player

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ownPlayer = Client.NewConnect()
        Console.WriteLine(ownPlayer.ID)
        Console.WriteLine(ownPlayer.Name)
    End Sub

    Private Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click
        Client.SendMessage(message.Text)
        message.Clear()
    End Sub

    Private Sub tmrGetChatText_Tick(sender As Object, e As EventArgs) Handles tmrGetChatText.Tick
        chatText.Text = Client.GetChatText()
    End Sub

    Private Sub formUnload(sender As Object, e As EventArgs) Handles Me.FormClosing
        Client.Close()
    End Sub
End Class


