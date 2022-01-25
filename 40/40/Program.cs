using System;

namespace T40
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\r\nEnter text: ");
            string userString = Console.ReadLine();
            Console.WriteLine(ToLowerCase(userString));
        }

        public static string ToLowerCase(string lowerText)
        {
            char[] arrayToChar = lowerText.ToCharArray();

            for (int i = 0; i < arrayToChar.Length; i++)
            {
                if (arrayToChar[i] >= 65 & arrayToChar[i] <= 90 || arrayToChar[i] >= 1040 & arrayToChar[i] <= 1071)
                {
                    arrayToChar[i] += (char)32;
                    lowerText = new string(arrayToChar);
                }
            }

            return lowerText;
        }
    }
}
