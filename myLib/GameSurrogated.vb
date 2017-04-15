
Imports System.CodeDom
Imports System.Collections.ObjectModel
Imports System.Reflection

'<DataContract(Name:="Game")> Public Class GameSurrogated
<DataContract> Public Class GameSurrogated
    Implements IDataContractSurrogate

    '<DataMember> Public testArray(4) As Integer


    Public Sub GetKnownCustomDataTypes(customDataTypes As Collection(Of Type)) Implements IDataContractSurrogate.GetKnownCustomDataTypes
        Throw New NotImplementedException()
    End Sub

    Public Function GetCustomDataToExport(clrType As Type, dataContractType As Type) As Object Implements IDataContractSurrogate.GetCustomDataToExport
        Throw New NotImplementedException()
    End Function

    Public Function GetCustomDataToExport(memberInfo As MemberInfo, dataContractType As Type) As Object Implements IDataContractSurrogate.GetCustomDataToExport
        Throw New NotImplementedException()
    End Function

    Public Function GetDataContractType(type As Type) As Type Implements IDataContractSurrogate.GetDataContractType
        Console.WriteLine("GetDataContractType")
        If (GetType(Game).IsAssignableFrom(type)) Then
            Return GetType(GameReplacement)
        End If
        Return type
    End Function

    Public Function GetDeserializedObject(obj As Object, targetType As Type) As Object Implements IDataContractSurrogate.GetDeserializedObject
        Console.WriteLine("GetDeserializedObject")
        If (obj.GetType Is GetType(GameReplacement)) Then

            Dim game As New Game()
            Console.WriteLine("deserialize guppy")
            Return game
        End If
        Return obj
    End Function

    Public Function GetObjectToSerialize(obj As Object, targetType As Type) As Object Implements IDataContractSurrogate.GetObjectToSerialize
        Console.WriteLine("GetObjectToSerialize " + obj.GetType.ToString)
        If (obj.GetType Is GetType(Game)) Then
            Dim gameSur As New GameReplacement
            Dim game As Game = CType(obj, Game)
            'For i As Integer = game.testArray.GetLowerBound(0) To game.testArray.GetUpperBound(0)
            'gameSur.testArray(i) = game.testArray(i)
            'Next
            'gameSur.testArray(0) = 1337
            Return gameSur
        End If
        Return obj
    End Function

    Public Function GetReferencedTypeOnImport(typeName As String, typeNamespace As String, customData As Object) As Type Implements IDataContractSurrogate.GetReferencedTypeOnImport
        Throw New NotImplementedException()
    End Function

    Public Function ProcessImportedType(typeDeclaration As CodeTypeDeclaration, compileUnit As CodeCompileUnit) As CodeTypeDeclaration Implements IDataContractSurrogate.ProcessImportedType
        Throw New NotImplementedException()
    End Function
End Class
