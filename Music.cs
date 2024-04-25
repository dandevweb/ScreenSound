class Music
{
  public string Name { get; set; }
  public string Artist { get; set; }
  public int Duration { get; set; }
  public bool Available { get; set; }
  public string Description => $"A música {Name} de {Artist} tem duração de {Duration} segundos.";
    

  public void ShowInfo()
  {
    Console.WriteLine($"Nome: {Name}");
    Console.WriteLine($"Artista: {Artist}");
    Console.WriteLine($"Duração: {Duration}");
    string isAvailable = Available ? "Sim" : "Não";
    Console.WriteLine($"Disponível no plano: {isAvailable}");
  }
}
