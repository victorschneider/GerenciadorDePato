using Pato;


namespace Menu;

public class Menu
{
    public static void novoJogo()
    {
        Console.WriteLine("Bem vindo ao Jogo dos Patos!");
        Console.ReadKey();
        printaMenu();
    }

    public static void printaMenu()
    {
        Console.Clear();
        Console.WriteLine("\t=== MENU DOS PATOS ===\n");

        Console.WriteLine("Insira a opção desejada:\n");

        Console.WriteLine("1- Escolher seu Pato");
        Console.WriteLine("2- Regras do Jogo");
        Console.WriteLine("3- Créditos");
        Console.WriteLine("4- Sair do Programa");

        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                EscolherPato();
                break;
            case "2":
                Regras();
                break;
            case "3":
                Creditos();
                break;
            case "4":
                FimDoPrograma();
                break;
            default:
                Console.WriteLine("Opção inválida. Pressione ENTER para voltar ao menu.");
                Console.ReadLine();
                printaMenu();
                break;
        }
    }

    public static void EscolherPato()
    {
        Console.WriteLine("Escolha seu pato:");
    }
    public static void Regras()
    {
        Console.WriteLine("Regras");
    }
    public static void Creditos()
    {
        Console.WriteLine("Créditos");
    }
    public static void FimDoPrograma()
    {
        Console.WriteLine("Fim do programa!");
    }
}