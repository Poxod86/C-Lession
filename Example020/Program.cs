//Двумерные массивы. Создание матрицы.

string[,] table = new string[2,5]; // 2 - строки, 5 - столбцы
int[,] matrix = new int[3,5]; // 3 - строки, 5 - столбцы

// Обход двумерного массива (матрицы)

for (int i = 0; i < table.GetLength(0); i++)
{
  for (int j = 0; j < table.GetLength(1); j++)
  {
    Console.Write($"-{table[i,j]}");
  }
  Console.WriteLine("");
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i,j]}");
  }
  Console.WriteLine("");
}