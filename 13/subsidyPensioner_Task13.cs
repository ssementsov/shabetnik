using System;

namespace Pensioner
{
    class subsidyPensioner
    {
        static void Main(string[] args)
        {
            Console.Write("Фамилия запросившего субсидию : ");
            string name = Console.ReadLine();
            
            Console.Write($"{name} является пенсионером? : ");
            bool isPensioner = Console.ReadLine().Contains("да");

            Console.Write($"{name} состоит на учёте в службе занятости? : ");
            bool isUnemployed = Console.ReadLine().Contains("да");

            Console.Write($"{name} имеет трудоустройство? : ");
            bool isEmployment = Console.ReadLine().Contains("да");

            bool subsidyAllowed = (!isEmployment && isUnemployed ^ isPensioner);
            Console.Write($"{name} имеет право на субсидию: {subsidyAllowed}");   

        }
    }
}
