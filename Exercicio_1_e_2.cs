using System;
using Biblioteca_Matriz;

namespace lista_Matriz
{
    internal class Exercicio_1_e_2
    {
        static int Maiorvalormat(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            int maior = mat[0, 0];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] > maior)
                    {
                        maior = mat[i, j];
                    }
                }
            }
            return maior;
        }
        static int Menorvalormat(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int colunas = mat.GetLength(1);
            int menor = mat[0, 0];

            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++)
                {
                    if (mat[i, j] < menor)
                    {
                        menor = mat[i, j];
                    }
                }
            }
            return menor;
        }

            static void Main()
        {
            Console.WriteLine("Digite quanftas linhas e colunas tera sua matriz");
            int linha = int.Parse (Console.ReadLine());
            int colunas = int.Parse(Console.ReadLine());
            int maior;
            int menor;
            
            int [,] matriz = new int [linha, colunas];
            Matriz.mostra (matriz);

            Matriz.gera(matriz);

            Console.WriteLine("Matriz gerada");

            Matriz.mostra(matriz);

           maior = Maiorvalormat(matriz);
           menor = Menorvalormat(matriz);

            Console.WriteLine("O maior é: " + maior);
            Console.WriteLine("O menor é: " + menor);


            

            Console.ReadKey();

        }
    }
}
