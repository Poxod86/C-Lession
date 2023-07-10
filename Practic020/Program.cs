// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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
  Console.WriteLine("]");
}

void replacingSignsOfNumber(int[] randomArray)
{
  Console.Write("[");
  for (int i = 0; i < randomArray.Length; i++)
  {
      Console.Write(randomArray[i]* -1);
    if (i != randomArray.Length - 1)
      {
        Console.Write(", ");
      }
  }
  Console.WriteLine("]");
}

int[] randomArray = getRandomArray(12, 9);
printArray(randomArray);
replacingSignsOfNumber(randomArray);