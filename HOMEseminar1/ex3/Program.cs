// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// int num = new Random().Next(1, 101);
// int num1 = 1;

// while (num1 <= 101)
// {
//     if (num1 % 2 == 0)
//         Console.Write(num1 + ", ");
//     num1++;
// }


//ver 2.0

Console.Write("Enter number N from 1: ");
int num = int.Parse(Console.ReadLine()!);
int start = 2;

if (num <= 1)
    Console.Write("Invalid value");
while (start <= num)
{
    Console.Write(start + ", ");
    start += 2;
}
