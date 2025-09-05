using System;

class Usuario
{
    public string Nome;
    public string Email;

    public Usuario(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void AlterarEmail(string novoEmail)
    {
        Email = novoEmail;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Usuario u = new Usuario("Ana", "ana@email.com");
        u.AlterarEmail( "mateusTicx@email.com");
        Console.WriteLine("Novo email: " + u.Email);
    }
}
