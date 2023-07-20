// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralFilledMatrix(int rows, int columns)
{
    int topPadding = 0;
    int bottomPadding = 0;
    int leftPadding = 0;
    int rightPadding = 0;
    int currentHorizontalPos = -1;
    int currentVerticalPos = 0;
    int currentNum = 1;
    string direction = "right";
    int[,] spiralMatrix = new int[rows, columns];
    for (int i = 1; i < rows + columns; i++)
    {
        if (direction == "right")
        {
            while (currentHorizontalPos < columns - 1 - rightPadding)
            {
                currentHorizontalPos++;
                spiralMatrix[currentVerticalPos, currentHorizontalPos] = currentNum;
                currentNum++;
            }
            topPadding++;
            direction = "down";
        }
        else if (direction == "down")
        {
            while (currentVerticalPos < rows - 1 - bottomPadding)
            {
                currentVerticalPos++;
                spiralMatrix[currentVerticalPos, currentHorizontalPos] = currentNum;
                currentNum++;
            }
            rightPadding++;
            direction = "left";
        }
        else if (direction == "left")
        {
            while (currentHorizontalPos > 0 + leftPadding)
            {
                currentHorizontalPos--;
                spiralMatrix[currentVerticalPos, currentHorizontalPos] = currentNum;
                currentNum++;
            }
            bottomPadding++;
            direction = "up";
        }
        else
        {
            while (currentVerticalPos > 0 + topPadding)
            {
                currentVerticalPos--;
                spiralMatrix[currentVerticalPos, currentHorizontalPos] = currentNum;
                currentNum++;
            }
            leftPadding++;
            direction = "right";
        }
    }
    return spiralMatrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] spiral = CreateSpiralFilledMatrix(2, 2);
PrintMatrix(spiral);