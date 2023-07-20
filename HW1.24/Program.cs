// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = new int[3, 5];
int[,] matrix2 = new int[5, 3];

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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int firstMatrixRows = firstMatrix.GetLength(0);
    int firstMatrixCols = firstMatrix.GetLength(1);
    int[,] matrixProduct = new int[firstMatrixRows, firstMatrixCols];
    if ((firstMatrixRows == secondMatrix.GetLength(1))
    && (firstMatrixCols == secondMatrix.GetLength(0)))
    {
        for (int i = 0; i < firstMatrixRows; i++)
        {
            for (int j = 0; j < firstMatrixCols; j++)
            {
                matrixProduct[i, j] = firstMatrix[i, j] * secondMatrix[j, i];
            }
        }
        PrintMatrix(matrixProduct);
    }
    else
    {
        Console.WriteLine("Невозможно перемножить матрицы");
    }
    return matrixProduct;
}

FillMatrix(matrix1, 1, 10);
PrintMatrix(matrix1);
Console.WriteLine();
FillMatrix(matrix2, 2, 9);
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrixProducts = MatrixMultiplication(matrix1, matrix2); 
Console.WriteLine();