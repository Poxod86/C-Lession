// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int PrintSumMToN(int start, int finish)
{
    if (finish == start)
    {
        return start;
    }
    else
    {
        return finish + PrintSumMToN(start, finish-1);
    }
}

Console.WriteLine(PrintSumMToN(4, 8));