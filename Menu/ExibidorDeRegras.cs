namespace Menu;

public class ExibidorDeRegras
{
    public void Exibir()
    {
        Console.Clear();
        Console.WriteLine("\t=== REGRAS DO JOGO ===\n");
        Console.WriteLine("Ainda estamos pensando sobre!");
        Console.WriteLine("\nPressione ENTER para voltar ao menu.");
        Console.ReadLine();
        new MenuPrincipal().ExibirMenu();
    }
}
