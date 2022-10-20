// Домашняя работа по 3ой лекции; Расторгуева ВТ; группа 3235; ///Ветка Main.

int system;
bool begin = true;

while (begin)
{
    Console.WriteLine();
    Console.WriteLine("Введите номер интересующей вас программы:");
    Console.WriteLine("1 - Программа, принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.WriteLine("2 - Программа, принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("3 - Программа, задаёт массив из 8 элементов и выводит их на экран. Ввод элеменетов через консоль, через запятую (использовать метод string.Split())");
    Console.WriteLine("4 - Если хотите покинуть программу.");
    system = Convert.ToInt32(Console.ReadLine());

    switch (system)
    {
        case 1:
            /*                                              ///Ветка task_01.
            Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
            и возводит число A в натуральную степень B.
            3, 5 -> 243 (3⁵)
            2, 4 -> 16
            */            
            Console.Clear();  
            Console.WriteLine("ПРОГРАММА 1 ЗАПУЩЕНА\n");

            //метод требует ввести число, до тех пор пока не введут цифры:
            int GetNumberFool(string message)   
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

            int numA = GetNumberFool("Введите число A: ");
            int numB = GetNumberFool("Введите число B: ");

            //метод перемножения А, в В кол-во раз:
            int Multiplication(int numA, int numB)
            {
                int result = 1;
                for (int i = 1; i <= numB; i++)
                {
                    result *= numA; 
                }
                return result;
            }

            int res = Multiplication(numA, numB);
            Console.WriteLine($"Результат: {numA}, {numB} -> {res}\n");
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