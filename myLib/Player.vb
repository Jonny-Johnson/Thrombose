<DataContract()> Public Class Player
    <DataMember()> Public ID As Integer
    <DataMember()> Public Name As String
    'Public Farbe As 

    Public Shared IDCounter As Integer = 0

    Sub New(ByVal newID As Integer)
        ID = newID
        Name = "Guppy"
    End Sub
End Class
