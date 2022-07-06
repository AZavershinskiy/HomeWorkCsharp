// "Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом"

int digit = InputInt("Введите пятизначное число: ");

if (digit > 10000 && digit < 100000)
{
    int num1 = digit / 10000;
    int num2 = digit / 1000 % 10;
    int num4 = digit % 100 / 10;
    int num5 = digit % 10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    {
        Console.WriteLine("Данное число НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Это НЕ пятизначное число");
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}