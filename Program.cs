namespace Atividade_grupo;

class Program
{
    static void Main(string[] args)
    {
        // Teste pato de borracha
        Pato.PatoBorracha pato1 = new Pato.PatoBorracha("Pato Borracha", "Amarelo", 0.5);
        pato1.display();
        pato1.Nadar();
        pato1.Quack();
        Console.WriteLine("");

        //Teste pato Marreco
        Pato.Marreco pato2 = new Pato.Marreco("Pato Marreco", "Manchado", 3.7);
        pato2.display();
        pato2.Nadar();
        pato2.Quack();
        pato2.Voar();
        Console.WriteLine("");

        //Teste pato cabeca vermelha
        Pato.PatoCabecaVermelha pato3 = new Pato.PatoCabecaVermelha("Pato Cabeca Vermelha", "Vermelho", 2.5);
        pato3.display();
        pato3.Nadar();
        pato3.Quack();
        pato3.Voar();
        Console.WriteLine("");
    }
}
