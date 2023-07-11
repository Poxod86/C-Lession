// 45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.
int[] test = {1,4,5,6,7,23};
int[] copy = copyArray(test);
printArray(test);
printArray(copy);


int[] copyArray (int[] arr)
{
int[] copyArray = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
  copyArray[i] = arr[i];
}
 return copyArray;
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