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

    public static List<Pato.Pato> CriaListaDePatos()
    {
        //retorna lista com um modelo exemplo de cada pato para ser exibido no menu principal
        List<Pato.Pato> patos = new List<Pato.Pato>
            {
                new Marreco("Marreco", "", 1),
                new PatoBorracha("Patinho de Borracha", "", 1),
                new PatoCabecaVermelha("Pato da Cabeça Vermelha", "", 1)
            };

        return patos;
    }
    public static void EscolherPato()
    {
        List<Pato.Pato> patos = CriaListaDePatos();


        for (int i = 0; i < patos.Count; i++)
        {
            Console.Clear();
            Console.WriteLine($"\n\t\t{patos[i].nome}");

            //Verifica se é o primeiro pato, pois ele não deve exibir opção anterior
            if (i > 0)
                Console.WriteLine("\n\n<-- Anterior (1)\tMenu (0)\t--> Próximo (2)");
            else
                Console.WriteLine("\n\n\t\tMenu (0)\t--> Próximo (2)");

            int opcao = int.Parse(Console.ReadLine()!);

            //Verifica a opção escolhida e corrige o índice do vetor para a função escolhida
            if (opcao == 0)
            {
                printaMenu();
                break;
            }
            else if (opcao == 1)
            {
                i -= 2;
            }

            //Garanete que o índice não vai ficar numa casa negativa caso o usuário tente retornar o primeiro pato para trás
            if (i < 0)
            {
                i = -1;
            }

        }
    }
    public static void Regras()
    {
        Console.Clear();
        Console.WriteLine("\t=== REGRAS DO JOGO ===\n");
    }
    public static void Creditos()
    {
        Console.Clear();
        Console.WriteLine("Créditos");
    }
    public static void FimDoPrograma()
    {
        Console.Clear();
        Console.WriteLine("Fim do programa!");
    }
}