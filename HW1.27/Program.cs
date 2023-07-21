// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNToOne(int number, int count = 1)
{
    if (number < count)
    {
        return;
    }
    else
    {
        Console.Write($"{number} ");
        PrintNToOne(number - 1, count);
    }
}

PrintNToOne(5);