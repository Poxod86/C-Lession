// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Задайте любое целое число");
int number = Convert.ToInt32(Console.ReadLine());

int getQuantityNumber(int num)
{
int coef = 0;
  for (int i = 1; num / i > 0; i*=10)
  {
   coef +=1;
  }
  return coef;
}

Console.WriteLine($"В числе {number} - {getQuantityNumber(number)} знаков");

// int AmountOfDigits(int num)
// {
// int amount = 0;
// while (num > 0)
// {
// num /= 10; // num = num / 10;
// amount++; // amount = amount + 1;
// }
// return amount;
// }


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Количество цифр в числе {number} -> {AmountOfDigits(number)}");