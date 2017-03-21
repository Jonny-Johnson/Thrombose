' IService1
Imports System
Imports System.ServiceModel


<ServiceContract()>
Public Interface IService1
    <OperationContract()>
    Function NewConnect(name As String) As Player

    <OperationContract()>
    Sub SendMessage(ByVal text As String)

    <OperationContract()>
    Function GetChatText() As String
End Interface