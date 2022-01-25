using System;

namespace T36
{
     public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\r\nEnter the dimension of the first matrix: ");
            int[,] firstMatrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            Random rand = new Random();
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    Console.Write("\"firstMatrix\"[{0},{1}] = ", i, j);
                    firstMatrix[i, j] = rand.Next();
                    Console.Write("{0} ", firstMatrix[i, j], -5);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\r\nEnter the dimension of the second matrix: ");
            int[,] secondMatrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < secondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    Console.Write("\"secondMatrix\"[{0},{1}] = ", i, j);
                    secondMatrix[i, j] = rand.Next();
                    Console.Write("{0} ", secondMatrix[i, j], -5);
                }

                Console.WriteLine();
            }

            Console.WriteLine("\r\n\"matrixAfterMultiplication\"  = \"firstMatrix\" * \"secondMatrix\":");
            int[,] matrixAfterMultiplication = Multiplication(firstMatrix, secondMatrix);
            for (int i = 0; i < matrixAfterMultiplication.GetLength(0); i++)
            {
                for (int j = 0; j < matrixAfterMultiplication.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrixAfterMultiplication[i, j], -5);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

        public static int[,] Multiplication(int[,] a, int[,] b)
        {
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                bool isMultiplicationPossible = a.GetLength(1) == b.GetLength(0);
                if (!isMultiplicationPossible)
                {
                    Console.WriteLine("ERROR");
                    break;
                }
                else
                {
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.GetLength(0); k++)
                        {
                            r[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
            }

            return r;
        }
    }
}
