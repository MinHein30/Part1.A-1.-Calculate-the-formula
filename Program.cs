// See https://aka.ms/new-console-template for more information
using System;

Console.Write("Enter the value of n: ");
int n = int.Parse(Console.ReadLine());

double S1 = CalculateS1(n);
double S2 = CalculateS2(n);
double S5 = CalculateS5(n);
double S6 = CalculateS6(n);
double S7 = CalculateS7(n);

Console.WriteLine($"S1: {S1}");
Console.WriteLine($"S2: {S2}");
Console.WriteLine($"S5: {S5}");
Console.WriteLine($"S6: {S6}");
Console.WriteLine($"S7: {S7}");


double CalculateS1(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-1, i + 1) / SumOfSquares(i);
    }
    return sum;
}

double CalculateS2(int n)
{
    double sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-2, i) / Factorial(i);
    }
    return sum;
}

double CalculateS5(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-1, i + 1) / (2 * i);
    }
    return sum;
}

double CalculateS6(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-1, i + 1) / SumOfNaturalNumbers(i);
    }
    return sum;
}

double CalculateS7(int n)
{
    double sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(2, i) / Factorial(i);
    }
    return sum;
}

double SumOfSquares(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i * i;
    }
    return sum;
}

double SumOfNaturalNumbers(int n)
{
    return n * (n + 1) / 2.0;
}

double Factorial(int n)
{
    double fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }
    return fact;
}