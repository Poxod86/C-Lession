// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

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

// нахождение максимального значения
int MaxElem(int[,] array)
{
  int max = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] > max)
      {
        max = array[i, j];
      }
    }
  }
  return max;
}

// решение с библиотеками
void CountElementsInMatrix(int[,] matrix, Dictionary<int, int> counter)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
if (counter.ContainsKey(matrix[i, j]))
{
counter[matrix[i, j]]++;
}
else
{
counter.Add(matrix[i, j], 1);
}
}
}
}

Dictionary<int, int> counter = new Dictionary<int, int>();
//int[,] matrix = CreateAndFillMatrix(4, 5, 1, 9);

FillMatrix(matrix, 1, 10);
PrintMatrix(matrix);
PrintMatrix(matrix);
CountElementsInMatrix(matrix, counter);
Console.WriteLine();
foreach (int key in counter.Keys)
{
Console.WriteLine($"There are {counter[key]} - {key}'s");
}


// счетчик двумерного массива
// void CountArray(int[,] array, int max)
// {
//   int count = 0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < max; k++)
//       {
        
//         if( 1 == array[i,j])
//         {
//           count ++;
//           Console.WriteLine(k);
//           Console.WriteLine($"ELEM {array[i,j]} -{count} раз");
//         }
//       }
      
      
//     }
//   }
//   Console.WriteLine(count);
// }

// FillMatrix(matrix, 1, 10);
// PrintMatrix(matrix);
// Console.WriteLine();
// int max = MaxElem(matrix);
// Console.WriteLine(max);
// CountArray(matrix, max);