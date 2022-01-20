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
            int l;
            // цикл с пузырьковой сортировкой  на возрастание
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
            // выводим значения в отсортированном массиве на возрастание
          
            Console.WriteLine("\r\nОтсортированный массив на возрастание: ");
            foreach (int value in arrOfIntegers)
           {
                Console.Write($"{value} ");
           }  
// тот же цикл с пузырьковой сортировкой на убывание, что получился у меня в задании 31

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
            // выводим значения в отсортированном массиве 
            Console.WriteLine("\r\nОтсортированный массив на убывание: ");
            foreach (int value in arrOfIntegers)
            {
                Console.Write($"{value} ");
            }
            // отсортированные массивы без использования свойства Length
            //возрастание
                int arrLength = 30;
            for (int d = 0; d < arrOfIntegers.Length; d++) 
            {
                l = d; 
                for (int j = d; j < arrOfIntegers.Length; j++) 
                {
                    if (arrOfIntegers[j] < arrOfIntegers[l])
                    {
                        l = j; 
                    }
                }
                if (arrOfIntegers[l] == arrOfIntegers[d]) 
                    continue;
               
                int temp = arrOfIntegers[d];
                arrOfIntegers[d] = arrOfIntegers[l];
                arrOfIntegers[l] = temp;
            }
            Console.WriteLine("\r\nОтсортированный массив на возрастание без использования свойства .Length: ");
            foreach (int value in arrOfIntegers)
            {
                Console.Write($"{value} ");
            }
            //убывание
           for (int d = 0; d < arrLength; d++) 
          {
               l = arrLength - 1;
               for (int j = d; j < arrLength; j++) 
               {
                   if (arrOfIntegers[j] > arrOfIntegers[l])
                  {
                     l = j; 
                   }
               }
              if (arrOfIntegers[l] == arrOfIntegers[d]) 
                   continue;
               
               int temp = arrOfIntegers[d];
               arrOfIntegers[d] = arrOfIntegers[l];
               arrOfIntegers[l] = temp;
            }

           Console.WriteLine("\r\nОтсортированный массив на убывание без использования свойства .Length: ");
           foreach (int value in arrOfIntegers)
           {
               Console.Write($"{value} ");
           }
        }
    }
}
