using System;
using Biblioteca_Matriz;
using System.IO;


class Program
{
    static void Main()
    {
        int linhas, colunas;
        Console.WriteLine("**** Matrizes ****");
        Console.WriteLine("Quantas linhas e colunas: ");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] mat = new int[linhas, colunas];

       // Console.WriteLine("Eentre com dados para a Matriz: ");
        //Matriz.leia(mat);
        Console.WriteLine("Dados da sua matriz: ");
       // Matriz.mostra(mat);
        Matriz.gera(mat);
        Matriz.mostra(mat);
        Console.ReadKey();
    } 
}
