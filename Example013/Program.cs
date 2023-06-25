/**
метод, который ничего не возвращает называется void
new int[10] - новый массив из 10 элементов по умолчению 10 нулей
Метод FillArray  - наполнение массива случайными элементами
Метод PrintArray - метод который печатает массив
*/
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
      collection[index] = new Random().Next(1,10);
      index++;
    }
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int position = 0;
  while (position < count)
  {
    Console.WriteLine(coll[position]);
    position++;
  }
}
int[] array = new int[10];

FillArray(array);
PrintArray(array);