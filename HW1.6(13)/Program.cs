// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number =  Convert.ToInt32(Console.ReadLine());
string str = number.ToString();

if (number / 100 > 1)
{
  Console.WriteLine($"Третья цифра числа {number} равна {str[2]}");
}
else
{
  Console.WriteLine($"У числа {number} третьей цифры нет");
}

