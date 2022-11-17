// Домашняя работа по 7ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа задаёт значение N и выводит все натуральные числа в промежутке от N до 1.");
    Console.WriteLine("2 - Программа задаёт значения M и N и находит сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("3 - Программа задаёт две матрицы и находит произведение двух матриц.");
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

            int m = EnteringValues("Введите значение M: ");
            int n = EnteringValues("Введите значение N: ");
            Console.WriteLine($"Сумма чисел промежутка = {OutputOfTheSumOfNumbers(m, n)}");

            Console.WriteLine("\nПРОГРАММА 2 ЗАВЕРШЕНА\n");
            break;

        case 3:
            /*                                              ///Ветка Task_3.
            Задача 58: Задайте две матрицы. Напишите программу, 
            которая будет находить произведение двух матриц.
            Например, даны 2 матрицы:
            2 4 | 3 4
            3 2 | 3 3
            Результирующая матрица будет:
            18 20
            15 18
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА\n");

            // запрашиваем размерность матриц:
            int RequestingDimensionOfMatrices(string msg)
            {
                Console.Write(msg);
                int result = Convert.ToInt32(Console.ReadLine());
                return result;
            }

            // наполнение матрицы рандомными значениями:
            int[,] FillArrayRandomNumbers(int[,] matrix)
            {
                Random rnd = new Random();

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rnd.Next(1, 10);
                    }
                }
                return matrix;
            }

            // вывод матрицы в консоль:
            void PrintMatrixInToConsole(int[,] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write("{0, 4}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            // находим произведение двух матриц:
            int[,] ProductOfTwoMatrices(int size, int[,] matrixA, int[,] matrixB, int[,] matrixC)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                        {
                            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
                        }
                    }
                }
                return matrixC;
            }

            int size = RequestingDimensionOfMatrices("Введите размерность матриц: ");
            int[,] matrixA = new int[size, size];
            int[,] matrixB = new int[size, size];
            int[,] matrixC = new int[size, size];

            FillArrayRandomNumbers(matrixA);
            FillArrayRandomNumbers(matrixB);

            Console.WriteLine("Первая матрица:");
            PrintMatrixInToConsole(matrixA);
            Console.WriteLine();
            Console.WriteLine("Вторая матрица:");
            PrintMatrixInToConsole(matrixB);
            Console.WriteLine();

            int[,] result = ProductOfTwoMatrices(size, matrixA, matrixB, matrixC);
            Console.WriteLine("Результат произведения двух матриц:");
            PrintMatrixInToConsole(result);

            Console.WriteLine("\nПРОГРАММА 3 ЗАВЕРШЕНА\n");
            break;

        case 4:
            /*                                              ///Ветка Task_4.
            Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
            Напишите программу, которая будет построчно выводить массив, 
            добавляя индексы каждого элемента.
            Массив размером 2 x 2 x 2
            66(0,0,0) 25(0,1,0)
            34(1,0,0) 41(1,1,0)
            27(0,0,1) 90(0,1,1)
            26(1,0,1) 55(1,1,1)
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 4 ЗАПУЩЕНА\n");

            // запрашиваем размерность массива:
            int EnterArraySize(string msg)
            {
                Console.Write(msg);
                int result = int.Parse(Console.ReadLine() ?? "");
                return result;
            }

            // заполняем массив рандомными числами:
            void Fill3DArray(int[,,] array)
            {
                int minNum = 10;
                int maxNum = 99;
                Random rnd = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            while (array[i, j, k] == 0)
                            {
                                int number = rnd.Next(minNum, maxNum + 1);

                                if (IsNumberInArray(array, number) == false)
                                {
                                    array[i, j, k] = number;
                                }
                            }
                        }
                    }
                }
            }

            // проверка на повторяемость:
            bool IsNumberInArray(int[,,] array, int number)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            if (array[i, j, k] == number) return true;
                        }
                    }
                }
                return false;
            }

            // вывод массива в консоль:
            void Print3DArray(int[,,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            Console.Write(array[i, j, k]);
                            Console.Write("({0},{1},{2})\t", i, j, k);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"Введите размер массива A x B x C: ");
            int sizeA = EnterArraySize("Введите размерность A: ");
            int sizeB = EnterArraySize("Введите размерность B: ");
            int sizeC = EnterArraySize("Введите размерность C: ");
            Console.WriteLine("");

            int[,,] array = new int[sizeA, sizeB, sizeC];
            Fill3DArray(array);
            Print3DArray(array);

            Console.WriteLine("\nПРОГРАММА 4 ЗАВЕРШЕНА\n");
            break;

        case 5:
            /*                                              ///Ветка Task_5.
            Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
            Например, на выходе получается вот такой массив:
            01 02 03 04
            12 13 14 05
            11 16 15 06
            10 09 08 07
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 5 ЗАПУЩЕНА\n");

            // запрашиваем размерность массива:
            int GetArraySize(string msg)
            {
                Console.Write(msg);
                int size = Convert.ToInt32(Console.ReadLine());
                return size;
            }

            // создаём спиральный массив:
            int[,] CreatingSpiralArray(int size)
            {
                int[,] array = new int[size, size];

                int num = 1;
                int i = 0;
                int j = 0;

                while (num <= size * size)
                {
                    array[i, j] = num;
                    if (i <= j + 1 && i + j < size - 1)
                        ++j;
                    else if (i < j && i + j >= size - 1)
                        ++i;
                    else if (i >= j && i + j > size - 1)
                        --j;
                    else
                        --i;
                    ++num;
                }
                return array;
            }

            void PrintSpiralArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write("{0, 4}", array[i, j]);
                    }
                    Console.WriteLine("");
                }
            }

            int sizeX = GetArraySize("Введите размерность массива: ");
            Console.WriteLine("");

            int[,] arr = CreatingSpiralArray(sizeX);
            PrintSpiralArray(arr);

            Console.WriteLine("\nПРОГРАММА 5 ЗАВЕРШЕНА\n");
            break;

        default:
            begin = false;
            break;
    }
}