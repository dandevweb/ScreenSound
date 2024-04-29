class Banda 
{

    private List<Album> albums = new List<Album>();

    public Banda(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowAlbums()
    {
        Console.WriteLine($"Lista de álbuns da Banda: {Name}\n");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Álbum: {album.Name} ({album.Duration})");
        }
    }
}
