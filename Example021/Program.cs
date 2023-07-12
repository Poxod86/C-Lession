// Методы заполнения и вывода двумерных массивов

int[,] matrix = new int[3, 4];

// Метод вывода двумерного массива

void printMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]}");
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

printMatrix(matrix);
Console.WriteLine();
fillMatrix(matrix, 0, 1);//Заполнение массива 0 и 1
printMatrix(matrix);