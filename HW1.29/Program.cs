// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackerman(int m, int n) 
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackerman(1, n - 1);
    }
    else
    {
        return Ackerman(Ackerman (m - 1, n), n - 1);
    }
}

Console.WriteLine(Ackerman(2, 3));