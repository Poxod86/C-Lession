﻿// # Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8


int randomNumber = new Random().Next(10, 100);
Console.WriteLine($"Случайное число - {randomNumber}");
int numberOne = randomNumber % 10;
int numberTwo = randomNumber / 10;
Console.Write($"У числа - {randomNumber}");
if(numberOne > numberTwo)
{
    Console.WriteLine($" Максимальная цифра - {numberOne}");
} else {
    Console.WriteLine($" Максимальная цифра - {numberTwo}");
}
