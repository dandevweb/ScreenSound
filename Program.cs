Banda queen = new Banda("Queen");

Album albumQueen = new Album("A night at the opera");

Music music1 = new Music(queen, "Death on two legs")
{
    Duration = 213,
    Available = true
};

Music music2 = new Music(queen, "Lazing on a sunday afternoon")
{
    Duration = 65,
    Available = false
};

albumQueen.AddMusic(music1);
albumQueen.AddMusic(music2);
queen.AddAlbum(albumQueen);

music1.ShowInfo();
music2.ShowInfo();


queen.ShowAlbums();


Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AddGuest("João");
ep1.AddGuest("Maria");
Console.WriteLine(ep1.Resume);

Episodio ep2 = new(1, "Técnicas de aprendizado", 45);
ep2.AddGuest("João");
ep2.AddGuest("Maria");
ep2.AddGuest("José");

Podcast podcast = new("Podcast de tecnologia", "Danilo");
podcast.AddEpisodio(ep1);
podcast.AddEpisodio(ep2);
podcast.ShowEpisodios();

