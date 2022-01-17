using System;

namespace T28
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberUser = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(numberUser);
            while (numberUser < 0)
            {
                numberUser++;
                Console.WriteLine(numberUser);
            }
            while (numberUser > 0)
            {
                numberUser--;
                Console.WriteLine(numberUser);
            }
        }
    }
}