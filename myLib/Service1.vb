' Service1
Imports System
Imports System.ServiceModel
Imports myLib


Public Class Service1
    Implements IService1

    Public Shared addedNumber As Integer = 0
    Public Shared players As New Dictionary(Of Integer, Player)
    Public Shared chatText As String = ""

    Public Function NewConnect(name As String) As Player Implements IService1.NewConnect
        myLib.Player.IDCounter += 1
        Dim newPlayer = New Player(myLib.Player.IDCounter)
        If name <> "" Then newPlayer.Name = name
        players.Add(newPlayer.ID, newPlayer)
        Console.WriteLine("New player registered with ID: " + CStr(newPlayer.ID))
        Return newPlayer
    End Function

    Public Sub SendMessage(text As String) Implements IService1.SendMessage
        chatText += text & vbCrLf
        Console.WriteLine("Message sent: " + text)
    End Sub

    Public Function GetChatText() As String Implements IService1.GetChatText
        Return chatText
    End Function
End Class