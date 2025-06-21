namespace Menu;

public class MenuPrincipal
{
    public void ExibirMenu()
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
                new SelecionadorDePato().Escolher();
                break;
            case "2":
                new ExibidorDeRegras().Exibir();
                break;
            case "3":
                new ExibidorDeCreditos().Exibir();
                break;
            case "4":
                Console.Clear();
                Console.WriteLine("Fim do programa!");
                break;
            default:
                Console.WriteLine("Opção inválida. Pressione ENTER para voltar ao menu.");
                Console.ReadLine();
                ExibirMenu();
                break;
        }
    }
}
