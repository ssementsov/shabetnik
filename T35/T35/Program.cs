using System;

namespace T35
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\r\nEnter the dimension of the first matrix: ");

            // пользователь вводит в консоль сначала количество строк, потом количество столбцов
            int[,] firstMatrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

            // GetLength возвращает длину массива в измернии (0 - строки и в измерении (1) - столбцы
            for (int i = 0; i < firstMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    Console.Write("\"firstMatrix\"[{0},{1}] = ", i, j);

                    // пользователь вводит значения элементов строк и столбцов
                    firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // повторяем тоже самое для второй матрицы
            Console.WriteLine("\r\nEnter the dimension of the second matrix: ");
            int[,] secondMatrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < secondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    Console.Write("\"secondMatrix\"[{0},{1}] = ", i, j);
                    secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // выводим результат умножения двух матриц - третий двумерный массив, в случае если в методе Multiplication не появится "ERROR"
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

        // метод, реализующий умножение матриц
        // где есть 2 целочисленных параметра - перемножаемые матрицы
        public static int[,] Multiplication(int[,] a, int[,] b)
        {
            // создаем третий двумерный массив с количеством строк  a (firstMatrix.GetLength(0)) и количеством столбцов  b (secondMatrix.GetLength(1))
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                // при условии, что количество столбцов firstMatrix не равна количеству столбцов secondMatrix цикл прерывается, выводит ошибку и метод возвращает пустое значение r
                bool isMultiplicationPossible = a.GetLength(1) == b.GetLength(0);
                if (!isMultiplicationPossible)
                {
                    Console.WriteLine("ERROR");
                    break;
                }

                // если булево значение isMultiplicationPossible == true цикл продолжается
                else
                {
                    // умножаем элемент первой строки firstMatrix на элемент первого столбца secondMatrix,
                    // второй элемент первой строки на второй элементы первого столбца.
                    // Делаем то же самое с каждым элементом, пока не дойдем до конца как первой строки первой матрицы, так и первого столбца второй матрицы.
                    for (int j = 0; j < b.GetLength(1); j++)
                    {
                        for (int k = 0; k < b.GetLength(0); k++)
                        {
                            // Складываем полученные произведения
                            r[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
            }

            // возвращаем значение
            return r;
        }
    }
}
