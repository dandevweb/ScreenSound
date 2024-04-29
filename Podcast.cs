class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public int totalEpisodes => episodios.Count;

    public void AddEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ShowEpisodios()
    {
        Console.WriteLine($"Podcast: {Name} apresentado por {Host}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Order))
        {
            Console.WriteLine(episodio.Resume);
        }

        Console.WriteLine($"\n\nTotal de episódios: {totalEpisodes}");
    }
}
