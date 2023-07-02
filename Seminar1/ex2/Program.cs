// task 3. Напишите программу которая будет выдавать название дня недели по заданному числу

Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine()!);

// if (num == 1)
//     Console.Write("Monday");
// if (num == 2)
//     Console.Write("Tuesday");
// if (num == 3)
//     Console.Write("Wednesday");
// if (num == 4)
//     Console.Write("Thursday");
// if (num == 5)
//     Console.Write("Friday");
// if (num == 6)
//     Console.Write("Saturday");
// if (num == 7)
//     Console.Write("Sunday");
// if (num > 7)
//     Console.Write("There is no such day of the week");



if (num == 1)
    Console.Write("Monday");
else if (num == 2)
    Console.Write("Tuesday");
else if (num == 3)
    Console.Write("Wednesday");
else if (num == 4)
    Console.Write("Thursday");
else if (num == 5)
    Console.Write("Friday");
else if (num == 6)
    Console.Write("Saturday");
else
    Console.Write("no week day");
