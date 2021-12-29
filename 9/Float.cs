using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Single i = 2.7182818284590452f;
            //используем безопасный кастинг float в double
            Double a = i;
            //используем безопасный кастинг float в decimal
            Decimal c = (Decimal)i; 
            Console.WriteLine(c);
            Console.WriteLine(a);
        }
    }
}
