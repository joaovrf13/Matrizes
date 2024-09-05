using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o numero de linhas");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de colunas");
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite um número para mostrar sua posição:  ");
            int X = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++) {

                for (int j = 0; j < N; j++) {

                    if (mat[i, j] == X) {

                        Console.WriteLine($"Position ({i},{j})");
                        if (i > 0) {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }

                        if (j > 0) {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");

                        }
                        if (j < N - 1) {
                            Console.WriteLine($"Rigth: {mat[i, j + 1]}");
                        }
                        if (i < M - 1) {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }

        }
    }
}
