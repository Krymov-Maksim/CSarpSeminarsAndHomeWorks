// НАпишите программу, которая на вход принимает число и выдает его квадрат (число).

Console.WriteLine("Input a number: ");

int num = Convert.ToInt32 (Console.ReadLine ()); // Convert.ToInt32  - переводит строчные буквы в формат числа

int res = num * num;

Console.WriteLine($"Square of number {num} is {res}");

