// Exercício 02 - Classe Fantasma (PAC-MAN)

public class Fantasma
{
    public string Habilidade;
    public string Nick;
    public string Cor;

    public void GerarFantasma()
    {
        Console.WriteLine("Fantasma gerado!");
        Console.WriteLine($"  Nick: {Nick}");
        Console.WriteLine($"  Cor: {Cor}");
        Console.WriteLine($"  Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}

public class Program
{
    public static void Main()
    {
        Fantasma f1 = new Fantasma();
        f1.Nick = "Blinky";
        f1.Cor = "Vermelho";
        f1.Habilidade = "Persegue o Pac-Man diretamente";

        Fantasma f2 = new Fantasma();
        f2.Nick = "Pinky";
        f2.Cor = "Rosa";
        f2.Habilidade = "Tenta emboscar o Pac-Man pela frente";

        Fantasma f3 = new Fantasma();
        f3.Nick = "Inky";
        f3.Cor = "Ciano";
        f3.Habilidade = "Movimento imprevisível";

        Fantasma f4 = new Fantasma();
        f4.Nick = "Clyde";
        f4.Cor = "Laranja";
        f4.Habilidade = "Foge quando chega perto";

        f1.GerarFantasma();
        f2.GerarFantasma();
        f3.GerarFantasma();
        f4.GerarFantasma();
        Console.WriteLine();

        f1.Mover("cima");
        f2.Mover("esquerda");
        f3.Mover("direita");
        f4.Mover("baixo");
    }
}
