class Album
{
    private List<Music> musics = new List<Music>();

    public string Name { get; set; }
    public int Duration => musics.Sum(m => m.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void showMusics()
    {
        Console.WriteLine($"Lista de músicas do Álbum: {Name}\n");
        foreach (Music music in musics)
        {
            Console.WriteLine($"Música: {music.Name}");
        }

        Console.WriteLine($"\nDuração total do álbum: {Duration} segundos");
    }

}
