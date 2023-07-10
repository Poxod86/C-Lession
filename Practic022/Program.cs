// 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int[] randomArray = getRandomArray(123, 1000);
printArray(randomArray);
int fillNumberArray(int[] array, int startArray, int finishArray){
int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if( array[i] >= startArray && array[i] <= finishArray){
   Console.WriteLine(array[i]);
   count++;
  }
  
}
return count;
}


Console.WriteLine(fillNumberArray(randomArray, 10, 99));