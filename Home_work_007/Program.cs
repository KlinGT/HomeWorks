// Домашняя работа по 5ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, создаёт двумерный массив размером m х n, заполненный случайными вещественными числами.");
    Console.WriteLine("2 - Программа, принимает индекс элемента в двумерном массиве, и возвращает значение этого элемента или же сообщит, что такого элемента нет.");
    Console.WriteLine("3 - Программа, задаёт двумерный массив из целых чисел и находит среднее арифметическое элементов в каждом столбце.");
    Console.WriteLine("4 - Если хотите покинуть программу.");
    system = Convert.ToInt32(Console.ReadLine());

    switch (system)
    {
        case 1:
            /*                                              ///Ветка task_1.
            Задача 47. Задайте двумерный массив размером m×n, 
            заполненный случайными вещественными числами.
            m = 3, n = 4.
            0,5 7 -2 -0,2
            1 -3,3 8 -9,9
            8 7,8 -7,1 9
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 1 ЗАПУЩЕНА\n");

            // запрос размерности массива:
            int EnterDimensionOfArray(string message)
            {
                Console.Write(message);
                int result = int.Parse(Console.ReadLine() ?? "");
                return result;
            }

            // создаём двумерный массив с случайными значениями вечественных чисел:
            double[,] TwoDimensionalArrayWithRandomValues(int m, int n)
            {
                double[,] array = new double[m, n];
                Random rnd = new Random();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = rnd.NextDouble() * 10;
                    }
                }
                return array;
            }

            // вывод значений массива в консоль:
            void OutputArrayValuesToConsole(double[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0,6:F1}", array[i, j]);
                    }
                    Console.WriteLine(" ");
                }
            }

            int m = EnterDimensionOfArray("Введите значение m: ");
            int n = EnterDimensionOfArray("Введите значение n: ");
            Console.WriteLine(" ");
            double[,] array = TwoDimensionalArrayWithRandomValues(m, n);

            OutputArrayValuesToConsole(array);
            Console.WriteLine(" ");
            Console.WriteLine("ПРОГРАММА 1 ЗАВЕРШЕНА\n");
            break;

        case 2:
            /*                                              ///Ветка task_02.
            Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
            и возвращает значение этого элемента или же указание, что такого элемента нет.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            17 -> такого числа в массиве нет
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 2 ЗАПУЩЕНА\n");

            // создаём двумерный массив с фиксированным кол-во эл-ов:
            int[,] CreatingTwoDimensionalArrayWithFixedNumberOfElements()
            {
                int[,] array = new int[5, 5];
                Random rnd = new Random();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array[i, j] = rnd.Next(1, 20);
                    }
                }
                return array;
            }

            // вывод массива в консоль:
            void OutputArrayInToConsole(int [,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0,5}", array[i, j]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }

            // принимаем индексы x и y позиции искомого эл-та массива:
            int EnterTheIndexesOfTheElement(string msg)
            {
                Console.Write(msg);
                int index = int.Parse(Console.ReadLine() ?? "");
                return index;
            }

            // поиск значения по введённому индексу:
            void SearchForValueByEnteredIndex(int[,] arr, int x, int y)
            {
                if (x < 0 | x >= arr.GetLength(0) | y < 0 | y >= arr.GetLength(1))
                    Console.WriteLine($"Элемент с индексом [{x},{y}] НЕ найден!");
                else
                    Console.WriteLine($"Элемент с индексом [{x}, {y}] найден и равен: {arr[x, y]}");

                Console.WriteLine();
            }

            int[,] arr = CreatingTwoDimensionalArrayWithFixedNumberOfElements();
            OutputArrayInToConsole(arr);

            int x = EnterTheIndexesOfTheElement("Введите первый индекс х: ");
            int y = EnterTheIndexesOfTheElement("Введите второй индекс y: ");

            SearchForValueByEnteredIndex(arr, x, y);

            Console.WriteLine("ПРОГРАММА 2 ЗАВЕРШЕНА\n");
            break;

        case 3:
            /*                                              ///Ветка task_3.
            Задача 52. Задайте двумерный массив из целых чисел. 
            Найдите среднее арифметическое элементов в каждом столбце.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА\n");

            // запрашиваем у пользователя размерность массива:
            int AskUserForDimensionOfArray(string msg)
            {
                Console.Write(msg);
                int result = Convert.ToInt32(Console.ReadLine());
                return result;
            }

            // создаём двумерный массив рандомных значений:
            int[,] CreatingTwoDimensionalArrayOfRandomValues(int rows, int columns)
            {
                int[,] array = new int[rows, columns];
                Random rnd = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(1, 10);
                    }
                }
                return array;
            }

            // вывод рандомного массива в терминал:
            void OutputOfRandomArrayToTerminal(int[,] array)
            {
                Console.WriteLine(" ");
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0,4}", array[i, j]);
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine(" ");
            }

            // среднее арифметическое элементов по столбцам:
            void ArithmeticMeanOfElementsByColumns(int[,] arr)
            {
                Console.WriteLine("Среднее арифметическое \nкаждого столбца:\n");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    double summ = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        summ += arr[i, j];
                    }
                    Console.Write($" {summ / arr.GetLength(0)} ");
                }
                Console.WriteLine("\n");
            }

            int rows = AskUserForDimensionOfArray("Введите кол-во строк: ");
            int columns = AskUserForDimensionOfArray("Введите кол-во столбцов: ");

            int[,] arr2 = CreatingTwoDimensionalArrayOfRandomValues(rows, columns);
            OutputOfRandomArrayToTerminal(arr2);
            ArithmeticMeanOfElementsByColumns(arr2);

            Console.WriteLine("ПРОГРАММА 3 ЗАВЕРШЕНА\n");
            break;

        default:
            begin = false;
            break;
    }
}