/*
ACMP

Дороги

В галактике «Milky Way» на планете «Snowflake» есть N городов, некоторые из которых соединены дорогами. Император галактики «Milky Way» решил провести инвентаризацию дорог на планете «Snowflake». Но, как оказалось, он не силен в математике, поэтому он просит вас сосчитать количество дорог. Требуется написать программу, помогающую императору сосчитать количество дорог на планете «Snowflake».

Входные данные
В первой строке входного файла INPUT.TXT записано число N (0 ≤ N ≤ 100). В следующих N строках записано по N чисел, каждое из которых является единичкой или ноликом. Причем, если в позиции (i, j) квадратной матрицы стоит единичка, то i-ый и j-ый города соединены дорогами, а если нолик, то не соединены.

Выходные данные
В выходной файл OUTPUT.TXT необходимо вывести число, определяющее количество дорог на планете «Snowflake».

Пример
№	INPUT.TXT	OUTPUT.TXT
1	5
0 1 0 0 0
1 0 1 1 0
0 1 0 0 0
0 1 0 0 0
0 0 0 0 0
3
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            int countCities = 0;

            for (int i = 0; i < k; i++)
            {
                string[] numbers = Console.ReadLine().Split();
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == "1")
                        countCities++;
                }
            }

            Console.WriteLine(countCities / 2);
        }
    }
}
