Music music1 = new Music();
music1.Name = "The Sound of Music";
music1.Artist = "Julie Andrews";
music1.Duration = 173;
music1.Available = true;
Console.WriteLine(music1.Description);

Music music2 = new Music();
music2.Name = "Vertigo";
music2.Artist = "U2";
music2.Duration = 189;
music2.Available = false;

music1.ShowInfo();
music2.ShowInfo();
