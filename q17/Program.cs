using System;
using System.Collections.Generic;

class Biblioteca
{
    private List<string> livros = new List<string>();

    public void AdicionarLivro(string titulo)
    {
        livros.Add(titulo);
    }

    public void ExibirLivros()
    {
        Console.WriteLine("Livros na biblioteca:");
        foreach (string livro in livros)
        {
            Console.WriteLine("- " + livro);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Biblioteca b = new Biblioteca();
        b.AdicionarLivro("Dom Casmurro");
        b.AdicionarLivro("Memórias Póstumas");
        b.ExibirLivros();
    }
}
