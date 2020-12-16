/*
ACMP

Нули

Требуется найти самую длинную непрерывную цепочку нулей в последовательности нулей и единиц.

Входные данные
В единственной строке входного файла INPUT.TXT записана последовательность нулей и единиц (без пробелов). Суммарное количество цифр от 1 до 100.

Выходные данные
В единственную строку выходного файла OUTPUT.TXT нужно вывести искомую длину цепочки нулей.

Пример
№	INPUT.TXT	OUTPUT.TXT
1	00101110000110	4
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            string vs = Console.ReadLine();
            int count = 1;
            int max = 0;
            bool isHaveZero = false;

            for (int i = 0; i < vs.Length - 1; i++)
            {
                if (vs[i] == '0' && vs[i + 1] == '0')
                {
                    count++;
                    isHaveZero = true;
                    if (count > max)
                        max = count;
                }
                else
                {
                    count = 1;
                }
            }

            if (isHaveZero)
                Console.WriteLine(max);
            else if (!isHaveZero && ((vs[0] == '1' && vs[1] == '0') || (vs[0] == '0' && vs[1] == '1')))
                Console.WriteLine(1);
            else
                Console.WriteLine(max);
           
        }
    }
}
