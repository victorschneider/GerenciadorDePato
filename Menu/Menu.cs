using Pato;


namespace Menu;

public class Menu
{
    public static void novoJogo()
    {
        Console.WriteLine("Bem vindo ao Jogo dos Patos!");
        Console.WriteLine("Pressione qualquer tecla para começar!");
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
        //INSTANCIE AQUI NOVA CLASSE DE PATO QUE FOR ADICIONADA EM FOLDER PATO!!!
        List<Pato.Pato> patos = new List<Pato.Pato>
            {
                new Marreco("Marreco", "Marrom, Fardado de BOPE", 150),
                new PatoBorracha("Patinho de Borracha", "Amarelo", 0.1),
                new PatoCabecaVermelha("Pato da Cabeça Vermelha", "Vermelho, Camisa do Inter", 10),
                new PatoDeBriga("Galo de rinha", "Branco", 7),
                new PatoCruzeirense ("GABIGOL", "Camisa do Cruzeiro", 82),
                new PatoFormoso("Ivan Luiz", "Pardo", 90),
                new PatoSaltitante ("Saltitão", "Branco", 350),
                new PatoAquatico("Definitivamente não é um pinguin", "Terno", 7),
                new PatoDeMetal("É um OVNI? é um Avião? Não, é o pato de metal", "Prata", 40)
            };

        return patos;
    }
    public static void EscolherPato()
    {
        List<Pato.Pato> patos = CriaListaDePatos();
        int index = 0;

        while (index >= 0 && index < patos.Count)
        {
            Console.Clear();
            Console.WriteLine($"\n\t\t{patos[index].nome}\n");
            patos[index].Display();

            Console.WriteLine("\n\nSelecione a opção:");
            if (index > 0)
                Console.WriteLine("<-- Anterior (1)");
            Console.WriteLine("Menu (0)");
            if (index < patos.Count - 1)
                Console.WriteLine("--> Próximo (2)");
            Console.WriteLine("Escolher este pato (3)");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    printaMenu();
                    return;
                case "1":
                    if (index > 0) index--;
                    break;
                case "2":
                    if (index < patos.Count - 1) index++;
                    break;
                case "3":
                    HabilidadesDoPato(patos[index]);
                    return;
                default:
                    Console.WriteLine("Opção inválida. Pressione ENTER para continuar.");
                    Console.ReadLine();
                    break;
            }
        }
    }


    public static void HabilidadesDoPato(Pato.Pato pato)
    {
        string opcao = "";

        // Enquanto o usuário não escolher sair (opção "0"), continua interagindo
        while (opcao != "0")
        {
            Console.Clear();
            Console.WriteLine($"\nVocê escolheu o pato: {pato.nome}\n");
            Console.WriteLine("Escolha uma habilidade para usar:");
            Console.WriteLine("1 - Display");

            // Checando as interfaces implementadas
            // SUJEITO A MUDANÇAS JÁ QUE AINDA PRECISAMOS ADICIONAR MAIS PATOS!!!
            if (pato is INadar) Console.WriteLine("2 - Nadar");
            if (pato is IQuack) Console.WriteLine("3 - Quack");
            if (pato is IVoar) Console.WriteLine("4 - Voar");
            if (pato is IBrigar) Console.WriteLine("5 - Brigar");
            if (pato is IEncantar) Console.WriteLine("6 - Encantar");
            if (pato is IPular) Console.WriteLine("7 - Pular");


            Console.WriteLine("0 - Voltar ao Menu");

            opcao = Console.ReadLine()!;

            switch (opcao)
            {
                case "1":
                    pato.Display();
                    break;
                case "2":
                if (pato is INadar nadador)
                        nadador.Nadar();
                    else
                        Console.WriteLine("Este pato não sabe nadar.");
                    break;
                case "3":
                    if (pato is IQuack quackavel)
                        quackavel.Quack();
                    else
                        Console.WriteLine("Este pato não sabe grasnar.");
                    break;
                case "4":
                    if (pato is IVoar voador)
                        voador.Voar();
                    else
                        Console.WriteLine("Este pato não sabe voar.");
                    break;
                case "5":
                    if (pato is IBrigar brigador)
                        brigador.Brigar();
                    else
                        Console.WriteLine("Este pato não sabe brigar.");
                    break;

                case "6":
                    if (pato is IEncantar encantador)
                        encantador.Encantar();
                    else
                        Console.WriteLine("Este pato não sabe encantar.");
                    break;

                case "7":   
                    if (pato is IPular pulador)
                        pulador.Pular();
                    else
                        Console.WriteLine("Este pato não sabe pular.");
                    break;
                case "0":
                    // Sai do loop e retorna ao menu principal
                    printaMenu();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            // Evita pular direto para o menu se a opção foi válida mas não foi "0"
            if (opcao != "0")
            {
                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }

    public static void Regras()
    {
        Console.Clear();
        Console.WriteLine("\t=== REGRAS DO JOGO ===\n");
        Console.WriteLine("Ainda estamos pensando sobre!");
    }
    public static void Creditos()
    {
        Console.Clear();
        Console.WriteLine("Créditos");
        Console.WriteLine("Victor Schneider: Patólogo e Lead Designer");
        Console.WriteLine("Igor Maia: Navegation Designer e Patologista Junior");
        Console.WriteLine("Luis Sampaio: C# Character Modeler e Entusiasta da Cosmopatolia");
    }
    public static void FimDoPrograma()
    {
        Console.Clear();
        Console.WriteLine("Fim do programa!");
    }
}