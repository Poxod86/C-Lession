// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] randomArray = getRandomArray(12, 9);
printArray(randomArray);
int sum = getSum(randomArray);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях массива равна -- {sum}");

int[] getRandomArray(int length, int deviation)
{
  int[] result = new int[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(-deviation, deviation + 1);
  }
  return result;
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
  Console.Write("]");
}

int getSum(int[] arr)
{
  int result = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 == 1)
    {
      result += arr[i];
    } 
  }
  return result;
}
