using System;

class Triangulo
{
    public double Lado1, Lado2, Lado3;

    public Triangulo(double lado1, double lado2, double lado3)
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public double Perimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Triangulo t = new Triangulo(3, 4, 5);
        Console.WriteLine("Perímetro do triângulo: " + t.Perimetro());
    }
}
