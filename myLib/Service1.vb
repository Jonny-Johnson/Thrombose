' Service1
Imports System
Imports System.IO
Imports System.ServiceModel
Imports System.Text
Imports System.Xml
Imports myLib


Public Class Service1
    Implements IService1


    Public Shared addedNumber As Integer = 0
    Public Shared players As New Dictionary(Of Integer, Player)
    Public Shared game As New Game
    Public Shared chatText As String = ""

    Public Function GetGame() As Game Implements IService1.GetGame

        ''memorystream
        'Dim mem As New MemoryStream
        ''streamreader
        'Dim streamReader As New StreamReader(mem)
        'Dim dcs As New DataContractSerializer(GetType(Game))
        'dcs.WriteObject(mem, game)
        'mem.Position = 0
        'Console.WriteLine(streamReader.ReadToEnd)
        'mem.Position = 0
        'Return streamReader.ReadToEnd


        'Dim xdw As XmlDictionaryWriter = XmlDictionaryWriter.CreateTextWriter(, Encoding.UTF8)
        Return game

    End Function

    Public Function NewConnect(name As String) As Player Implements IService1.NewConnect
        'Check players count to see if a new player can join
        If players.Count < 2 Then
            myLib.Player.IDCounter += 1
            Dim newPlayer = New Player(myLib.Player.IDCounter)
            If name <> "" Then newPlayer.Name = name
            players.Add(newPlayer.ID, newPlayer)
            Console.WriteLine("New player registered with ID: " + CStr(newPlayer.ID))

            'Check players count to see if game can start
            If players.Count = 2 Then
                chatText += "Nachricht vom Server: 2 Spieler sind registriert. Das Spiel kann los gehen. Happy fisting." & vbCrLf
                'game.hasStarted = True 'temp komment bis surrogate ok
            End If

            Return newPlayer
        Else
            Console.WriteLine("There are already two players in this game!")
            Throw New Exception("There are already two players in this game!")
        End If
    End Function

    Public Sub SendMessage(text As String) Implements IService1.SendMessage
        chatText += text & vbCrLf
        Console.WriteLine("Message sent: " + text)
    End Sub

    Public Function GetChatText() As String Implements IService1.GetChatText
        Return chatText
    End Function
End Class