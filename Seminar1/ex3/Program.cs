// Task 4. Напишите программк которая на вход принемает число N а на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Enter integer number: ");
int num = int.Parse(Console.ReadLine()!);
int start = -num;

while (start <= num)
{
    Console.Write(start + ", ");
    start++;
}
