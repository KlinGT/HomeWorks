/* Домашняя работа по 7ой лекции; Расторгуева ВТ; группа 3235;
---------------------------------------------------------------
Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/            
Console.Clear();
Console.WriteLine("ПРОГРАММА 3 ЗАПУЩЕНА\n");

// ввод значения M и N с консоли:
int EnteringTwoValues(string msg)
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

// вывод функции Аккермана:
int AckermanFunctions(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return AckermanFunctions(m - 1, 1);
    else return (AckermanFunctions(m - 1, AckermanFunctions(m, n - 1)));
}

int m = EnteringTwoValues("Введите значение M: ");
int n = EnteringTwoValues("Введите значение N: ");
Console.WriteLine($"A(m,n) = {AckermanFunctions(m, n)}");

Console.WriteLine("\nПРОГРАММА 3 ЗАВЕРШЕНА\n");