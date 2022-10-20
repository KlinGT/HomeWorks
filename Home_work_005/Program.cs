// Домашняя работа по 3ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, задаёт массив заполненный случайными, положительными, трёхзначными числами и покажет количество чётных чисел в массиве.");
    Console.WriteLine("2 - Программа, принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("3 - Программа, задаёт массив из 8 элементов и выводит их на экран. Ввод элеменетов через консоль, через запятую (использовать метод string.Split())");
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
            Задача 27: Напишите программу, которая принимает на вход число 
            и выдаёт сумму цифр в числе.
            452 -> 11
            82 -> 10
            9012 -> 12
            */            
            Console.Clear();  
            Console.WriteLine("ПРОГРАММА 2 ЗАПУЩЕНА\n");

            //метод требует ввести число, до тех пор пока не введут цифры:
            int GetNumberFool2(string message)   
            {
                int result = 0;                 
                bool isCorrect = false;         

                while(!isCorrect)                   
                {
                    Console.Write(message);     
                    isCorrect = int.TryParse(Console.ReadLine(), out result);

                    if(!isCorrect)
                        Console.WriteLine("Введены не цифры, введите корректное число!");
                }
                return result;
            } 

            //метод складывания цифр числа:
            int Folding(int numBer)
            {
                int count = Convert.ToString(numBer).Length;
                int result = 0;
                int temp = 0;

                for (int i = 0; i < count; i++)
                {
                    temp = numBer - numBer % 10;
                    result = result + (numBer - temp);
                    numBer /= 10; 
                }
                return result;
            }

            int numBer = GetNumberFool2("Введите же Ваше число: ");
            int sumOfDigit = Folding(numBer);
            Console.WriteLine($"Результат: {numBer} -> {sumOfDigit}\n");
            Console.WriteLine("ПРОГРАММА 2 ЗАВЕРШЕНА\n");
            break;

        case 3:
            /*                                              ///Ветка task_03.
            Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
            и выводит их на экран.
            1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
            6, 1, 33 -> [6, 1, 33]
            Ввод элеменетов через консоль (через запятую. использовать метод string.Split()).
            */          
            Console.Clear();  
            Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА\n");

            //метод ввода значений массива:
            string[] GetStrArray()
            {
                Console.WriteLine("Введите значения массива через запятую: ");
                string str = Console.ReadLine();
                string [] strArray = str.Split(' ', ',');
                return strArray;
            }

            //метод из string в int:
            int [] GetNumArray(string [] strArray)
            {
                int [] numArray = new int[strArray.Length];
                for (int i = 0; i < strArray.Length; i++)
                {
                    numArray[i] = int.Parse(strArray[i]);
                }
                return numArray;
            }

            //метод вывода в консоль, int массива с запятыми:
            void GetArrayOut(int [] numArray) 
            {
                for (int i = 0; i < numArray.Length; i++)
                {
                    if(i < numArray.Length -1)
                        Console.Write($"{numArray[i]}, ");
                    else
                        Console.WriteLine($"{numArray[i]}");
                }
                Console.WriteLine();
            }

            string [] strArray = GetStrArray();
            int [] numArray = GetNumArray(strArray);
            GetArrayOut(numArray);
            Console.WriteLine("ПРОГРАММА 3 ЗАВЕРШЕНА\n");
            break;

        default:
            begin = false;
            break;
    }
}