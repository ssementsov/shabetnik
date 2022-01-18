using System;

namespace T39
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\r\nВведите значение первой переменной: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r\nВведите значение второй переменной: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r\nВведите значение третьей переменной: ");
            int c = Convert.ToInt32(Console.ReadLine());
            MathOperations userNumbers1 = new MathOperations();
            userNumbers1.PrintResult(b, a, c);
            userNumbers1.PrintResult((long)a, (long)b, (long)c);
            userNumbers1.PrintResult(a, b);
            userNumbers1.PrintResult((uint)a, (uint)b, (uint)c);
            Console.ReadKey();
        }

        public class MathOperations
        {
            public int PrintResult(int b, int a, int c)
            {
                int result = b + a + c;
                Console.WriteLine($"\r\nРезультат суммы трех переменных: {result}");
                return result;
            }

            public long PrintResult(long a, long b, long c)
            {
                long result = a - b - c;
                Console.WriteLine($"\r\nРезультат разности трех переменных: {result}");
                return result;
            }

            public int PrintResult(int a, int b)
            {
                int result = (int)Math.Pow(a, b);
                Console.WriteLine($"\r\nПервое число в степени второго: {result}");
                return result;
            }

            public void PrintResult(uint a, uint b, uint c)
            {
               string result = $"\"{a}\" + \"{b}\" + \"{c}\"";
               Convert.ToString(result);
               Console.WriteLine($"\r\nСумма значений переменных представленных в строковом виде: {result}");
            }
        }
    }
}
