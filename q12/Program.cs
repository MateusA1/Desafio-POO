using System;

class Funcionario
{
    public string Nome;
    public double Salario;

    public Funcionario(string nome, double salario)
    {
        Nome = nome;
        Salario = salario;
    }

    public void AumentarSalario(double percentual)
    {
        Salario += Salario * (percentual / 100);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario("Carlos", 2000);
        f.AumentarSalario(10);
        Console.WriteLine("Salário após aumento: " + f.Salario);
    }
}
