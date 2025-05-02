using Pato;
namespace Atividade_grupo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simulador de Patos!");

        Console.WriteLine("Escolha seu tipo de pato:");
        Console.WriteLine("1 - Marreco / 2 - Pato de Borracha / 3 - Pato Cabeça Vermelha");
        string tipoEscolhido = Console.ReadLine();

        Console.Write("Digite o nome do pato: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a cor do pato: ");
        string cor = Console.ReadLine();

        double peso = 0;
        while (true)
        {
            Console.Write("Digite o peso do pato (kg): ");
            if (double.TryParse(Console.ReadLine(), out peso))
                break;
            Console.WriteLine("Peso inválido. Tente novamente.");
        }

        Pato.Pato patoCriado = null; 

        switch (tipoEscolhido)
        {
            case "1":
                patoCriado = new Marreco(nome, cor, peso);
                break;
            case "2":
                patoCriado = new PatoBorracha(nome, cor, peso);
                break;
            case "3":
                patoCriado = new PatoCabecaVermelha(nome, cor, peso);
                break;
            default:
                Console.WriteLine("Tipo inválido. Encerrando.");
                return;
        }

        Console.WriteLine("\n--- Pato Criado ---");
        patoCriado.display();
        patoCriado.Nadar();

        if (patoCriado is IQuack quackPato)
        {
            quackPato.Quack();
        }

        if (patoCriado is IVoar voadorPato)
        {
            voadorPato.Voar();
        }

        Console.WriteLine("---------------------");

    }
}
