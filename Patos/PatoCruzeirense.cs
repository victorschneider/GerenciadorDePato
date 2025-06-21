namespace Patos;

public class PatoCruzeirense : Pato, IEncantar, IBrigar
{
    public PatoCruzeirense(string nome, string cor, double peso) : base(nome, cor, peso)
    {
    }

    public void Encantar()
    {
        Console.WriteLine($"{nome} está encantando!");
    }

    public void Brigar()
    {
        Console.WriteLine($"{nome} está brigando!");
    } 
    public override void Display()
    {
        Console.WriteLine($"O Pato cruzeirense {nome} é {cor}. 🦊");
    }
}