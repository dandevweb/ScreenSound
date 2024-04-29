Album albumQueen = new Album();

albumQueen.Name = "A night at the opera";

Music music1 = new Music();
music1.Name = "Death on two legs";
music1.Duration = 213;

Music music2 = new Music();
music2.Name = "Lazing on a sunday afternoon";
music2.Duration = 65;

albumQueen.AddMusic(music1);
albumQueen.AddMusic(music2);
albumQueen.showMusics();
