/*
ACMP
Сбор земляники

Маша и Миша собирали землянику. Маше удалось сорвать X ягод, а Мише – Y ягод. Поскольку ягода была очень вкусной, то ребята могли какую то часть ягод съесть. По нашим подсчетам вместе они съели Z ягод.

Требуется определить: сколько ягод ребята собрали в результате, при этом следует проверить, не ошиблись ли мы в расчетах, подсчитывая количество съеденных ягод (их не должно было получиться больше, чем сорванных ягод).

Входные данные
Входной файл INPUT.TXT содержит три натуральных числа X, Y и Z, не превышающих 1000. Все числа расположены в первой строке файла и разделены пробелом.

Выходные данные
В выходной файл OUTPUT.TXT выведите количество собранных ягод, если наши подсчеты оказались правдоподобными, либо слово «Impossible» в противном случае.

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	3 2 1	4
2	12 13 5	20
3	2 5 9	Impossible
*/



using System;
using System.Collections.Generic;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Fruit
    {
        public Fruit(int Masha, int Misha)
        {
            _collected = Masha + Misha;
        }

        private int _collected;
        
        public string GetResult(int ate)
        {
            if (_collected >= ate)
                return (_collected - ate).ToString();
            else
                return "Impossible";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = Console.ReadLine().Split().Select(e => int.Parse(e)).ToArray();
            Fruit fruit = new Fruit(vs[0], vs[1]);
            Console.WriteLine(fruit.GetResult(vs[2]));
        }
    }
}
