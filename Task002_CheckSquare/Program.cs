// НАпишите программу, которая на вход принимает два числа и проверят,
// является ли первое число квадратом второго

Console.WriteLine("Inpit first number: ");
int num1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Inpit second number: ");
int num2 = Convert.ToInt32 (Console.ReadLine());

if(num2*num2 == num1)
    {
    Console.WriteLine($"{num1} is square of {num2}");
    }
else 
    {
    Console.WriteLine($"{num1} is not qsuare of {num2}");
    }