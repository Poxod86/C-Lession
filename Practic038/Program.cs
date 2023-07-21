// Напишите программу которая будет принимать число и
// выводить сумму его чисел.

int PrintSumNumber(int number)
{
    if (number != 0)
    {
       return number % 10 + PrintSumNumber(number / 10);
    }
    return 0;
}

Console.WriteLine(PrintSumNumber(345));
