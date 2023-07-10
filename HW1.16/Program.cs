// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] randomArray = getRandomArray(12, -10, 20);
printArray(randomArray);
Console.WriteLine();
double arrayMin =  getMinArray(randomArray);
double arrayMax =  getMaxArray(randomArray);
Console.WriteLine($"Разница между максимальным значением {arrayMax} и минимальным значением {arrayMin} Равна {getResult(arrayMax,arrayMin)}");

double[] getRandomArray(int length, int start, int end)
{
  double[] result = new double[length];
  for (int i = 0; i < length; i++)
  {
    result[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(start, end + 1);
  }
  return result;
}

void printArray(double[] arrayToPrint)
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

double getMinArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] < min){
        min  = array[i];
      }
    }
    return min;
}
double getMaxArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
      if(array[i] > max){
        max  = array[i];
      }
    }
    return max;
}

double getResult(double max, double min){
 double result = Math.Round(max - min,2);
 return result;
}