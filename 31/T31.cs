using System;

namespace _31
{
    class Program
    {
        static void Main(string[] args)
        {
            // запрашиваем у пользователя длину массива
            Console.WriteLine("Введите длину массива: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            // вводим массив из целочисленных значений
            int[] numbersArr = new int[userNumber];

            //присваеваем значения, введенные пользователем каждому элементу массива numbersArr
            for (int i = 0; i < numbersArr.Length; i++)
            {
                Console.WriteLine($"Введите значение {i + 1} элемента массива: ");
                numbersArr[i] = int.Parse(Console.ReadLine());
                // проверка Console.WriteLine(numbersArr[i]);

            }
            // выводим значения в неотсоритированном массиве
            Console.WriteLine("Неотсортированный массив: ");
            foreach (int value in numbersArr)
            {
                Console.Write($"{value} ");
            }
            //переменная, для хранения максимального индекса переменной
            int l; 
            for (int d = 0; d < numbersArr.Length; d++) //проходим по массиву с начала и до конца
            {
                l = numbersArr.Length-1; //считаем, что l это максимальное значение 
                for (int j = d; j < numbersArr.Length; j++) //ищем максимальный элемент в неотсортированной части
                {
                    if (numbersArr[j] > numbersArr[l])
                    {
                        l = j; //нашли в массиве число больше, чем numbersArr[l] - запоминаем его индекс в массиве
                    }
                }
                if (numbersArr[l] == numbersArr[d]) //если максимальный элемент равен текущему значению - ничего не меняем
                    continue;
                //меняем местами максимальный элемент и первый в неотсортированной части
                int temp = numbersArr[d]; //временная переменная, чтобы не потерять значение numbersArray[l]
                numbersArr[d] = numbersArr[l];
                numbersArr[l] = temp;
            }
            // выводим значения в отсоритированном массиве
             Console.WriteLine("\r\nОтсортированный массив без нового значения: ");
             foreach (int value in numbersArr)
              {
                 Console.Write($"{value} ");
               }
            
            Console.WriteLine("\r\nВведите новое значение: ");
            int newElement = Convert.ToInt32(Console.ReadLine()); // вводим новую переменную для нового элемента массива
            //добавляем новый элемент к массиву
            Array.Resize(ref numbersArr, numbersArr.Length + 1);
            numbersArr[numbersArr.Length - 1] = newElement;
            // выводим значение с новым элементом без сортировки
            Console.WriteLine("\r\nНеотсортированный массив с новым значением: ");
            foreach (int value in numbersArr)
            {
                Console.Write($"{value} ");
            }
            // повторяем сортировку для массива с новым элементом
            for (int d = 0; d < numbersArr.Length; d++) 
            {
                l = numbersArr.Length - 1; 
                for (int j = d; j < numbersArr.Length; j++) 
                {
                    if (numbersArr[j] > numbersArr[l])
                    {
                        l = j; 
                    }
                }
                if (numbersArr[l] == numbersArr[d]) 
                    continue;

                int temp = numbersArr[d];
                numbersArr[d] = numbersArr[l];
                numbersArr[l] = temp;
            }
            // выводим значения в отсоритированном массиве с новым значением
            Console.WriteLine("\r\nОтсортированный массив с новым значением: ");
            foreach (int value in numbersArr)
            {
                Console.Write($"{value} ");
            }


        }
    }
}