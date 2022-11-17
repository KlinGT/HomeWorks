// Домашняя работа по 7ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа задаёт значение N и выводит все натуральные числа в промежутке от N до 1.");
    Console.WriteLine("2 - Программа задаёт значения M и N и находит сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("3 - Программа вычисления функции Аккермана с помощью рекурсии.");
    Console.WriteLine("4 - Если хотите покинуть программу.");
    
    system = Convert.ToInt32(Console.ReadLine());

    switch (system)
    {
        case 1:
            /*                                              ///Ветка Task_1.
            Задача 64: Задайте значение N. Напишите программу, которая выведет 
            все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
            N = 5 -> "5, 4, 3, 2, 1"
            N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
            */            
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 1 ЗАПУЩЕНА\n");

            // ввод значения N с консоли:
            int EnteringValue(string msg)
            {
                Console.Write(msg);

                bool isCorrect = false;
                int result = 0;

                while (!isCorrect)
                    if (int.TryParse(Console.ReadLine(), out result))
                        isCorrect = true;
                    else
                        Console.WriteLine("Не корректный ввод. Повторите попытку.");

                return result;
            }

            // вывод чисел от N до 1 при помощи рекурсии:
            string EnteringGapNumbers(int a, int n)
            {
                if (a <= n) return EnteringGapNumbers(a + 1, n) + $"{a}, ";
                else return String.Empty;
            }

            int n = EnteringValue("Введите значение N числом: ");
            Console.WriteLine($"N = {n} -> {EnteringGapNumbers(1, n)}");

            Console.WriteLine("\nПРОГРАММА 1 ЗАВЕРШЕНА\n");
            break;

        case 2:
            /*                                              ///Ветка Task_2.
            Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
            натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30
            */            
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 2 ЗАПУЩЕНА\n");

            // ввод значения M и N с консоли:
            int EnteringValues(string msg)
            {
                Console.Write(msg);

                bool isCorrect = false;
                int result = 0;

                while (!isCorrect)
                    if (int.TryParse(Console.ReadLine(), out result))
                        isCorrect = true;
                    else
                        Console.WriteLine("Не корректный ввод. Повторите попытку.");

                return result;
            }

            // вывод суммы чисел от М до N:
            int OutputOfTheSumOfNumbers(int m, int n)
            {
                if (m == 0) return (n * (n + 1)) / 2;            
                else if (n == 0) return (n * (m + 1)) / 2;       
                else if (m == n) return m;                       
                else if (m < n) return n + OutputOfTheSumOfNumbers(m, n - 1); 
                else return n + OutputOfTheSumOfNumbers(m, n + 1);
            }

            int numM = EnteringValues("Введите значение M: ");
            int numN = EnteringValues("Введите значение N: ");
            Console.WriteLine($"Сумма чисел промежутка = {OutputOfTheSumOfNumbers(numM, numN)}");

            Console.WriteLine("\nПРОГРАММА 2 ЗАВЕРШЕНА\n");
            break;

        case 3:
            /*                                              ///Ветка Task_3.
            Задача 68: Напишите программу вычисления функции Аккермана 
            с помощью рекурсии. Даны два неотрицательных числа m и n.
            m = 2, n = 3 -> A(m,n) = 9
            m = 3, n = 2 -> A(m,n) = 29
            */            
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА\n");

            // ввод значения M и N с консоли:
            int EnteringTwoValues(string msg)
            {
                Console.Write(msg);

                bool isCorrect = false;
                int result = 0;

                while (!isCorrect)
                    if (int.TryParse(Console.ReadLine(), out result))
                        isCorrect = true;
                    else
                        Console.WriteLine("Не корректный ввод. Повторите попытку.");

                return result;
            }

            // вывод функции Аккермана:
            int AckermanFunctions(int m, int n)
            {
                if (m == 0) return n + 1;
                else if (n == 0 && m > 0) return AckermanFunctions(m - 1, 1);
                else return (AckermanFunctions(m - 1, AckermanFunctions(m, n - 1)));
            }

            int valM = EnteringTwoValues("Введите, желательно 2 или 3: ");
            int valN = EnteringTwoValues("Введите... и ещё разок: ");
            Console.WriteLine($"A(m,n) = {AckermanFunctions(valM, valN)}");

            Console.WriteLine("\nПРОГРАММА 3 ЗАВЕРШЕНА\n");
            break;

            default:
            begin = false;
            break;
    }
}