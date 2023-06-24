// Напишите программу, которая принимает на вход трехзначное число и на выходе показыват последнюю цифру этого числа

Console.WriteLine("Введите число");
int number =  Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number >= 100 && number <= 999) {
  int result = number % 10;
  Console.WriteLine($"Число {result} является последним числа {number}");
}
Console.WriteLine("Вы ввели не треззначное число");
