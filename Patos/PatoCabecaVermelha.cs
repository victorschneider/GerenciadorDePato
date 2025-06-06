namespace Patos;

public class PatoCabecaVermelha : Pato, IQuack, IVoar, INadar
{
    // Construtor da classe PatoCabecaVermelha que chama o construtor da classe base Pato
    public PatoCabecaVermelha(string nome, string cor, double peso) : base(nome, cor, peso){
    }

    public void Quack(){
        Console.WriteLine($"O pato cabeca vermelha {nome} grasnou!");
    }

    public void Voar(){
        Console.WriteLine($"O pato cabeca vermelha {nome} voou!");
    }
    
    public void Nadar(){
        Console.WriteLine($"O pato cabeca vermelha {nome} nadou!");
    }

    
    public override void Display(){
        Console.WriteLine($"Pato cabeca vermelha:\nNome = {nome}, Cor = {cor}, Peso = {peso}kg");
    }
}
