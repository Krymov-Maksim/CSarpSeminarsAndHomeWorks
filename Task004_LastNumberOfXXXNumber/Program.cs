//Напишите программу, которая принимает на вход трехзначное число
//и на выходе показывает последнюю цифру этого числа

Console.WriteLine("Input 3-x number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0)  
    number = number * (-1);

if (number>100 && number<999)
    Console.WriteLine($"Here number is {number%10}");
else 
Console.WriteLine("Number is not thirth char");