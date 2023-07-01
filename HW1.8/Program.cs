// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

while (true)
{
  Console.WriteLine("Введите пятизначное число");
  int num = Convert.ToInt32(Console.ReadLine());
  if (num / 10000 >= 1 && num / 10000 <= 10)
  {
    bool result = Palindrom(num);
    Console.WriteLine($"Число {num} - палиндром? - {result}");
    return;
  }
  else
  {
    Console.WriteLine($"Вы ввели не пятизначное число. Попробуйте еще раз");
  }
}

bool Palindrom(int num)
{
  int number1 = num % 10;
  int number2 = num / 10 % 10;
  int number4 = num / 1000 % 10;
  int number5 = num / 10000 % 10;

  bool res = false;
  if (number1 == number5 && number2 == number4) res = true;
  return res;
}

