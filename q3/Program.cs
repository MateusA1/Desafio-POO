using System;

class Animal
{
    public string Nome;
    public int Idade;
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Animal();
        animal1.Nome = "Leão";
        animal1.Idade = 5;

        Console.WriteLine("Animal: " + animal1.Nome + ", Idade: " + animal1.Idade);
    }
}
