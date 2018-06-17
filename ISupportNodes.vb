Public MustInherit Class SongComponent

    Overridable Sub addComponent(component As SongComponent)
        Throw New NotSupportedException("addComponent is not supported")
    End Sub

    Overridable Sub removeComponent(component As SongComponent)
        Throw New NotSupportedException("removeComponent is not supported")
    End Sub

    Overridable Function getComponent(index As Integer) As SongComponent
        Throw New NotSupportedException("getComponent is not supported")
    End Function

    Overridable Sub displayInfo()
        Throw New NotSupportedException("printComponent is not supported")
    End Sub

End Class
