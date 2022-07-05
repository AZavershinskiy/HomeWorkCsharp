// "Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом"

Console.WriteLine("Введите пятизначное число: ");
int digit = Convert.ToInt32(Console.ReadLine());
int num1 = 0;
int num2 = 0;
int num4 = 0;
int num5 = 0;

if (digit > 10000 && digit < 100000)
{
    num1 = digit / 10000;
    num2 = digit / 1000 % 10;
    num4 = digit % 100 / 10;
    num5 = digit % 10;
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