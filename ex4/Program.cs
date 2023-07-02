// 5 Task. Задача с применением функции Random.

Console.Write("Enter your name: ");
string username = Console.ReadLine()!;
Console.Write("Enter second number: ");
double num2 = int.Parse(Console.ReadLine()!);
int num = new Random().Next(1, 99);
Console.WriteLine("Random = " + num);

double res = num / num2;

Console.Write(username + $" Result = {res}");
