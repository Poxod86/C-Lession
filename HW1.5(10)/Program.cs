﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
  int numberTwo = (number / 10) % 10;
  Console.WriteLine($"Вторая цифра числа {number} равна {numberTwo}");
} else {
Console.WriteLine($"Вы ввели не трехзначное число");
}
