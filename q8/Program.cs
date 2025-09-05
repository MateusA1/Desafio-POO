using System;

class ContaBancaria
{
    public double Saldo = 0;

    public void Depositar(double valor)
    {
        Saldo += valor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria();
        conta.Depositar(500);

        Console.WriteLine("Saldo: " + conta.Saldo);
    }
}
