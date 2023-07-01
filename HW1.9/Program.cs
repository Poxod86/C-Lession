// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x первой точки");
int aX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y первой точки");
int aY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z первой точки");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x второй точки");
int bX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y второй точки");
int bY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z второй точки");
int bZ = Convert.ToInt32(Console.ReadLine());

int a = aY - bY;
int b = aX - bX;
int c = aZ - bZ;


double distance = Math.Sqrt(a * a + b * b + c * c);

Console.WriteLine ($"Растояние между точками равно {distance}");