using System;

namespace ConsoleApp11
{
    class Nannn
    {
        static void Main(string[] args)
        {

            double a = 0D;
            Console.WriteLine($"деление ноля на ноль = {a / a}\n");

            Console.WriteLine($"деление бесконечности на бесконечность = {double.PositiveInfinity / double.PositiveInfinity}\n");

            Console.WriteLine($"умножение 0 на бесконечность = {0 * double.PositiveInfinity}\n");

            Console.WriteLine($"сложение бесконечностей противоположных знаков = {double.PositiveInfinity + double.NegativeInfinity}\n");

            Console.WriteLine($"квадратный корень из отрицательного числа = {Math.Sqrt(-23)}\n");

            Console.WriteLine($"логарифм из отрицательного числа = {Math.Log(-23)}\n");
        }
    }
}
