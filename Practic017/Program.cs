/*Написать программу, которая принимает на вход число (А) 
и выдает сумму чисел от 1 до А*/

Console.WriteLine("Задайте любое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());

int getMult(int number)
{
  if(number < 0){
  number  = number * (-1);
  }

  int mult = 1;
  for (int i = 1; i <=number; i++)
  {
    mult *= i;
  }
  return mult;
}

Console.WriteLine(getMult(numberA));

// int Base(int from, int to)
// {
// int product = 1;
// for (int i = from; i <= to; i++)
// {
// product *= i;
// }
// return product;
// }

// Console.WriteLine("Введите ваше число:");
// int value = Convert.ToInt32(Console.ReadLine());
// int result= Base(1,value);
// Console.WriteLine($"Ответ: {result}");