namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }
    public static Avaliacao Parse(string nota) => new Avaliacao(int.Parse(nota));
}
