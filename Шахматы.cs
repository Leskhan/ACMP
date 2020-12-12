/*
ACMP

Шахматы

Совсем недавно Вася занялся программированием и решил реализовать собственную программу для игры в шахматы. Но у него возникла проблема определения правильности хода конем, который делает пользователь. Т.е. если пользователь вводит значение «C7-D5», то программа должна определить это как правильный ход, если же введено «E2-E4», то ход неверный. Так же нужно проверить корректность записи ввода: если например, введено «D9-N5», то программа должна определить данную запись как ошибочную. Помогите ему осуществить эту проверку!

Входные данные
В единственной строке входного файла INPUT.TXT записан текст хода (непустая строка), который указал пользователь. Пользователь не может ввести строку, длиннее 5 символов.

Выходные данные
В выходной файл OUTPUT.TXT нужно вывести «YES», если указанный ход конем верный, если же запись корректна (в смысле правильности записи координат), но ход невозможен, то нужно вывести «NO». Если же координаты не определены или заданы некорректно, то вывести сообщение «ERROR».

Примеры
№	INPUT.TXT	OUTPUT.TXT
1	C7-D5	YES
2	E2-E4	NO
3	BSN	ERROR
*/



using System;
using System.Linq;

namespace STEPIK_C_SHARP
{
    class Program
    {

        static void Main(string[] args)
        {
            string move = Console.ReadLine();

            move = move.ToUpper();            

            byte check = 0;
            if (move.Length == 5)
            {
                byte char1 = (byte)move[0];
                byte n1 = (byte)move[1];
                byte char2 = (byte)move[3];
                byte n2 = (byte)move[4];

                if (65 <= char1 && char1 <= 72)
                    check++;
                if (49 <= n1 && n1 <= 56)
                    check++;
                if (65 <= char2 && char2 <= 72)
                    check++;
                if (49 <= n2 && n2 <= 56)
                    check++;
                if (move[2] == '-')
                    check++;

                if (check == 5)
                {
                    bool checkMove = false;
                    if (char1 - 1 == char2 && n1 + 2 == n2)
                        checkMove = true;
                    else if (char1 + 1 == char2 && n1 + 2 == n2)
                        checkMove = true;
                    else if (char1 + 2 == char2 && n1 + 1 == n2)
                        checkMove = true;
                    else if (char1 + 2 == char2 && n1 - 1 == n2)
                        checkMove = true;
                    else if (char1 + 1 == char2 && n1 - 2 == n2)
                        checkMove = true;
                    else if (char1 - 1 == char2 && n1 - 2 == n2)
                        checkMove = true;
                    else if (char1 - 2 == char2 && n1 - 1 == n2)
                        checkMove = true;
                    else if (char1 - 2 == char2 && n1 + 1 == n2)
                        checkMove = true;

                    if (checkMove)
                        Console.WriteLine("YES");
                    else
                        Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
