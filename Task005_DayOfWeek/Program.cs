//Напишите программу,
//которая выводит название дня недели по заданному номеру

Console.WriteLine("Input number day of week: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1){
    Console.WriteLine($"This day {day} is Monday");}

else if (day == 2){
    Console.WriteLine($"This day {day} is Tuensday");}

else if (day == 3){
    Console.WriteLine($"This day {day} is Wednesday");}

else if (day == 4){
    Console.WriteLine($"This day {day} is Thursday");}

else if (day == 5){
    Console.WriteLine($"This day {day} is Friday");}

else if (day == 6){
    Console.WriteLine($"This day {day} is Saturday");}

else if (day == 7){
    Console.WriteLine($"This day {day} is Sunday");}

else  
    Console.WriteLine($"This day {day} is not exist");
