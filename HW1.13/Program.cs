// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]




Console.WriteLine("Задайте начальное значение массива");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте конечное значение массива");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = generationArray(number, minimum, maximum);


int[] generationArray(int num, int min, int max)
{
  int[] array = new int[num];
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = new Random().Next(min,max+1);
  }
  return array;
}

void PrintArray(int[] arr)
{
  for (int i = 0; i < arr.Length; i++)
  {
    Console.Write(arr[i]);
    if(i < arr.Length-1)
    {
    Console.Write(", ");
    }
  }
}


PrintArray(arr);