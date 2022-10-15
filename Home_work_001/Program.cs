// Домашняя работа по 1ой лекции; Расторгуева ВТ; группа 3235;

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
    Console.WriteLine("2 - Программа, принимает на вход три числа и выдаёт максимальное из этих чисел.");
    Console.WriteLine("3 - Программа, на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
    Console.WriteLine("4 - Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
    Console.WriteLine("5 - Если хотите покинуть программу.");
    system = Convert.ToInt32(Console.ReadLine());

    switch (system)
    {
        case 1:
            /*
            Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
            какое число большее, а какое меньшее.
            a = 5; b = 7 -> max = 7
            a = 2 b = 10 -> max = 10
            a = -9 b = -3 -> max = -3
            */
            Console.Clear();

            Console.WriteLine("Программа 1 запущена.");
            Console.WriteLine("Введите первое число:");
            int num_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine($"a = {num_A}; b = {num_B} -> max = {num_A}");
            }
            else
            {
                Console.WriteLine($"a = {num_A}; b = {num_B} -> max = {num_B}");
            }
            break;

        case 2:
            /*
            Задача 4: Напишите программу, которая принимает на вход три числа 
            и выдаёт максимальное из этих чисел.
            2, 3, 7 -> 7
            44 5 78 -> 78
            22 3 9 -> 22
            */

            Console.Clear();

            Console.WriteLine("Программа 2 запущена.");
            Console.WriteLine("Введите первое число:");
            int num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if(num_1 > max) max = num_1;
            if(num_2 > max) max = num_2;
            if(num_3 > max) max = num_3;

            Console.Write($"{num_1}, {num_2}, {num_3}, max -> ");
            Console.WriteLine(max);
            break;

        case 3:
            /*
            Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
            является ли число чётным (делится ли оно на два без остатка).
            4 -> да
            -3 -> нет
            7 -> нет
            */
            Console.Clear();
            
            Console.WriteLine("Программа 3 запущена.");
            Console.WriteLine("Введите число:");
            int Num = Convert.ToInt32(Console.ReadLine());

            if(Num % 2 == 0)
            {
                Console.WriteLine($"{Num} -> да");
            }
            else
            {
                Console.WriteLine($"{Num} -> нет");
            }
            break;

        case 4:
            /*
            Задача 8: Напишите программу, которая на вход принимает число (N), 
            а на выходе показывает все чётные числа от 1 до N.
            5 -> 2, 4
            8 -> 2, 4, 6, 8
            */
            Console.Clear();

            Console.WriteLine("Программа 4 запущена.");
            Console.WriteLine("Введите число:");
            int num_N = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{num_N} -> ");

            for (int i = 2; i <= num_N; i = i + 2)
            {
                Console.Write($" {i}, ");
            }
            break;

        default:
            begin = false;
            break;
    }
}