namespace Menu;

public class ExibidorDeCreditos
{
    public void Exibir()
    {
        Console.Clear();
        Console.WriteLine("Créditos");
        Console.WriteLine("Victor Schneider: Patólogo e Lead Designer");
        Console.WriteLine("Igor Maia: Navegation Designer e Patologista Junior");
        Console.WriteLine("Luis Sampaio: C# Character Modeler e Entusiasta da Cosmopatolia");

        Console.WriteLine("\nPressione ENTER para voltar ao menu.");
        Console.ReadLine();
        new MenuPrincipal().ExibirMenu();
    }
}
