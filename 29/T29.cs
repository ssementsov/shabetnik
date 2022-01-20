using System;

namespace T29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            while (firstNumber < secondNumber)
            {
                firstNumber++;
                if (firstNumber % 2 != 0) 
                { 
                Console.WriteLine(firstNumber); }
            }
            while (firstNumber > secondNumber)
            {
                secondNumber++;
                if (secondNumber % 2 != 0)
                {
                    Console.WriteLine(secondNumber);
                }
            }
        }
    }
}