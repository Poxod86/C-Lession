//Напишите программу, которая будет выдавать дни недели по заданнаму номеру.

Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine($"{number} - это понедельник");
        break;
    case 2:
        Console.WriteLine($"{number} - это вторник");
        break;
    case 3:
        Console.WriteLine($"{number} - это среда");
        break;
    case 4:
        Console.WriteLine($"{number} - это четверг");
        break;
    case 5:
        Console.WriteLine($"{number} - это пятница");
        break;
    case 6:
        Console.WriteLine($"{number} - это суббота");
        break;
    case 7:
        Console.WriteLine($"{number} - это воскресенье");
        break;
    default:
        Console.WriteLine($"{number} - не соответствует дням недели");
        break;
}