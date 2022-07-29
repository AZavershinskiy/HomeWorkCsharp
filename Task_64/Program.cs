// "Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N"

int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

Console.WriteLine(NaturalNumbers(m, n));

int NaturalNumbers(int m, int n)
{
    if (m < n)
    {
        Console.Write(NaturalNumbers(m, n - 1) + ", ");
        return n;
    }
    else
    {
        if (n == m)
            return m;
        else
            Console.Write(NaturalNumbers(m, n + 1) + ", ");
        return n;
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}