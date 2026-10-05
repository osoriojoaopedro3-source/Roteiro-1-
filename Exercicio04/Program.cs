// Exercício 04 - Classe ContaBancaria

public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    public double Saldo;

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de depósito inválido.");
            return;
        }

        Saldo += valor;
        Console.WriteLine($"Depósito de R$ {valor:F2} realizado na conta {NumeroConta}.");
    }

    public void Sacar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else if (valor > Saldo)
        {
            // não permite saldo negativo
            Console.WriteLine($"Saque de R$ {valor:F2} negado: saldo insuficiente na conta {NumeroConta}.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado na conta {NumeroConta}.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular} | Conta: {NumeroConta} | Saldo: R$ {Saldo:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria c1 = new ContaBancaria();
        c1.Titular = "Joao";
        c1.NumeroConta = 1001;

        ContaBancaria c2 = new ContaBancaria();
        c2.Titular = "Maria";
        c2.NumeroConta = 1002;

        c1.Depositar(500);
        c1.Sacar(200);
        c1.Sacar(1000); // deve ser negado
        c1.ExibirSaldo();
        Console.WriteLine();

        c2.Depositar(80);
        c2.Sacar(50);
        c2.Sacar(40);    // deve ser negado
        c2.Depositar(-10); // valor inválido
        c2.ExibirSaldo();
    }
}
