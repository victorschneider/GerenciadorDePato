namespace Patos;

public class PatoFormoso : Pato, IQuack, IEncantar
{
    // Construtor da classe PatoFormoso que chama o construtor da classe base Pato
    public PatoFormoso(string nome, string cor, double peso) : base(nome, cor, peso){
    }
    public void Quack()
    {
        Console.WriteLine($"O Pato formoso {nome} grasnou!");
    }
    public void Encantar()
    {
        Console.WriteLine($"O Pato formoso {nome} encantou!");
    }
    override public void Display()
    {
        Console.WriteLine($"O Pato formoso {nome} é {cor} e pesa {peso}kg. 🦚");
    }
}