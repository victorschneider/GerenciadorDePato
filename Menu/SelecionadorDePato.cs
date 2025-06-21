using Patos;

namespace Menu;

public class SelecionadorDePato
{
    public void Escolher()
    {
        var patos = new GerenciadorDePatos().CriarLista();
        int index = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\n\t\t{patos[index].nome}\n");
            patos[index].Display();

            Console.WriteLine("\n\nSelecione a opção:");
            if (index > 0) Console.WriteLine("<-- Anterior (1)");
            Console.WriteLine("Menu (0)");
            if (index < patos.Count - 1) Console.WriteLine("--> Próximo (2)");
            Console.WriteLine("Escolher este pato (3)");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    new MenuPrincipal().ExibirMenu();
                    return;
                case "1":
                    if (index > 0) index--;
                    break;
                case "2":
                    if (index < patos.Count - 1) index++;
                    break;
                case "3":
                    ExibirHabilidades((Pato)patos[index]);
                    return;
                default:
                    Console.WriteLine("Opção inválida. Pressione ENTER para continuar.");
                    Console.ReadLine();
                    break;
            }
        }
    }

    private void ExibirHabilidades(Pato pato)
    {
        string opcao = "";

        while (opcao != "0")
        {
            Console.Clear();
            Console.WriteLine($"\nVocê escolheu o pato: {pato.nome}\n");
            Console.WriteLine("Escolha uma habilidade para usar:");
            Console.WriteLine("1 - Display");

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
                    (pato as INadar)?.Nadar();
                    break;
                case "3":
                    (pato as IQuack)?.Quack();
                    break;
                case "4":
                    (pato as IVoar)?.Voar();
                    break;
                case "5":
                    (pato as IBrigar)?.Brigar();
                    break;
                case "6":
                    (pato as IEncantar)?.Encantar();
                    break;
                case "7":
                    (pato as IPular)?.Pular();
                    break;
                case "0":
                    new MenuPrincipal().ExibirMenu();
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (opcao != "0")
            {
                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}
