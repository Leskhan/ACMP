/*
ACMP

Следующее и предыдущее

Напишите программу, которая считывает целое число и выводит текст с упоминанием следующего и предыдущего для него чисел.

Входные данные
Входной файл INPUT.TXT содержит целое число, не превосходящее 1000 по абсолютной величине.

Выходные данные
В выходной файл OUTPUT.TXT выведите текст, аналогичный приведенному в примере. При выводе следует учесть все пробелы и знаки препинания.
*/



using System;

namespace STEPIK_C_SHARP
{   
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The next number for the number " + n + " is " + (n + 1) + ".");
            Console.WriteLine("The previous number for the number " + n + " is " + (n - 1) + ".");
        }
    }
}
