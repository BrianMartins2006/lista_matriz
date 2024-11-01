using System;
using Biblioteca_Matriz;


class Exercicio_4_5
{
    static void Main()
    {
        static void diagonalPrincipal(int[,] mat)
        {
            int linhas = mat.GetLength(0);


            for (int i = 0; i < linhas; i++)
            {
                Console.Write($"|{mat[i, i]}|");
            }//fim for 

        }//fim diagonal principal

        int Coluna, Linha, resultado, resultado2;

        Console.WriteLine("Quantas linhas e quantas colunas vão ser necessárias pra sua matriz: ");

        Linha = int.Parse(Console.ReadLine());
        Coluna = int.Parse(Console.ReadLine());
        if (Linha == Coluna)
        {
            int[,] matrix = new int[Linha, Coluna];
            Matriz.gera(matrix);
            Console.WriteLine("Matriz Gerada: ");
            Matriz.mostra(matrix);
        }
        else
        {
            Console.WriteLine("Não é possivel apresentar dados pra esta dimensão!!");
        }
        Console.ReadKey();



    }//Fim main
}//fim classe