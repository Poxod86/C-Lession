/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
квадратов чисел от 1 до N.
*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

void getSquare(int number)
{
  if (number > 0)
  {
    for (int i = 1; i <= number; i++)
    {
      Console.WriteLine($"{i} * {i} = {i * i}");
    }
  }
  else
  {
    for (int i = 1; i >= number; i--)
    {
      Console.WriteLine($"{i} * {i} = {i * i}");
    }
  }

}

getSquare(num);