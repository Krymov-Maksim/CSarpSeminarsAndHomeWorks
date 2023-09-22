// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




void ThirthNum (int number) {                           //метод вывода второго цифры 3-х значного числа
    int digit3 = number/100%10;
    Console.WriteLine($"Thirth digit -> {digit3}");
}

Console.WriteLine("Input any number: ");                //ввод любого числа
int number = Convert.ToInt32(Console.ReadLine());

              
if (number < 0) number = number * (-1);                 //убираем отричательность, чтобы не выводился ответ со знаком "-"

if (number < 100 && number > -100)                      //проверка 3х-значности числа
    Console.Write("-> третьей цифры нет");

else ThirthNum(number);                                 //передача на исполнение методу SecondNum


