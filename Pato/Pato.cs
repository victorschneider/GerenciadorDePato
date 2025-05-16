namespace Pato;

public abstract class Pato
{
    public string nome { get; set; }
    public string cor { get; set; }
    public double peso { get; set; }

    public Pato(string nome, string cor, double peso)
    {
        this.nome = nome;
        this.cor = cor;
        this.peso = peso;
    }

    public abstract void Display();
    public abstract void Nadar();

    // public abstract void Habilidade();
    //public abstract void DisplayHabilidade();
}
