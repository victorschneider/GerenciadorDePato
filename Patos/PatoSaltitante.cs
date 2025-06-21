namespace Patos;

public class PatoSaltitante : Pato, IPular
{
    public PatoSaltitante(string nome, string cor, double peso) : base(nome, cor, peso)
    {

    }

    public void Pular()
    {
        Console.WriteLine($"{nome} está pulando!");
    }
    public override void Display()
    {
        Console.WriteLine($"O Pato saltitante {nome} é {cor}. 🦆");
    }
}