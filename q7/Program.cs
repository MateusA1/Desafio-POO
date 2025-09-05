using System;

class Circulo
{
    public double Raio;

    public double Area()
    {
        return Math.PI * Raio * Raio;
    }

    public double Perimetro()
    {
        return 2 * Math.PI * Raio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo c = new Circulo();
        c.Raio = 3;

        Console.WriteLine("Área: " + c.Area());
        Console.WriteLine("Perímetro: " + c.Perimetro());
    }
}
