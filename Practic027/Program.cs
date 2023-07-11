// 44. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int fiby = 1;
int nextFiby = 1;
int prefFiby = 0;
Console.WriteLine(prefFiby);
Console.WriteLine(fiby);
for (int i = 2; i < N; i++)
{
  nextFiby = fiby + prefFiby;
  prefFiby = fiby;
  fiby = nextFiby;
  Console.WriteLine(fiby);
}