using System;

class Produto
{
    public string Nome;
    public double Preco;

    public void AplicarDesconto()
    {
        Preco -= Preco * 0.10;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        p.Nome = "Notebook";
        p.Preco = 3000;

        p.AplicarDesconto();

        Console.WriteLine("Produto: " + p.Nome + ", Preço com desconto: " + p.Preco);
    }
}
