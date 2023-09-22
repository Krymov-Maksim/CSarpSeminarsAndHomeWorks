//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.

double Dist(int x1, int y1, int x2, int y2){
    int x = x2-x1;
    int y = y2-y1;
    double res = Math.Round(Math.Sqrt(x*x + y*y),2);
    return res;
}

Console.WriteLine("Enter x1 point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y1 point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter x2 point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y2 point: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance beetween points is {Dist(x1,y1,x2,y2)}");


