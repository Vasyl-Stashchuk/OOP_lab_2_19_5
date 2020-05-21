using System;

namespace OOP_lab_2_19_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмiри матрицi: ");

            string[] elements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[][] A = new int[int.Parse(elements[0])][];

            var random = new Random();

            for (int i = 0; i < A.Length; ++i)
            {
                A[i] = new int[int.Parse(elements[1])];

                for (int j = 0; j < A[i].Length; ++j)
                {
                    A[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    Console.Write("{0, -5}", A[i][j]);
                }

                Console.WriteLine();
            }

            Console.Write("\nНомер першого рядка: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Номер другого рядка: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < A[k].Length; ++i)
            {
                A[k][i] += A[p][i];
                A[p][i] = A[k][i] - A[p][i];
                A[k][i] = A[k][i] - A[p][i];
            }

            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A[i].Length; ++j)
                {
                    Console.Write("{0, -5}", A[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
