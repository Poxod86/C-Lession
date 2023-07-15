// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// m = 3, n = 4.
// -1 4 8 19
// 5 -2 33 -2
// -77 3 8 1

int[,] matrix = new int[3, 4];

// Метод вывода двумерного массива

void printMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]}"+"\t");
    }
    Console.WriteLine();
  }
}

// Метод заполнения двумерного массива

void fillMatrix(int[,] matr, int start, int end)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = new Random().Next(start, end + 1);
    }
  }
}


Console.WriteLine();
fillMatrix(matrix, -5, 10);
printMatrix(matrix);
