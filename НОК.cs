/*
ACMP

НОК

Требуется написать программу, определяющую наименьшее общее кратное (НОК) чисел a и b.

Входные данные
В единственной строке входного файла INPUT.TXT записаны два натуральных числа А и В через пробел, не превышающих 46340.

Выходные данные
В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — НОК чисел А и В.

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	36 27	108
2	39 65	195
*/



using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int m = int.Parse(numbers[0]);
            int n = int.Parse(numbers[1]);

            int x = m;
            int y = n;

            while (x != y)
            {
                if (x > y)
                    y += n;
                else
                    x += m;
            }

            Console.WriteLine(x);
        }
    }
}
