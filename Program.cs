using System;

namespace STEPIK_C_SHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
                Console.WriteLine("<");
            if (a > b)
                Console.WriteLine(">");
            if (a == b)
                Console.WriteLine("");
        }
    }
}
