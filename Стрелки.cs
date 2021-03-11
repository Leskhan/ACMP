/*
ACMP
Стрелки

Задана последовательность, состоящая только из символов ‘>’, ‘<’ и ‘-‘. Требуется найти количество стрел, которые спрятаны в этой последовательности. Стрелы – это подстроки вида ‘>>-->’ и ‘<--<<’.

Входные данные
В первой строке входного файла INPUT.TXT записана строка, состоящая из символов ‘>’, ‘<’ и ‘-‘ (без пробелов). Строка состоит не более, чем из 250 символов.

Выходные данные
В единственную строку выходного файла OUTPUT.TXT нужно вывести искомое количество стрелок.

Пример
№	INPUT.TXT	OUTPUT.TXT
1	<<<<>>--><--<<--<<>>>--><<<<<	4
*/



using System;
using System.Text;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static bool IsArrow(string str)
        {
            if (str == "<--<<" || str == ">>-->")
                return true;

            return false;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int counter = 0;

            for (int i = 0; i < str.Length - 4; i++)
            {
                string t = str.Substring(i, 5);
                if (IsArrow(t))
                    counter++;
            }

            Console.WriteLine(counter);
        }
    }
}   
