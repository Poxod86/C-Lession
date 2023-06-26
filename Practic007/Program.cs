// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число - {randomNumber}");

int numberOne = randomNumber % 10;
int numberThree = randomNumber / 100;

int result = numberThree*10 + numberOne;
Console.WriteLine(result);