// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
void GetArithmeticMean(int[,] matr)
{
  double sumCol = 0;
  for (int i = 0; i < matr.GetLength(1); i++)
  {
  double arithmeticMean = 0;
  for (int j = 0; j < matr.GetLength(0); j++)
  {
    sumCol += matr[j,i];
  }
   arithmeticMean = sumCol / matr.GetLength(0);
   Console.WriteLine($"Среднее арифметическое {i}-го столбца равно {arithmeticMean}\t");
  }
}

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
GetArithmeticMean(matrix);
