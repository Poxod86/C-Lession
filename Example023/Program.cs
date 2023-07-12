// Рекурсия. Вычисление факториала


double Factorial(int n) // тип double  решает проблему переполнения памяти
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(3));
