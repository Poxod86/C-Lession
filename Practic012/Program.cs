/*Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y)
*/

Console.WriteLine("Введите номер четверти координат от 1 до 4");
int quarter = Convert.ToInt32(Console.ReadLine());

string getCoordinates (int quarter)
{
string result = "";
  if (quarter == 1)
  {
    result  = "x > 0 and y > 0";
  }
  else if (quarter == 2)
  {
   result  = "x < 0; y > 0";
  }
  else if  (quarter == 3)
  {
   result  = "x < 0; y < 0";
  }
  else
  {
    result  = "x > 0; y < 0";
  }
 return result;
}

string answer = getCoordinates(quarter);

Console.WriteLine($"В четверти {quarter} диапазон координат будет {answer}");