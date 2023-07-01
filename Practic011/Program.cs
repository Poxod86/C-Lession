/*
  Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
x=34; y=-30 -> 4
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/
Console.WriteLine("Введите кординату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординату y");
int y = Convert.ToInt32(Console.ReadLine());

int getNumberOfQuarter(int X, int Y)
{

  int result = 0;
  if (X > 0 && Y > 0)
  {
    result = 1;
  }
  else if (X < 0 && Y > 0)
  {
    result = 2;
  }
  else if (X < 0 && Y < 0)
  {
    result = 3;
  }
  else if (X > 0 && Y < 0)
  {
    result = 4;
  }
  return result;
}

int quarter = getNumberOfQuarter(x,y);

if (quarter > 0){
  Console.WriteLine($"При координатах x = {x} и y = {y} точка лежит в {quarter} четверти");
} else {
  Console.WriteLine($"При координатах x = {x} и y = {y} точка лежит на пересечении плоскостей");
}
