// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

// Randome rnd = new Random();
// int num = rnd.Next(10, 100);

int MaxDigit(int number)
{
    int first = number / 10;
    int second = number % 10;
    if (first > second)
        return first;
    else
        return second;
}

int RandomNum()
{
    int num = new Random().Next(10, 100);
    Console.WriteLine("Generated number: " + num);
    return num;
}

int rand = RandomNum();
int maxDigit = MaxDigit(rand);
Console.Write($"Max number in digit {rand} = {maxDigit}");
