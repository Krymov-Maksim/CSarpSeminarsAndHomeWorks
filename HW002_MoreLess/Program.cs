// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
    Console.WriteLine ($"a={num1} b={num2} -> max = {num1}, min = {num2}");
    
else Console.WriteLine ($"a={num1} b={num2} -> max = {num2}, min = {num1}");
