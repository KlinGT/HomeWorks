// Домашняя работа по 5ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, создаёт двумерный массив размером m х n, заполненный случайными вещественными числами.");
    Console.WriteLine("2 - Программа, найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
    Console.WriteLine("3 - Если хотите покинуть программу.");
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
            Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
            заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
            значения b1, k1, b2 и k2 задаются пользователем.
            b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
            */
            Console.Clear();
            Console.WriteLine("ПРОГРАММА 2 ЗАПУЩЕНА\n");

            // запрос на ввод значений:
            double EnterinValues(string msg)  
            {
                int result = 0;                 
                bool isCorrect = false;         

                while(!isCorrect)                   
                {
                    Console.Write(msg);     
                    isCorrect = int.TryParse(Console.ReadLine(), out result);

                    if(!isCorrect)
                        Console.WriteLine("Введено не корректное значение, введите значение цифрой!");
                }
                return result;
            }

            // первый х, второй у, далее по формуле:
            (double, double) UsingTheFormula(double b1, double k1, double b2, double k2)
            {
                double x = (-b2 + b1)/(-k1 + k2);
                double y = k2 * x + b2;
                return (x, y);
            }

            var b1 = EnterinValues("Введите значение b1: ");
            var k1 = EnterinValues("Введите значение k1: ");
            var b2 = EnterinValues("Введите значение b2: ");
            var k2 = EnterinValues("Введите значение k2: ");

            (var x, var y) = UsingTheFormula(b1, k1, b2, k2);
            Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})\n");

            Console.WriteLine("ПРОГРАММА 2 ЗАВЕРШЕНА\n");
            break;

        default:
            begin = false;
            break;
    }
}