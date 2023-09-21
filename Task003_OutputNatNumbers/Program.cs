// НАпишите программу, которая на вход принимает одно число (N)?
//а на выходе показывает все числа от 0 до N

// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32 (Console.ReadLine());
// int count = 0;
// while(count<n){
//     Console.WriteLine($"{count}");
//     count++;
// }


// НАпишите программу, которая на вход принимает одно число (N),
//а на выходе показывает все числа от -N до N

Console.WriteLine("Input number: ");
int n = Convert.ToInt32 (Console.ReadLine());
int current = n*(-1);
for(int i = current; i<=n; i++){
    Console.Write($"{i}");
    }