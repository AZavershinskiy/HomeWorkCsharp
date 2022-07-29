﻿// "Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N"

int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

Console.WriteLine(SumNaturalNumbers(m, n));

int SumNaturalNumbers(int m, int n)
{
    if (m < n)
    {
        int sum = m;
        sum += SumNaturalNumbers(++m, n);
        return sum;
    }
    else
    {
        if (n == m)
            return m;
        else
        {
            int sum = n;
            sum += SumNaturalNumbers(m, ++n);
            return sum;
        }
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}