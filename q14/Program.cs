using System;

class Veiculo
{
    public string Marca;
    public string Modelo;

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Veiculo v = new Veiculo("Ford", "Fiesta");
        v.Acelerar();
    }
}
