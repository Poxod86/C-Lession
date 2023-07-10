// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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


int[] randomArray = getRandomArray(12, 9);


Console.WriteLine("Задайте число ");
int number = Convert.ToInt32(Console.ReadLine());


bool isNumberinArray(int[] RandomArray, int num){
  for (int i = 0; i < RandomArray.Length; i++)
  {
    if(randomArray[i] == num)
    {
      return true;
    } 
   }
  return false;
}



if(isNumberinArray(randomArray,number)){
printArray(randomArray);
Console.WriteLine("да"); 
} else {
  printArray(randomArray);
  Console.WriteLine("нет");
}




