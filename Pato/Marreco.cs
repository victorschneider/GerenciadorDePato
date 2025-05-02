namespace	Pato;

public class Marreco : Pato, IQuack, IVoar
{

    // Construtor da classe Marreco que chama o construtor da classe base Pato
	public Marreco(string nome, string cor, double peso) : base(nome, cor, peso){
	}
    public void Quack(){
        Console.WriteLine($"O marreco {nome} grasnou!");
    }

    public void Voar(){
        Console.WriteLine($"O marreco {nome} voou!");
    }
    
    override public void Nadar(){
        Console.WriteLine($"O marreco {nome} nadou!");
    }

    public override void display(){
        Console.WriteLine($"Marreco:\nNome = {nome}, Cor = {cor}, Peso = {peso}kg");
    }
}