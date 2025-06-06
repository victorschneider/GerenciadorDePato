using Patos;
using Menu;

namespace Atividade_grupo;

class Program
{
    static void Main(string[] args){

        Console.WriteLine("Bem-vindo ao Jogo dos Patos!");
        Console.WriteLine("Pressione qualquer tecla para começar!");
        Console.ReadKey();

        new MenuPrincipal().ExibirMenu();
    }
}