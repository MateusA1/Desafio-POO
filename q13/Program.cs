﻿using System;

class Data
{
    public int Dia;
    public int Mes;
    public int Ano;

    public Data(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }

    public string Formatar()
    {
        return $"{Dia:D2}/{Mes:D2}/{Ano}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Data d = new Data(4, 9, 2025);
        Console.WriteLine("Data formatada: " + d.Formatar());
    }
}
