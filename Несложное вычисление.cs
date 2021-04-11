/*
ACMP
Несложное вычисление

Задано натуральное число n. Необходимо перевести его в k-ичную систему счисления и найти разность между произведением и суммой его цифр в этой системе счисления.

Например, пусть n = 239, k = 8. Тогда представление числа n в восьмеричной системе счисления — 357, а ответ на задачу равен 3 × 5 × 7 − (3 + 5 + 7) = 90.

Входные данные
Входной файл INPUT.TXT содержит два натуральных числа: n и k (1 ≤ n ≤ 109, 2 ≤ k ≤ 10). Оба этих числа заданы в десятичной системе счисления.

Выходные данные
В выходной файл OUTPUT.TXT выведите ответ на задачу (в десятичной системе счисления).
*/



using System;
using System.Text;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static string GetNumberFromSystemEnc(int number, int k)
        {
            StringBuilder stringBuilder = new StringBuilder();

            while (number > 0)
            {
                stringBuilder.Insert(0, number % k);
                number /= k;
            }

            return stringBuilder.ToString();
        }

        static int GetResults(string n)
        {
            int mul = 1, sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                mul *= Convert.ToInt32(n[i].ToString());
                sum += Convert.ToInt32(n[i].ToString());
            }

            return mul - sum;
        }

        static void Main(string[] args)
        {
            int[] vs = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            var n = GetNumberFromSystemEnc(vs[0], vs[1]);
            Console.WriteLine(GetResults(n));
        }
    }
}
