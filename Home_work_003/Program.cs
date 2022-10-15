/* Домашняя работа по 2ой лекции; Расторгуева ВТ; группа 3235;
---------------------------------------------------------------
Задача 23: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/            
Console.Clear();  

//метод выводит таблицу кубов от заданного числа.
void GetNumber (int num)
{
    Console.Write($"{num} -> ");
    for (int i = 1; i <= num; i++)
    {
        var cube = Math.Pow(i, 3);
        Console.Write($"{cube}, ");
    }
    Console.WriteLine();
    Console.WriteLine("Программа 3 завершена \n");
}

Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА\n");
Console.Write("Введите число для формирования таблицы: ");
int number = int.Parse(Console.ReadLine());
GetNumber(number);