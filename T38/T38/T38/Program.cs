using System;

namespace T38
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int firstNum = 1;
            int secondNum = 2;
            int thirdNum = 3;
           // Sum(firstNum, secondNum, thirdNum);
           // IncrementAndSum(ref firstNum, ref secondNum, ref thirdNum);
            bool isTrueOrFalse = false;
            CallingMethods(firstNum, secondNum, thirdNum, isTrueOrFalse);
        }

        public static int Sum(int fNum, int sNum, int tNum)
        {
            int summ = fNum + sNum + tNum;

            // проверка
            Console.WriteLine(summ);
            return summ;
        }

        public static int IncrementAndSum(ref int parametrF, ref int parametrS, ref int parametrT)
        {
            parametrF++;
            parametrS++;
            parametrT++;
            int sumPar = parametrF + parametrS + parametrT;

            // проверка
            Console.WriteLine(sumPar);
            return sumPar;
        }

        public static int CallingMethods(int paramF, int paramSec, int paramTh, bool isTrOrF)
        {
            if (isTrOrF == true)
            {
             return Sum(paramF, paramSec, paramTh);
            }
          else
          {
             return IncrementAndSum(ref paramF, ref paramSec, ref paramTh);
          }
        }
    }
}
