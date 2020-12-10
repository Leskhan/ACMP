/*
ACMP

Золото племени АББА

Главный вождь племени Абба не умеет считать. В обмен на одну из его земель вождь другого племени предложил ему выбрать одну из трех куч с золотыми монетами. Но вождю племени Абба хочется получить наибольшее количество золотых монет. Помогите вождю сделать правильный выбор!

Входные данные
В первой строке входного файла INPUT.TXT записаны три натуральных числа через пробел. Каждое из чисел не превышает 10100. Числа записаны без ведущих нулей.

Выходные данные
В выходной файл OUTPUT.TXT нужно вывести одно целое число — максимальное количество монет, которые может взять вождь.

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	5 7 3	  7
2	987531 234 86364	987531
3	189285 283 4958439238923098349024	  4958439238923098349024
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static string max(string a, string b)
        {
            if (a.Length > b.Length)
                return a;
            if (a.Length < b.Length)
                return b;

            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > b[i])
                        return a;
                    if (a[i] < b[i])
                        return b;
                }
            }

            return a;
        }
        static void Main(string[] args)
        {
            string[] money = Console.ReadLine().Split();
            Console.WriteLine(max(max(money[0], money[1]), money[2]));
        }
    }
}
