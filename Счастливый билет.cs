using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int first = number / 1000;
            int second = number % 1000;

            int a1 = first / 100;
            int b1 = first / 10 % 10;
            int c1 = first % 10;

            int a2 = second / 100;
            int b2 = second / 10 % 10;
            int c2 = second % 10;

            Console.WriteLine(a1 + b1 + c1 == a2 + b2 + c2 ? "YES":"NO");
        }
    }
}
