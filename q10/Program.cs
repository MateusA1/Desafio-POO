using System;

class Ponto
{
    public double X;
    public double Y;

    public double DistanciaOrigem()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ponto p = new Ponto();
        p.X = 3;
        p.Y = 4;

        Console.WriteLine("Distância até a origem: " + p.DistanciaOrigem());
    }
}
