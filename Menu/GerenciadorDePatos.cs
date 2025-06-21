namespace Patos;
public class GerenciadorDePatos
{
    public List<Pato> CriarLista()
    {
        return new List<Pato>
        {
            new Marreco("Marreco", "Marrom, Fardado de BOPE", 150),
            new PatoBorracha("Patinho de Borracha", "Amarelo", 0.1),
            new PatoCabecaVermelha("Pato da Cabeça Vermelha", "Vermelho, Camisa do Inter", 10),
            new PatoDeBriga("Galo de rinha", "Branco", 7),
            new PatoCruzeirense ("GABIGOL", "Camisa do Cruzeiro", 82),
            new PatoFormoso("Ivan Luiz", "Pardo", 90),
            new PatoSaltitante ("Saltitão", "Branco", 350),
            new PatoAquatico("Definitivamente não é um pinguim", "Terno", 7),
            new PatoDeMetal("É um OVNI? É um Avião? Não, é o pato de metal", "Prata", 40)
        };
    }
}
