using System;
class Polindrome
{
    static void Main()
    {
        Console.WriteLine("Введите строку: ");
        string userNumber = Console.ReadLine();
        //Считаем количество символов в введенной пользователем строке
        double str = userNumber.Length;
       // Объявляем булевую переменную
        bool isPolindrome = true; 
        // Цикл проходяющий по всем элемантам строки
        for (int i = 0; i < str / 2; i++)
        {
            /*При условии, что первый символ  не равен последнему, 
            второй предпоследнему и т.д-
            это не полиндром, заканчиваем проверку, когда условие соблюдается
            */
            if (userNumber[i] != userNumber[userNumber.Length - 1 - i])
            {
                isPolindrome = false;
                break;
            }
            // если условие не выполняется продолжаем цикл, пока не будут проверяны все символы
     
            
            else  {
                continue;
            }
        }
        // Если isPolindrome - true получаем, что это полиндром, при false, что не полиндром
        Console.WriteLine(isPolindrome ? "Это полиндром" : "Это не полиндром");
        
    }
}
