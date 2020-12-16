/*
ACMP

Число E

Выведите в выходной файл округленное до n знаков после десятичной точки число E. В данной задаче будем считать, что число Е в точности равно 2.7182818284590452353602875.

Входные данные
Входной файл INPUT.TXT содержит целое число n (0 ≤ n ≤ 25).

Выходные данные
В выходной файл OUTPUT.TXT выведите ответ на задачу.

Пример
№	INPUT.TXT	OUTPUT.TXT
1	0	3
2	25	2.7182818284590452353602875
3	13	2.7182818284590
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string numberE = "7182818284590452353602875";
            char temp;

            if (n == 0)
            {
                Console.WriteLine(3);
            }
            else
            {
                Console.Write("2.");
                if (n != 25)
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        Console.Write(numberE[i]);
                    }

                    if (numberE[n] > '4')
                    {
                        temp = numberE[n - 1];
                        Console.Write(Convert.ToInt32(temp) - 48 + 1);
                    }
                    else
                        Console.Write(numberE[n - 1]);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(numberE[i]);
                    }
                }
                    
            }
        }
    }
}
