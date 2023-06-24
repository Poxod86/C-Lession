//Напишите программу, которая на вход принимает 2  числа и проверяет, является ли первое квадратом второго.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1/ number2;
if ( number2 == number1 / number2)
{
  Console.Write($"Число {number1} является квадратом числа  {number2}");
}
else
{
  Console.Write($"Число {number1}  не является квадратом числа  {number2}");
}


