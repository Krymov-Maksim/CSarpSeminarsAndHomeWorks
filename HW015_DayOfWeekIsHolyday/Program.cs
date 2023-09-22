// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void WeekEnd (int day){                                 //метод определения выходного дня по номеру дня недели
    if (day == 6 || day == 7)
    Console.WriteLine("-> да");
    else 
    Console.WriteLine("-> нет");
}

Console.WriteLine("Help you with weekend days. Input the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());          // вводим день недели цифрами

if (day < 1 || day > 7)                                 // проверяем правильность ввода числа от 1 до 7
    Console.WriteLine("Такого дня недели не существует");

else 
WeekEnd (day);    
