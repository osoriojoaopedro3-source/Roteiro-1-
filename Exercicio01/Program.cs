// Exercício 01 - Classe Pessoa com atributo Cargo

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo; // a) novo atributo

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Cargo}.");
    }

    // c) o salário não é atributo: é calculado a partir do cargo
    public void InformarSalario()
    {
        string salario;

        switch (Cargo)
        {
            case "Gerente":
                salario = "R$ 10.000,00";
                break;
            case "Desenvolvedor":
                salario = "R$ 5.000,00";
                break;
            case "Estagiário":
                salario = "R$ 100,00";
                break;
            default:
                salario = "não definido";
                break;
        }

        Console.WriteLine($"Salário do cargo {Cargo}: {salario}");
    }
}

public class Program
{
    public static void Main()
    {
        // b) três objetos com os cargos pedidos
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ana";
        p1.Idade = 40;
        p1.Cargo = "Gerente";

        Pessoa p2 = new Pessoa();
        p2.Nome = "Bruno";
        p2.Idade = 28;
        p2.Cargo = "Desenvolvedor";

        Pessoa p3 = new Pessoa();
        p3.Nome = "Carla";
        p3.Idade = 20;
        p3.Cargo = "Estagiário";

        p1.Apresentar();
        p1.InformarSalario();
        Console.WriteLine();

        p2.Apresentar();
        p2.InformarSalario();
        Console.WriteLine();

        p3.Apresentar();
        p3.InformarSalario();
    }
}
