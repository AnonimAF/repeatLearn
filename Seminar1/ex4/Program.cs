// Task 5. Напишите программу которая запрашивает трех значное число и выводит последнию цифру

Console.Write("Enter third number: ");
int num = int.Parse(Console.ReadLine()!);

int digit = num % 10;

Console.Write(digit);
