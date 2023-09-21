// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input thirth number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>max && num2>num3) max = num2;
   
    else if (num3 > max) max = num3;
    
else max = num1;

Console.WriteLine ($"{num1}, {num2}, {num3}, -> max = {max}");