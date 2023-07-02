// Task 2. Напишите программу которая на вход принемает два числа и проверяет являеться ли первое число квадратом второго

Console.Write("Enter first number: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
int num2 = int.Parse(Console.ReadLine()!);

// if (num == num2 * num2)
//   	Console.Write($"Number {num} is a square {num2}");
// else
// 		Console.Write($"Number {num} is not a square {num2}");

// // ver 2.0

// bool check = num == num2 * num2;
// Console.Write(check);

//ver 3.0

Console.Write(num == num2 * num2);
