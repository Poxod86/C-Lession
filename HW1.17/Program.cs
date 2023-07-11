// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько чисел будем вводить?");
int Numbers = Convert.ToInt32(Console.ReadLine());



int[] positiveNumber(int M)
{
  int[] Array = new int[M];
  int count = 0;
  for (int i = 0; i < M; i++)
  {
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Array[i] = number;
    if (number > 0) count++;
  }
  Console.WriteLine($"Пользователь ввел {count} положительных чисел");
  return Array;
}


void printArray(int[] arrayToPrint)
{
  Console.Write("[");
  for (int i = 0; i < arrayToPrint.Length; i++)
  {
    Console.Write(arrayToPrint[i]);
    if (i != arrayToPrint.Length - 1)
    {
      Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}
int[] arrayToPrint = positiveNumber(Numbers);
printArray(arrayToPrint);

