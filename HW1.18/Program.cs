// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями 
//  y = k1 * x + b1, 
//  y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int coef = 0;
int constant  = 1;
int X = 0;
int Y = 1;
int Line1 = 1;
int Line2 = 2;

double[] lineData1 = inputLineData(Line1);
double[] lineData2 = inputLineData(Line2);

if(ValidateLines(lineData1,lineData2))
{
  double[] coord = findCoords(lineData1, lineData2);
  Console.Write($"Точка пересечения уравнений X = {lineData1[coef]} * X + {lineData1[constant]} и Y = {lineData2[coef]} * X + {lineData2[constant]}");
 Console.WriteLine($" имеет координаты ({coord[X]}, {coord[Y]})");
}

double[] inputLineData(int numbersOfLine)
{
double[] lineData = new double[2];
Console.WriteLine($"Введите коэффициент для {numbersOfLine} прямой");
lineData[coef] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите константу для {numbersOfLine} прямой");
lineData[constant] = Convert.ToDouble(Console.ReadLine());

return lineData;
}

double[] findCoords(double[] lineData1, double[] lineData2)
{
  double[] coord = new double[2];
  coord[X] = (lineData1[constant] - lineData2[constant]) / (lineData2[coef]- lineData1[coef]);
  coord[Y] = lineData1[constant] * coord[X] + lineData1[constant];
  return coord; 
}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
  if(lineData1[coef] == lineData2[coef])
  {
    if(lineData1[constant] == lineData2[constant])
    {
      Console.WriteLine("Прямые совпадают");
      return false;
    }
    else
    {
      Console.WriteLine("Прямые параллельны");
      return false;
    }
  }
  return true;
}