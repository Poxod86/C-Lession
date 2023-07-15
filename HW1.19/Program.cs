// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] matrix = new double[3, 4];

// Метод вывода двумерного массива

void printMatrix(double[,] matr)
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

void fillMatrix(double[,] matr, int start, int end)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      matr[i, j] = Math.Round(new Random().NextDouble(),2)+new Random().Next(start, end + 1);
    }
  }
}


Console.WriteLine();
fillMatrix(matrix, -5, 10);
printMatrix(matrix);

