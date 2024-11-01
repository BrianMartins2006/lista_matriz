using System;


namespace Biblioteca_Matriz
{
    internal class Matriz
    {
        public static void leia(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int coluna = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"[{i},{j}]");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }//fim do leia

        public static void mostra(int[,] mat)
        {
            int linhas = mat.GetLength(0);
            int coluna = mat.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{mat[i, j],3} |");
                }// fim for j

                Console.WriteLine();
            }//fim for i

        }
        public static void gera(int[,] mat)
        {
            int linha = mat.GetLength(0);
            int coluna = mat.GetLength(1);

                Random random = new Random();
                for (int i = 0; i < linha; i++)
                {
                for(int j = 0;j < coluna; j++)
                {
                    mat[i, j] = random.Next(1, 100);
                }

                }

            }//fim do gera
        }
    }
