// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

int[] randomArray = getRandomArray(12, 9);
printArray(randomArray);

int getSum(int[] randomArray, int multiply)
{
  int result = 0;
  for (int i = 0; i < randomArray.Length; i++)
  {
    if (randomArray[i] * multiply > 0)
    {
      result += randomArray[i];
    } 
  }
  return result;
}
int sumPositive = getSum(randomArray, 1);
int sumNegative = getSum(randomArray, -1);
Console.WriteLine();
Console.WriteLine($"Сумма положительных цифр массива равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных цифр массива равна {sumNegative}");