Module Module1

    Sub Main()

        Dim playList As New SongGroup("Play List", "All tracks")
        Dim houseCollection As New SongGroup("House", "house genre")
        Dim JazzCollection As New SongGroup("Jazz", "Jazz genre")

        playList.addComponent(houseCollection)
        playList.addComponent(JazzCollection)

        Dim BennasiCollection As New SongGroup("Benassi", "Benny Benassi best tracks")
        Dim GuettaCollection As New SongGroup("Guetta", "David Guetta best tracks")

        houseCollection.addComponent(BennasiCollection)
        houseCollection.addComponent(GuettaCollection)

        BennasiCollection.addComponent(New Song("Benny Benassi", "Satisfaction", 2003))
        BennasiCollection.addComponent(New Song("Benny Benassi", "I Love My Sex", 2003))
        BennasiCollection.addComponent(New Song("Benny Benassi", "Illusion (Sfaction Version)", 2004))
        BennasiCollection.addComponent(New Song("Benny Benassi", "Get Better (Sflow Version)", 2004))

        GuettaCollection.addComponent(New Song("David Guetta", "Dangerous", 2014))
        GuettaCollection.addComponent(New Song("David Guetta", "Love Is Gone", 2007))

        JazzCollection.addComponent(New Song("Billie Holiday", "Strange Fruit", 1965))
        JazzCollection.addComponent(New Song("Johnny Hartman", "Lush Life", 1953))

        Dim radioDJ As New DiskJokey(playList)

        radioDJ.displayPlayList()

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
