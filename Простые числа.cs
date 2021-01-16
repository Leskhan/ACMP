/*
ACMP
Простые числа

Необходимо вывести все простые числа от M до N включительно.

Входные данные
Входной файл INPUT.TXT содержит два натуральных числа M и N, разделенных пробелом (2 ≤ M ≤ N ≤ 300 000)

Выходные данные
В выходной файл OUTPUT.TXT выведите все простые числа от M до N в порядке возрастания, по одному в строке. Если таковых чисел нет, то следует вывести «Absent».

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	2 5	2
3
5
2	4 4	Absent

*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split();
            int a = int.Parse(vs[0]);
            int b = int.Parse(vs[1]);
            bool ch = false;

            for (int i = a; i <= b; i++)
            {
                if (isPrime(i))
                {
                    ch = true;
                    Console.WriteLine(i);
                }                    
            }

            if (!ch)
                Console.WriteLine("Absent");
        }
    }
}
