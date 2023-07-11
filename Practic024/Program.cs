// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] generateArray(int length, int start, int end)
{

  int[] array = new int[length];
  for (int i = 0; i < length; i++)
  {
    array[i] = new Random().Next(start, end + 1);
  }
  return array;
}

void printArray(int[] array, string name = "")
{
  Console.WriteLine(name);
  Console.Write("[");
  for (int i = 0; i < array.Length; i++)
  {
    if (i != array.Length - 1)
    {
      Console.Write($"{array[i]}, ");
    }
    else
    {
      Console.Write(array[i]);
    }

  }
  Console.WriteLine("]");
}

int[] reversArray(int[] array)
{
  int[] result = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    result[i] = array[array.Length - 1 - i];
  }
  return result;
}

int[] Numbers = generateArray(10, -100, 100);
printArray(Numbers, "Numbers");
int[] revArray = reversArray(Numbers);
printArray(revArray,"Revers");