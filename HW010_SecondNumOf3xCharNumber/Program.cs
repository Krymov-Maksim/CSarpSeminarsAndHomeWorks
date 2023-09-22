// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void SecondNum (int number) {                           //метод вывода второго цифры 3-х значного числа
    int number2 = 0;
    number2 = number/10%10;
    Console.WriteLine($"Second figura -> {number2}");
}

Console.WriteLine("Input three-digit number: ");        //ввод 3х-значного числа
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)                                         //проверка числа на отрицательность и перевод в положительность
    number = number * (-1);                  

    if (number < 100 || number > 999)                   //проверка 3х-значности числа
    Console.WriteLine("Number is not in the correct range");

else SecondNum(number);                                 //передача на исполнение методу SecondNum

