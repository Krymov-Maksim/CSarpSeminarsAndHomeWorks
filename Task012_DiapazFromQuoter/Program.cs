//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

void Range(int quat){
    if (quat == 1)
        Console.WriteLine("[X > 0;Y > 0]");
    else if (quat == 2)
        Console.WriteLine("[X < 0;Y > 0]");
    else if (quat == 3)
        Console.WriteLine("[X < 0;Y < 0]");
    else
        Console.WriteLine("[X > 0;Y < 0]");
}

Console.WriteLine("Enter quater number: ");
int quat = Convert.ToInt32(Console.ReadLine());
if(quat<1 || quat>4)
    Console.WriteLine("Error");
else
    Range(quat);
