namespace Pato;

public class PatoBorracha : Pato, IQuack
{
    // Construtor da classe PatoBorracha que chama o construtor da classe base Pato
    public PatoBorracha(string nome, string cor, double peso) : base(nome, cor, peso)
    {
    }
    public void Quack()
    {
        Console.WriteLine($"O Pato de borracha {nome} grasnou!");
    }
    override public void Nadar()
    {
        Console.WriteLine($"O Pato de borracha {nome} nadou!");
    }
    public override void Display()
    {
        Console.WriteLine($"Pato de borracha:\nNome = {nome}, Cor = {cor}, Peso = {peso}kg");
    }
    // public override void Poder()
    // {
    //     throw new NotImplementedException();
    // }
}