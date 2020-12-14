/*
ACMP

Единицы

На уроках информатики вас, наверное, учили переводить числа из одних систем счисления в другие и выполнять другие подобные операции. Пришло время продемонстрировать эти знания. Найдите количество единиц в двоичной записи заданного числа.

Входные данные
Во входном файле INPUT.TXT записано целое число n (0 ≤ n ≤ 2×109).

Выходные данные
В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — количество двоичных единиц в записи числа n.

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	5	2
2	7	3
*/



using System;

namespace STEPIK_C_SHARP
{   
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (number >= 1)
            {
                if (number % 2 == 1)
                    count++;
                number /= 2;
            }

            Console.WriteLine(count);
        }
    }
}
