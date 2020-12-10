/*
ACMP

Сумма

Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно.

Входные данные
В единственной строке входного файла INPUT.TXT записано единственное целое число N, не превышающее по абсолютной величине 104.

Выходные данные
В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел, расположенных между 1 и N включительно.
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static int SumNumbers(int number)
        {
            int sum = 0;

            if (number < 0)
                for (int i = number; i <= 1; i++)
                    sum += i;
            else if (number == 0)
                return 1;
            else
                for (int i = 1; i <= number; i++)
                    sum += i;

            return sum;
        }
        
		    static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SumNumbers(number));
		    }
    }
}
