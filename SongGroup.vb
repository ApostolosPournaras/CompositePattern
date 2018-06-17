Public Class SongGroup
    Inherits SongComponent

    Private componentsList As New List(Of SongComponent)

    Protected groupNameValue As String
    Public ReadOnly Property groupName() As String
        Get
            Return groupNameValue
        End Get
    End Property

    Protected groupDescriptionValue As String
    Public ReadOnly Property groupDescription() As String
        Get
            Return groupDescriptionValue
        End Get
    End Property


    Sub New(groupName As String, groupDescription As String)
        Me.groupNameValue = groupName
        Me.groupDescriptionValue = groupDescription
    End Sub


    Overrides Sub addComponent(component As SongComponent)
        componentsList.Add(component)
    End Sub

    Overrides Sub removeComponent(component As SongComponent)
        componentsList.Remove(component)
    End Sub

    Overrides Function getComponent(index As Integer) As SongComponent
        Return componentsList(index)
    End Function

    Overrides Sub displayInfo()
        Console.WriteLine("------ " & Me.groupName & ": " & Me.groupDescription & " ------ ")

        For Each comp As SongComponent In componentsList
            comp.displayInfo()
        Next

    End Sub
End Class
