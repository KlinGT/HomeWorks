// Домашняя работа по 5ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, считает кол-во положительных значений из введённых пользователем.");
    Console.WriteLine("2 - Программа, найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2.");
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