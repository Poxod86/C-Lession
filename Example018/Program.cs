//Сортировка массива по возрастанию;

int[] arr = {1, 3, 9 ,5, 6, 7, 2, 4, 1, 8};

void PrintArray(int[] array)
{
 int count = array.Length;
 for (int i = 0; i < count; i++)
 {
  Console.Write($"{array[i]} ");
 }
  Console.WriteLine();
}

void SelectionSort(int[] array)
{
 int count = array.Length - 1;
 for (int i = 0; i < count; i++)
 {
  int minPosition = i;

  for (int j = i + 1; j < array.Length; j++)
  {
    if(array[j] < array[minPosition])
    {
      minPosition = j;
    }
  }


  int temp = array[i];
  array[i] = array[minPosition];
  array[minPosition] = temp;
 }
 
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);