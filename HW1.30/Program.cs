// Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

void secondSumFirst(int first, int second, int n)
{
    if (n > 1)
    {
        Console.Write(first + ", ");
        secondSumFirst(second, first + second, n - 1);
    }
    else
    {
        Console.WriteLine(first);
    }
}

secondSumFirst(6, 10, 4);