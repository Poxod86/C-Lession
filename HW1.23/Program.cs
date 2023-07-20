// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] matrix = new int[3, 5];

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
// Метод нахождения минимальной суммы строки

void MinSumRows(int[,] array)
{
int result = 0;
int str = 0;
for (int j = 0; j < array.GetLength(0); j++)

{ 
int sum = 0;
  for (int i = 0; i < array.GetLength(1); i++)
{
  sum += array[j,i];
}
 if(result == 0 || result > sum) 
 {
 result = sum;
 str = j+1;
 }

}
Console.WriteLine($"Минимальная сумма элементов = {result} - {str} строка");
}


FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();
MinSumRows(matrix);
