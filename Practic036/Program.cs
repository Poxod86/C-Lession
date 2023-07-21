// Задайте значение N. Напишите программуб которая выдает все натуральные числа от 1 до N

void PrintAToB(int number, int count = 1)
{
    if (number < count)
    {
        return;
    }
    else
    {
        Console.Write($"{count} ");
        PrintAToB(number, count + 1);
    }
}

PrintAToB(5);