using System;

class Livro
{
    public string Titulo;
    public string Autor;

    public void ExibirInfo()
    {
        Console.WriteLine("Título: " + Titulo + ", Autor: " + Autor);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Livro livro1 = new Livro();
        livro1.Titulo = "Dom Casmurro";
        livro1.Autor = "Machado de Assis";

        livro1.ExibirInfo();
    }
}
