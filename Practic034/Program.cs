// 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

int[,] matrix = new int[4, 5];

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

// Метод замены строк  на столбцы массива

int[,] RomsToColumns(int[,] array)
{
int[,] matr = new int[array.GetLength(0), array.GetLength(1)];
  if (array.GetLength(0) != array.GetLength(1))
  {
    Console.WriteLine("Матрица невозможна");
    return matr;
  }
  else
  { 
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        
       matr[j,i] = array[i,j];
        
      }
    }

  }
  return matr;
}

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
int[,] reversMatrix = RomsToColumns(matrix);

PrintMatrix(reversMatrix);