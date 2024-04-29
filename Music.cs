class Music
{
  public Music(Banda artist, string name)
  {
    Artist = artist;
    Name = name;
  }

  public string Name { get; }
  public Banda Artist { get; }
  public int Duration { get; set; }
  public bool Available { get; set; }
  public string Description => $"A música {Name} de {Artist} tem duração de {Duration} segundos.";

  public void ShowInfo()
  {
    Console.WriteLine($"Nome: {Name}");
    Console.WriteLine($"Artista: {Artist.Name}");
    Console.WriteLine($"Duração: {Duration}");
    string isAvailable = Available ? "Sim" : "Não";
    Console.WriteLine($"Disponível no plano: {isAvailable}");
  }
}
