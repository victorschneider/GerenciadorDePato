using Pato;
using Menu;
namespace Atividade_grupo;

class Program
{
    static void Main(string[] args)
    {
        Menu.Menu.novoJogo();
        
        // Marreco marreco = new Marreco("Patudo", "Marrom", 2.5);
        // PatoBorracha patoBorracha = new PatoBorracha("Petroleo", "Amarelo", 1.2);
        // PatoCabecaVermelha patoCabeca = new PatoCabecaVermelha("Internaciopato", "Vermelho e branco", 2.0);

        // bool continuar = true;
        // while (continuar)
        // {
        //     Console.Clear();
        //     Console.WriteLine("=== MENU DOS PATOS ===");
        //     Console.WriteLine("1 - Ver Marreco");
        //     Console.WriteLine("2 - Ver Pato de Borracha");
        //     Console.WriteLine("3 - Ver Pato Cabeça Vermelha");
        //     Console.WriteLine("0 - Sair");
        //     Console.Write("Escolha uma opção: ");

        //     string opcao = Console.ReadLine()!;

        //     switch (opcao)
        //     {
        //         case "1":
        //             MostrarInfoPato(marreco);
        //             break;
        //         case "2":
        //             MostrarInfoPato(patoBorracha);
        //             break;
        //         case "3":
        //             MostrarInfoPato(patoCabeca);
        //             break;
        //         case "0":
        //             continuar = false;
        //             break;
        //         default:
        //             Console.WriteLine("Opção inválida. Pressione ENTER para continuar.");
        //             Console.ReadLine();
        //             break;
        //     }
        // }

        // static void MostrarInfoPato(Pato.Pato pato)
        // {
        //     Console.Clear();
        //     pato.display();

        //     if (pato is IQuack quacker)
        //         quacker.Quack();

        //     if (pato is IVoar voador)
        //         voador.Voar();

        //     pato.Nadar();

        //     Console.WriteLine("\n1 - Selecionar este pato");
        //     Console.WriteLine("2 - Voltar ao menu");
        //     Console.Write("Escolha uma opção: ");
        //     string escolha = Console.ReadLine()!;

        //     if (escolha == "1")
        //     {
        //         Console.WriteLine($"\nVocê selecionou o {pato.nome}!");
        //         Console.WriteLine("Pressione ENTER para voltar ao menu.");
        //         Console.ReadLine();
        //     }
        // }


    }
}
