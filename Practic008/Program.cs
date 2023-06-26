// # Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно

int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

double result = firstNumber % secondNumber;
if(result == 0)
{
Console.WriteLine($"Число {secondNumber} Кратно числу {firstNumber}");
} else {
Console.WriteLine($"Число {secondNumber} не кратно числу {firstNumber} Остаток {result}");
}
