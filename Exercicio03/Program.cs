// Exercício 03 - Classe Produto

public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }

    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.Nome = "Caneta";
        p1.Preco = 2.50;
        p1.Quantidade = 10;

        Produto p2 = new Produto();
        p2.Nome = "Caderno";
        p2.Preco = 18.90;
        p2.Quantidade = 3;

        Produto p3 = new Produto();
        p3.Nome = "Mochila";
        p3.Preco = 129.99;
        p3.Quantidade = 1;

        p1.ExibirDados();
        Console.WriteLine($"Valor total: R$ {p1.CalcularValorTotal():F2}");
        Console.WriteLine();

        p2.ExibirDados();
        Console.WriteLine($"Valor total: R$ {p2.CalcularValorTotal():F2}");
        Console.WriteLine();

        p3.ExibirDados();
        Console.WriteLine($"Valor total: R$ {p3.CalcularValorTotal():F2}");
    }
}
