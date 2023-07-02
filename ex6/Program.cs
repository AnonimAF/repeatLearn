Console.Write("Enter the weight of the first kettlebell: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the weight of the second kettlebell: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the weight of the third kettlebell: ");
int num3 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the weight of the fourth kettlebell: ");
int num4 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the weight of the fifth kettlebell: ");
int num5 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the weight of the sixth kettlebell: ");
int num6 = int.Parse(Console.ReadLine()!);

int max = num;

if (max < num2)
    max = num2;
if (max < num3)
    max = num3;
if (max < num4)
    max = num4;
if (max < num5)
    max = num5;
if (max < num6)
    max = num6;

Console.Write("The heaviest weigth is equal to: " + max);
