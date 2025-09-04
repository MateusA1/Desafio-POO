using System;

class Quadrado
{
    public double Lado;

    public double Area()
    {
        return Lado * Lado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Quadrado q = new Quadrado();
        q.Lado = 4;

        Console.WriteLine("Área do quadrado: " + q.Area());
    }
}
