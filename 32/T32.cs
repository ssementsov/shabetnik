using System;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\nЧисла от 0 до 100: ");
            for (int i = 0; i >= 0 & i <= 100; i++) {
                Console.Write($"{i,-5} ");
            }
            Console.WriteLine("\r\nЧисла от 1001 до 2500 с шагом 3: ");
            for (int o = 1001; o >= 1001 & o <= 2500; o += 3)
            {
                Console.Write($"{o,-5} ");
            }
            Console.WriteLine("\r\nЧисла от 100 до 0 с шагом 3: ");
            for (int p = 100; p >= 0 & p <= 100; p -= 3)
            {
                Console.Write($"{p,-5} ");
            }
            Console.WriteLine("\r\nЧисла от 1 до 5 с шагом 0.2: ");
            for (decimal a = 1.0m; a >= 1.0m & a <= 5.0m; a += 0.2m)
            {
                Console.Write($"{a,-4} ");
            }
        }
    }
}
