namespace Pato;

public class PatoCabecaVermelha : Pato, IQuack, IVoar
{
    // Construtor da classe PatoCabecaVermelha que chama o construtor da classe base Pato
    public PatoCabecaVermelha(string nome, string cor, double peso) : base(nome, cor, peso){
    }

    public void Quack(){
        Console.WriteLine("O pato cabeca vermelha grasnou!");
    }

    public void Voar(){
        Console.WriteLine("O pato cabeca vermelha voou!");
    }
    
    override public void Nadar(){
        Console.WriteLine("O pato cabeca vermelha nadou!");
    }

    
    public override void display(){
        Console.WriteLine($"Pato cabeca vermelha:\nNome = {nome}, Cor = {cor}, Peso = {peso}kg");
    }
}
