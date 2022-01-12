using System;

namespace T34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrOfIntegers = { 108, 91, 122, 114, 62, 182, 110, 73, 167, 67, 24, 74, 116, 120, 42, 171, 52, 46, 23, 31, 146, 169, 161, 178, 90, 44, 142, 133, 184, 115 };

            Console.WriteLine($"\r\nНеотсортированный массив: ");
            foreach (int value in arrOfIntegers)
            {
                Console.Write($"{value} ");
            }
            // присваеваем значение первого выводимого нами элемента последнее в массиве и выводим так доходя до первого в массиве, получая перевернутый массив
            Console.WriteLine($"\r\nПеревернутый массив: ");
            for (int i = arrOfIntegers.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arrOfIntegers[i]} ");
            }
        }
    }
}
