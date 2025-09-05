using System;

class Aluno
{
    public string Nome;
    public double Nota;
}

class Program
{
    static void Main(string[] args)
    {
        Aluno a1 = new Aluno { Nome = "João", Nota = 8.5 };
        Aluno a2 = new Aluno { Nome = "Maria", Nota = 9.0 };

        if (a1.Nota > a2.Nota)
            Console.WriteLine(a1.Nome + " tem a maior nota.");
        else if (a2.Nota > a1.Nota)
            Console.WriteLine(a2.Nome + " tem a maior nota.");
        else
            Console.WriteLine("As notas são iguais.");
    }
}
