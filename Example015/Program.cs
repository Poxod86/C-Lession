//Виды методов

// Вид 1 (ничего не принимают ничего не возвращают)
void Method1()
{
  Console.WriteLine("Автор...");
}

Method1();

// Вид 2 (принимают, но ничего не возвращают)

void Method2(string msg)
{
  Console.WriteLine(msg);
}

Method2(msg: "Новое сообщение");


void Method2_1(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine($"{msg}{i}");
    i++;
  }
}

Method2_1("текст", 3);
// или именнованные аргументы - порядок не обязателен
Method2_1(count: 3, msg:"Сообщение");

// Вид 3 (не принимают, но возвращают)

int Method3()
{
  return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

// Вид 4 (принимают и возвращают)

string Method4(int count, string text)
{
  int i = 0;
  string result = String.Empty;// String.Empty - пустая строка "";
  while (i < count)
  {
    result = result + text;
    i++;
  }
  return result;
}

string res = Method4(3, "метод4");
Console.WriteLine(res);
