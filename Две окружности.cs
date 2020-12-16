/*
ACMP

Две окружности

На плоскости даны две окружности. Требуется проверить, имеют ли они хотя бы одну общую точку.

Входные данные
Входной файл INPUT.TXT состоит из двух строк. На каждой строке записана информация об одной окружности – координаты ее центра x и y (целые числа, по модулю не превосходящие 5000) и радиус (целое число 1 ≤ r ≤ 1000).

Выходные данные
В выходной файл OUTPUT.TXT выведите «YES», если окружности имеют хотя бы одну общую точку, и «NO» в противном случае.

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	0 0 2
0 3 2	YES
2	1 1 1
4 4 1	NO
*/



using System;

namespace STEPIK_C_SHARP
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            string[] firstTriangle = Console.ReadLine().Split();
            string[] secondTriangle = Console.ReadLine().Split();

            double x1 = Convert.ToDouble(firstTriangle[0]);
            double y1 = Convert.ToDouble(firstTriangle[1]);
            double r1 = Convert.ToDouble(firstTriangle[2]);

            double x2 = Convert.ToDouble(secondTriangle[0]);
            double y2 = Convert.ToDouble(secondTriangle[1]);
            double r2 = Convert.ToDouble(secondTriangle[2]);

            double r = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            if (r1 + r2 >= r && r + r2 >= r1 && r + r1 >= r2)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
