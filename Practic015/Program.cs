/*Написать программу, которая принимает на вход число (А) 
и выдает сумму чисел от 1 до А*/

Console.WriteLine("Задайте любое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());

int getSum(int number)
{
  if(number < 0){
  number  = number * (-1);
  }

  int sum = 0;
  for (int i = 0; i <=number; i++)
  {
    sum += i;
  }
  return sum;
}

Console.WriteLine(getSum(numberA));