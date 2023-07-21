// Напишите программу, которая на вход принимает два числа A и В 
// И возводит число А в целую степень В с помощью рекурсии.

int AToPowB(int a, int b)
{
  if (b == 1)
  {
    return a;
  }
  else
  {
    return a * AToPowB(a, b - 1);
  }

}

Console.WriteLine(AToPowB(2, 4));