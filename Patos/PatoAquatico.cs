namespace Patos;

public class PatoAquatico : Pato, INadar
{
    public PatoAquatico(string nome, string cor, double peso) : base(nome, cor, peso)
    {
    }

    public void Nadar()
    {
        Console.WriteLine($"{nome} está nadando!");
    }
    public override void Display()
    {
        Console.WriteLine($"O Pato aquático {nome} é {cor}. 🐧");
    }
}