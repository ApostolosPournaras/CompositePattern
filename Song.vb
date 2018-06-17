Public Class Song
    Inherits SongComponent


    Protected artistNameValue As String
    Public ReadOnly Property artistName() As String
        Get
            Return artistNameValue
        End Get
    End Property

    Protected songTitleValue As String
    Public ReadOnly Property songTitle() As String
        Get
            Return songTitleValue
        End Get
    End Property

    Protected releaseYearValue As Integer
    Public ReadOnly Property releaseYear() As Integer
        Get
            Return releaseYearValue
        End Get
    End Property


    Sub New(artistName As String, songTitle As String, releaseYear As Integer)
        Me.artistNameValue = artistName
        Me.songTitleValue = songTitle
        Me.releaseYearValue = releaseYear
    End Sub


    Overrides Sub displayInfo()
        Console.WriteLine(" > " & Me.artistName & " - " & Me.songTitle & "(" & Me.releaseYear & ")")
    End Sub
End Class
