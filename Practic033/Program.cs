//  Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

int[,] matrix = new int[4, 4];

// Метод вывода двумерного массива

void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]}  \t");
    }
    Console.WriteLine();
  }
}

// Метод заполнения двумерного массива

void FillMatrix(int[,] matr, int start, int end)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(start, end + 1);
    }
  }
}
// Метод замены строк массива

void Replace(int[,] array)
{
int temp = 0;
 for (int i = 0; i < array.GetLength(1); i++)
 {
   temp = array[array.GetLength(0) - 1, i];
   array[array.GetLength(0) - 1, i] = array[0, i];
   array[0, i] = temp;
 }
}

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
Replace(matrix);
PrintMatrix(matrix);