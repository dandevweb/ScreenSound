class Episodio
{
    private List<string> guests = new();

    public Episodio(int order, string title, int duration)
    {
        Order = order;
        Title = title;
        Duration = duration;
    }
    
    public int Order { get; }
    public string Title { get; }
    public int Duration { get; }
    public string Resume => $"Episódio {Order} - {Title} ({Duration} minutos) - {string.Join(", ", guests)}";

    public void AddGuest(string guest)
    {
        guests.Add(guest);
    }
}
