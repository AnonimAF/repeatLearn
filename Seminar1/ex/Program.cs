// Task 1. Напишите программу которая на вход принимает число и вадает его квадра.

Console.Write("Enter number: ");
string number = Console.ReadLine()!;
int num = int.Parse(number);

//int num = int.Parse(Console.ReadLine()!);
int square = num * num;
Console.Write($"Square number = {square}");
