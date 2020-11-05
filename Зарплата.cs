/*
    ACMP

    ЗАДАЧА №21
    Зарплата

В отделе работают 3 сотрудника, которые получают заработную плату в рублях. Требуется определить: на сколько зарплата самого высокооплачиваемого из них отличается от самого низкооплачиваемого.

Входные данные
В единственной строке входного файла INPUT.TXT записаны размеры зарплат всех сотрудников через пробел. Каждая заработная плата – это натуральное число, не превышающее 105.

Выходные данные
В выходной файл OUTPUT.TXT необходимо вывести одно целое число — разницу между максимальной и минимальной зарплатой.
*/

using System;

namespace STEPIK_C_SHARP
{
    class Зарплата
    {
        static void Main(string[] args)
        {
            string[] vs = Console.ReadLine().Split(' ');
            int a = int.Parse(vs[0]);
            int b = int.Parse(vs[1]);
            int c = int.Parse(vs[2]);

            int maxV = Math.Max(Math.Max(a, b), Math.Max(b, c));
            int minV = Math.Min(Math.Min(a, b), Math.Min(b, c));

            Console.WriteLine(maxV - minV);
        }
    }
}
