Imports System
Imports System.ServiceModel
Imports WindowsApplication1.ServiceReference1

Public Class frmThrombose
    Dim Server As New Service1Client("localhost")
    Dim ownPlayer As Player

    Private Sub btnNewPlayer_Click(sender As Object, e As EventArgs) Handles btnNewPlayer.Click
        ownPlayer = Server.NewConnect(txtPlayerName.Text)
        lblPlayer.Text = String.Format("Hallo, {0}. Viel Erfolg!", ownPlayer.Name)
        Console.WriteLine(ownPlayer.ID)
        Console.WriteLine(ownPlayer.Name)
    End Sub

    Private Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click
        Server.SendMessage(txtMessage.Text)
        txtMessage.Clear()
    End Sub

    Private Sub tmrGetChatText_Tick(sender As Object, e As EventArgs) Handles tmrGetChatText.Tick
        txtChat.Text = Server.GetChatText()
    End Sub

    Private Sub formUnload(sender As Object, e As EventArgs) Handles Me.FormClosing
        Server.Close()
    End Sub

    Private Sub tmrGetGame_Tick(sender As Object, e As EventArgs) Handles tmrGetGame.Tick

        'If Server.GetGame.hasStarted Then
        Dim game As Game = Server.GetGame()
        Server.SendMessage(game.testArray(0))
        Server.SendMessage(game.testArray(1))
        'End If
    End Sub
End Class


