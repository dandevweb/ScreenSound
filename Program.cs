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
