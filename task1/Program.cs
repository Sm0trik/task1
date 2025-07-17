using System;
using System.Linq;
using System.Runtime.InteropServices;

double min = 10000;
double max = 10001;
int length = 1000;

static double GetRundomNumber(double min, double max)
{
    Random rnd = new Random();
    double rnb_number = rnd.Next(0, 10001) / 10000.0;
    rnb_number = rnd.Next(0, 10001) / 10000.0;
    return (rnb_number);
}

double[] numbers = new double[length];

for (int i = 0; i < length; i++)
{
    numbers[i] = GetRundomNumber(min, max);
}

Console.WriteLine("Array of random numbers: ");
for (int i = 0; i < length; i++)
{
    Console.WriteLine(numbers[i] + " ");
}

Console.WriteLine($"Min number: {numbers.Min()}");
Console.WriteLine($"Max number: {numbers.Max()}");
Console.WriteLine($"Average value:  {numbers.Sum()/length}");
