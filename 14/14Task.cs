using System;

namespace T14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Минут за первый месяц: ");
            int firstMounth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минут за второй месяц: ");
            int secondMounth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Минут за третий месяц: ");
            int thirdMounth = Convert.ToInt32(Console.ReadLine());
            int quarter = firstMounth + secondMounth + thirdMounth;
            int costQuarter = quarter * 2;
            double taxQuarter = costQuarter * 0.2;
            Console.WriteLine($"Всего: {quarter,18}\nСтоимость всех минут: {costQuarter,4}\nЗаплатить налог: {taxQuarter,24}");
            
        }
    }
}
