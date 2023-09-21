// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет



Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
   Console.WriteLine("Number is not Even or Odd"); 
   
   else if (number % 2 != 0) 
    Console.WriteLine($"Number {number} is Odd");

else 
Console.WriteLine($"Number {number} is Even");