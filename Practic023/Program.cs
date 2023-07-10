// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.


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


int[] randomArray = getRandomArray(5, 9);
printArray(randomArray);

int[] productOfPairs(int[] arr)
{
  int size = 0;
  if(arr.Length % 2 == 0){
    size = arr.Length / 2;  
  } else {
     size = arr.Length / 2 + 1; 
  }
  int[] productArray = new int[size];
  for (int i = 0; i < arr.Length / 2; i++)
  {
    productArray[i] = arr[i]* arr[arr.Length -1 -i];
  }
  if (size % 2 == 1){
    productArray[size - 1] = arr[arr.Length / 2];
  }
  return productArray;
}
int[] productArray = productOfPairs(randomArray);
printArray(productArray);