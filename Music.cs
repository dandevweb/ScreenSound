class Music
{
  public string name;
  public string artist;
  public int duration;
  public bool available;

  public void ShowInfo()
  {
    Console.WriteLine($"Nome: {name}");
    Console.WriteLine($"Artista: {artist}");
    Console.WriteLine($"Duração: {duration}");
    string isAvailable = available ? "Sim" : "Não";
    Console.WriteLine($"Disponível no plano: {isAvailable}");
  }
}
