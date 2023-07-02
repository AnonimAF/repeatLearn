// // Задача найти максемальное значение из 9 цифр. Как у преподавателя за исключением того что цифры вы пишите сами

// Console.Write("Enter the first number: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the second number: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the third number: ");
// int num3 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the fourth number: ");
// int num4 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the fifth number: ");
// int num5 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the sixth number: ");
// int num6 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the seventh number: ");
// int num7 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the eighth number: ");
// int num8 = int.Parse(Console.ReadLine()!);
// Console.Write("Enter the ninth number: ");
// int num9 = int.Parse(Console.ReadLine()!);

// int max1 = Max(num, num2, num3);
// int max2 = Max(num4, num5, num6);
// int max3 = Max(num7, num8, num9);
// int max = Max(max1, max2, max3);

// НАЧАЛО КУСКА работы с пометкой начала и конца через простой вариант работы.
// // if (num2 > max)
// //     max = num2;
// // if (num3 > max)
// //     max = num3;
// // if (num4 > max)
// //     max = num4;
// // if (num5 > max)
// //     max = num5;
// // if (num6 > max)
// //     max = num6;
// // if (num7 > max)
// //     max = num7;
// // if (num8 > max)
// //     max = num8;
// // if (num9 > max)
// //     max = num9;

// // Console.Write(max);
// КОНЕЦ КУСКА.


// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result)
//         result = arg2;
//     if (arg3 > result)
//         result = arg3;
//     return result;
// }

// Console.Write(max);

//ПОСЛЕДНЯЯ ВЕРСИЯ, реализованная как у преподавателя за исклбчением того что программа сама подберает числа за счет функции Random

int num1 = new Random().Next(1, 101);
Console.WriteLine("number 1 = " + num1);
int num2 = new Random().Next(1, 101);
Console.WriteLine("number 2 = " + num2);
int num3 = new Random().Next(1, 101);
Console.WriteLine("number 3 = " + num3);
int num4 = new Random().Next(1, 101);
Console.WriteLine("number 4 = " + num4);
int num5 = new Random().Next(1, 101);
Console.WriteLine("number 5 = " + num5);
int num6 = new Random().Next(1, 101);
Console.WriteLine("number 6 = " + num6);
int num7 = new Random().Next(1, 101);
Console.WriteLine("number 7 = " + num7);
int num8 = new Random().Next(1, 101);
Console.WriteLine("number 8 = " + num8);
int num9 = new Random().Next(1, 101);
Console.WriteLine("number 9 = " + num9);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (result < arg2)
        result = arg2;
    if (result < arg3)
        result = arg3;
    return result;
}

// int max1 = Max(num1, num2, num3);
// int max2 = Max(num4, num5, num6);
// int max3 = Max(num7, num8, num9);
// int max = Max(max1, max2, max3);

int max = Max(Max(num1, num2, num3), Max(num4, num5, num6), Max(num7, num8, num9));

Console.WriteLine(max);
