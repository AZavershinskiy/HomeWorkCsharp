// "Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N"

int m = InputInt("Введите число M: ");
int n = InputInt("Введите число N: ");

Console.WriteLine(AckermanFunction(m, n));

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return AckermanFunction(m - 1, 1);
    }
    else
    {
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}