/* Домашняя работа по 7ой лекции; Расторгуева ВТ; группа 3235;
---------------------------------------------------------------
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