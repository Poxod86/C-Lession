// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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



int GetElem(int[,] matr, int row, int col)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (i == row && j == col)
      {
        Console.WriteLine($"Элемент под индексом {row}, {col} равен {matr[i, j]}");
        return matr[i, j];
      }
    }
  }
   Console.WriteLine($"Элемент под индексом {row}, {col} не существует");
  return -1;
}

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
Console.WriteLine("Введите индекс строки элемента");
int rowArray =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца элемента");
int colArray =  Convert.ToInt32(Console.ReadLine());
GetElem(matrix, rowArray, colArray);
