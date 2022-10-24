// Домашняя работа по 3ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, задаёт массив заполненный случайными, положительными, трёхзначными числами и покажет количество чётных чисел в массиве.");
    Console.WriteLine("2 - Программа, задаёт одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("3 - Программа, задаёт массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.");
    Console.WriteLine("4 - Если хотите покинуть программу.");
    system = Convert.ToInt32(Console.ReadLine());

    switch (system)
    {
        case 1:
            /*                                              ///Ветка task_01.
            Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
            Напишите программу, которая покажет количество чётных чисел в массиве.
            [345, 897, 568, 234] -> 2
            */            
            Console.Clear();  
            Console.WriteLine("ПРОГРАММА 1 ЗАПУЩЕНА\n");

            //создаём рандомный массив с some кол-вом эл-ов:
            int [] InitRndArray(int some)
            {
                int [] result = new int[some];
                Random rnd = new Random();

                for (int i = 0; i < result.Length; i++)
                    result[i] = rnd.Next(99, 999);
                return result;
            }

            //делим значения массива на 2, с целью посчитать кол-во чётных эл-ов:
            int DividingValues(int [] array)
            {
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                    if(array[i] % 2 == 0)
                        count++;
                return count;
            }

            //просим пользователя задать кол-во эл-ов массива:
            int GetSomeQuantity(string msg)
            {
                Console.Write(msg);
                int result = int.Parse(Console.ReadLine());
                return result;
            }

            //вывод значений массива и результата подсчётов:
            void PrintResult(int [] array, int res)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length -1)
                        Console.Write($"{array[i]} ");
                    else
                        Console.WriteLine($"{array[i]} -> {res}\n");
                }
            }

            int some = GetSomeQuantity("Введите кол-во эл-ов массива: ");
            int [] array = InitRndArray(some);
            int res = DividingValues(array);
            PrintResult(array, res);

            Console.WriteLine("ПРОГРАММА 1 ЗАВЕРШЕНА\n");
            break;

        case 2:
            /*                                              ///Ветка task_02.
            Задача 36: Задайте одномерный массив, заполненный случайными числами. 
            Найдите сумму элементов, стоящих на нечётных позициях.
            [3, 7, 23, 12] -> 19
            [-4, -6, 89, 6] -> 0
            */            
            Console.Clear();  
            Console.WriteLine("ПРОГРАММА 2 ЗАПУЩЕНА\n");

            //создаём массив с size кол-вом эл-ов:
            int [] NewArray(int size)
            {
                int [] result = new int[size];
                Random rnd = new Random();

                for (int i = 0; i < result.Length; i++)
                    result[i] = rnd.Next(0, 99);
                return result;
            }

            //умоляем пользователя огласить кол-во size эл-ов массива:
            int GetSomeNum(string msg)
            {
                Console.Write(msg);
                int result = int.Parse(Console.ReadLine());
                return result;
            }

            //делим индексы и складываем значения нечётных индексов массива:
            int DividingValues2(int [] array)
            {
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                    if(i % 2 != 0)
                        count = count + array[i];
                return count;
            }

            //выводим массив и результат складывания значений нечётных индексов:
            void PrintResult2(int [] array, int num)
            {
                for (int i = 0; i < array.Length; i++)
                    if(i < array.Length -1)
                        Console.Write($"{array[i]}, ");
                    else
                        Console.WriteLine($"{array[i]} -> {num}\n");
            }

            int size = GetSomeNum("Введите кол-во эл-от массива цифрой: ");
            int [] arr = NewArray(size);
            int result = DividingValues2(arr);
            PrintResult2(arr, result);

            Console.WriteLine("ПРОГРАММА 2 ЗАВЕРШЕНА\n");
            break;

        case 3:
            /*                                              ///Ветка task_03.
            Задача 38: Задайте массив вещественных чисел. 
            Найдите разницу между максимальным и минимальным элементов массива.
            [3 7 22 2 78] -> 76
            */            
            Console.Clear();  
            Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА\n");

            //создаём рандомный массив с length кол-вом эл-ов:
            double [] ElseArray(int length)
            {
                double [] result = new double[length];
                Random rnd = new Random();

                for (int i = 0; i < result.Length; i++)
                        result[i] = rnd.NextDouble() *20;
                return result;
            }

            //находим и возвращаем Макс и Мин эл-ты массива:
            (double, double) FindMaxMin(double [] array)
            {
                double max = 0;
                double min = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if(array[i] > max)
                        max = array[i];
                    else
                        min = array[i];
                }
                return (max, min);
            }

            //запрос на ввод кол-ва эл-ов массива:
            int GiveMeSomeNum(string msg)
            {
                Console.Write(msg);
                int result = int.Parse(Console.ReadLine());
                return result;
            }

            //вывод массива и результат разницы эл-ов:
            void PrintAll(double [] array, double max, double min)
            {
                Console.Write("[ ");
                for (int i = 0; i < array.Length; i++)
                {
                    if(i < array.Length -1)
                        Console.Write($"{array[i]} ");
                    else
                        Console.WriteLine($"{array[i]} ] -> {max - min}\n");
                }
            }

            int length = GiveMeSomeNum("Введите задуманное кол-во эл-ов массива цифрой: ");
            double [] arr2 = ElseArray(length);
            (double max, double min) = FindMaxMin(arr2);
            PrintAll(arr2, max, min);

            Console.WriteLine($"Проверка: max = {max} и min = {min}\n");
            Console.WriteLine("ПРОГРАММА 3 ЗАВЕРШЕНА\n");
            break;

        default:
            begin = false;
            break;
    }
}