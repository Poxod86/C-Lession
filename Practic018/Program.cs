// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
  array[i] = new Random().Next(0,2);
}


void PrintArray(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write(arr[i]);
    if(i < arr.Length-1)
    {
    Console.Write(", ");
    }
  }
  Console.WriteLine("]");
}

PrintArray(array);