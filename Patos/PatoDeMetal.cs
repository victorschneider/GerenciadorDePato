namespace Patos;

public class PatoDeMetal : Pato, IVoar
{
    public PatoDeMetal(string nome, string cor, double peso) : base(nome, cor, peso)
    {
    }

    public void Voar()
    {
        Console.WriteLine($"{nome} está voando!");
    }

    public override void Display()
    {
        Console.WriteLine($"O Pato de metal {nome} é {cor}. ✈");
    }
}