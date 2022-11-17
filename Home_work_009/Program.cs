/* Домашняя работа по 7ой лекции; Расторгуева ВТ; группа 3235;
---------------------------------------------------------------
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