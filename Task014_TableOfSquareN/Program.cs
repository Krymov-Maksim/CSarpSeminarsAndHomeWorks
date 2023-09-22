//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.
//-5 -> 1, 4, 9, 16, 25.


void Square(int num){
    for(int i = 1; i<=num; i++){
        Console.Write($"{i*i} ");
    }
}

Console.WriteLine("Enter a number: ");
int numb = Convert.ToInt32(Console.ReadLine());
if(numb < 0)
    numb *= (-1);
else if(numb==0)
    Console.WriteLine("Wrong number");
Square(numb);
