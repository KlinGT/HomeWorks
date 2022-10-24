// Домашняя работа по 3ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, считает кол-во положительных значений из введённых пользователем.");
    Console.WriteLine("2 - Программа, .");
    Console.WriteLine("3 - Если хотите покинуть программу.");
    system = Convert.ToInt32(Console.ReadLine());

    switch (system)
    {
        case 1:
            /*                                              ///Ветка task_01.
            Задача 41: Пользователь вводит с клавиатуры M чисел. 
            Посчитайте, сколько чисел больше 0 ввёл пользователь.
            0, 7, 8, -2, -2 -> 2
            1, -7, 567, 89, 223 -> 4
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 1 ЗАПУЩЕНА\n");

            // запрос на ввод чисел через пробел, ввывод в массив без (' ', ','):
            string[] AcceptValuesInArray(string msg)
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                string[] strArray = str.Split(' ', ',');
                return strArray;
            }

            // из массива string в массив int:
            int[] ConvertingFromStrToNums(string[] strArray)
            {
                int[] numArray = new int[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    numArray[i] = int.Parse(strArray[i]);
                }
                return numArray;
            }

            // сколько чисел больше 0 ввёл пользователь:
            int CheckingForPositiveNums(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0) count++;
                }
                return count;
            }

            // вывод значений массива в консоль:
            void PrintArray(int[] array, int num)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < array.Length - 1)
                        Console.Write($"{array[i]}, ");
                    else
                        Console.Write($"{array[i]} -> {num}");
                }
                Console.WriteLine("\n");
            }

            string[] someStr = AcceptValuesInArray("Введите отрицательные и положительные цифры через пробел:");
            int[] numArray = ConvertingFromStrToNums(someStr);
            int positiv = CheckingForPositiveNums(numArray);
            PrintArray(numArray, positiv);

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
            int[] NewArray(int size)
            {
                int[] result = new int[size];
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
            int DividingValues2(int[] array)
            {
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                    if (i % 2 != 0)
                        count = count + array[i];
                return count;
            }

            //выводим массив и результат складывания значений нечётных индексов:
            void PrintResult2(int[] array, int num)
            {
                for (int i = 0; i < array.Length; i++)
                    if (i < array.Length - 1)
                        Console.Write($"{array[i]}, ");
                    else
                        Console.WriteLine($"{array[i]} -> {num}\n");
            }

            int size = GetSomeNum("Введите кол-во эл-от массива цифрой: ");
            int[] arr = NewArray(size);
            int result = DividingValues2(arr);
            PrintResult2(arr, result);

            Console.WriteLine("ПРОГРАММА 2 ЗАВЕРШЕНА\n");
            break;

        default:
            begin = false;
            break;
    }
}