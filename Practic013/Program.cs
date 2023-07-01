/*
  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
  A (3,6); B (2,1) -> 5,09
 A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите x первой точки");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x второй точки");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точки");
int bY = Convert.ToInt32(Console.ReadLine());

int a = aY - bY;
int b = aX - bX;


double distance = Math.Sqrt(a * a + b * b);

Console.WriteLine ($"Растояние между точками равно {distance}");