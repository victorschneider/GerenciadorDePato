namespace Patos;

public class PatoDeBriga : Pato, IVoar, IQuack, IBrigar
{
    // Construtor da classe PatoDeBriga que chama o construtor da classe base Pato
    public PatoDeBriga(string nome, string cor, double peso) : base(nome, cor, peso){
    }
    public void Quack()
    {
        Console.WriteLine($"O Pato de briga {nome} grasnou!");
    }
    public void Voar()
    {
        Console.WriteLine($"O Pato de briga {nome} voou!");
    }
    public void Brigar()
    {
        Console.WriteLine($"O Pato de briga {nome} brigou!");
    }
    override public void Display()
    {
        Console.WriteLine($"O Pato de briga {nome} é {cor} e pesa {peso}kg. 🐓");
    }
}