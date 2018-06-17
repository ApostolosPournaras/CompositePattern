Public Class DiskJokey

    Private playList As SongComponent

    Sub New(playlist As SongComponent)
        Me.playList = playlist
    End Sub

    Sub displayPlayList()
        Me.playList.displayInfo()
    End Sub

End Class
