using System;

class Calculadora
{
    public double Somar(double a, double b) => a + b;
    public double Subtrair(double a, double b) => a - b;
    public double Multiplicar(double a, double b) => a * b;
    public double Dividir(double a, double b) => a / b;
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora calc = new Calculadora();
        Console.WriteLine("Soma: " + calc.Somar(5, 3));
        Console.WriteLine("Divisão: " + calc.Dividir(10, 2));
    }
}
