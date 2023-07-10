// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] randomArray = getRandomArray(12, 100, 1000);
printArray(randomArray);
Console.WriteLine();
Console.WriteLine($" Количество четных чисел в массиве равно {getCountPositive(randomArray)}");


int[] getRandomArray(int length, int start, int finish)
{
  int[] result = new int[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = new Random().Next(start, finish);
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


int getCountPositive(int[] arr)
{
 int count = 0;
 for (int i = 0; i < arr.Length; i++)
 {
   if(arr[i] % 2 == 0){
    count++;
   }
 }
 return count;
}
