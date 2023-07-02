// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Write("Enter the first number: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third number: ");
int num3 = int.Parse(Console.ReadLine());

int max = num;

if (max < num2)
    max = num2;
if (max < num3)
    max = num3;

Console.Write("Max number = " + max);





// if (num > num2 && num > num3)
//     Console.Write("max number: " + num);
// else if (num2 > num3)
//     Console.Write("max number: " + num2);
// else
//     Console.Write("max number: " + num3);
