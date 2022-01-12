using System;

namespace T33
{
    class T33
    {
        static void Main(string[] args)
        {
            int[] arrOfIntegers = { 146, 110, 66, 139, 7, 86, 71, 97, 96, 160, 138, 67, 145, 133, 183, 185, 23, 124, 177, 150, 104, 48, 77, 147, 63, 113, 132, 100, 107, 106 };
            Console.WriteLine($"\r\nНеотсортированный массив: ");
            foreach (int value in arrOfIntegers)
            {
                Console.Write($"{value} ");
            }
            // тот же цикл с пузырьковой сортировкой на возрастание, что получился у меня в задании 31
            int l;
            for (int d = 0; d < arrOfIntegers.Length; d++) //проходим по массиву с начала и до конца
            {
                l = arrOfIntegers.Length - 1; //считаем, что l это максимальное значение 
                for (int j = d; j < arrOfIntegers.Length; j++) //ищем максимальный элемент в неотсортированной части
                {
                    if (arrOfIntegers[j] > arrOfIntegers[l])
                    {
                        l = j; //нашли в массиве число больше, чем arrOfIntegers[l] - запоминаем его индекс в массиве
                    }
                }
                if (arrOfIntegers[l] == arrOfIntegers[d]) //если максимальный элемент равен текущему значению - ничего не меняем
                    continue;
                //меняем местами максимальный элемент и первый в неотсортированной части
                int temp = arrOfIntegers[d]; //временная переменная, чтобы не потерять значение arrOfIntegers[l]
                arrOfIntegers[d] = arrOfIntegers[l];
                arrOfIntegers[l] = temp;
            }
            // выводим значения в отсортированном массиве по возрастанию
            Console.WriteLine("\r\nОтсортированный массив по возрастанию: ");
            foreach (int value in arrOfIntegers)
            {
                Console.Write($"{value} ");
            }
            // цикл с пузырьковой сортировкой  на убывание
            for (int d = 0; d < arrOfIntegers.Length; d++) //проходим по массиву с начала и до конца
            {
                l = d; //считаем, что l это минимальное значение 
                for (int j = d; j < arrOfIntegers.Length; j++) //ищем минимальный элемент в неотсортированной части
                {
                    if (arrOfIntegers[j] < arrOfIntegers[l])
                    {
                        l = j; //нашли в массиве число меньше, чем arrOfIntegers[l] - запоминаем его индекс в массиве
                    }
                }
                if (arrOfIntegers[l] == arrOfIntegers[d]) //если минимальный элемент равен текущему значению - ничего не меняем
                    continue;
                //меняем местами минимвальный элемент и первый в неотсортированной части
                int temp = arrOfIntegers[d]; //временная переменная, чтобы не потерять значение arrOfIntegers[l]
                arrOfIntegers[d] = arrOfIntegers[l];
                arrOfIntegers[l] = temp;
            }
            // выводим значения в отсортированном массиве по убыванию
            Console.WriteLine("\r\nОтсортированный массив по убыванию: ");
            foreach (int value in arrOfIntegers)
            {
                Console.Write($"{value} ");
            }
        }
    }
}
