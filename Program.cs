using System;
Console.WriteLine("please enter the number smallest");
double n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please enter the number largest");
double n2 = double.Parse(Console.ReadLine());

for (double i = n1; i <= n2; i++)
{
    double sum = 0;
    for (double y = 1; y < i; y++)
    {
        if (i % y == 0)
            sum += y;
    }
    if (sum == i)
        Console.WriteLine(i);
}
