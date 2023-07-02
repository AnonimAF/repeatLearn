// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter the first number: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num > num2)
    Console.Write("The first number is greater than the second");
else
    Console.Write("The second number is greater than the first");
