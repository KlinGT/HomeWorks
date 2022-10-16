﻿// Домашняя работа по 2ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
    Console.WriteLine("2 - Программа, выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
    Console.WriteLine("3 - Программа, принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
    Console.WriteLine("4 - Если хотите покинуть программу.");
    system = Convert.ToInt32(Console.ReadLine());

    switch (system)
    {
        case 1:
            /*                                              ///Ветка task_1.
            Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
            и на выходе показывает вторую цифру этого числа. 
            456 -> 5
            782 -> 8
            918 -> 1
            */
            Console.Clear();

            Console.WriteLine("ПРОГРАММА 1 ЗАПУЩЕНА.");
            Console.WriteLine("Введите трёхзначное число:");
            int three = Convert.ToInt32(Console.ReadLine());

            int CutMyNum(int number)                     //метод вывода 2го знака трёхзначного числа.
            {
                string numAsString = three.ToString();
                int result = int.Parse(numAsString[1].ToString());
                return result;
            }

            int SecondNumber = CutMyNum(three);
            Console.WriteLine($"{three} -> {SecondNumber}");
            Console.WriteLine("Программа 1 завершена.");
            break;

        case 2:
            /*                                              ///Ветка task_2.
            Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
            или сообщает, что третьей цифры нет. 
            645 -> 5
            78 -> третьей цифры нет
            32679 -> 6
            */
            Console.Clear();

            Console.WriteLine("ПРОГРАММА 2 ЗАПУЩЕНА.");
            Console.WriteLine("Введите, желательно, трёхзначное число:");
            string num = Console.ReadLine();

            string CutMyNumber(string number)                     //метод вывода 3го знака трёхзначного числа
            {                                                     //или ответ об его отсутствии.
                if (num.Length > 2) 
                    Console.WriteLine($"{num} -> {num[2]}");
                else 
                    Console.WriteLine($"{num} -> третьей цифры нет");
                return num;
            }

            CutMyNumber(num);
            Console.WriteLine("Программа 2 завершена.");
            break;

        case 3:
            /*                                              ///Ветка task_3.
            Задача 15: Напишите программу, которая принимает на вход цифру, 
            обозначающую день недели, и проверяет, является ли этот день выходным. 
            6 -> да
            7 -> да
            1 -> нет
            */
            Console.Clear();

            Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА");
            Console.WriteLine("Введите день недели числом:");
            int numDay = Convert.ToInt32(Console.ReadLine());

            int Weekends (int days)                             //метод задающий диапазон дней.
            {
                if (numDay < 6 || numDay > 7)
                    Console.WriteLine($"{numDay} -> нет");
                else
                    Console.WriteLine($"{numDay} -> да");
                return numDay;
            }

            Weekends(numDay);
            Console.WriteLine("Программа завершена.");
            break;

        default:
            begin = false;
            break;
    }
}