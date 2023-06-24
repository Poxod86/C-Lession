//Напишите программу, которая на вход принимает число и выдает его квадрат

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = number*number;
Console.Write($"Квадрат числа {number} равно {result}");