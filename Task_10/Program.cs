// "Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа"

Console.WriteLine("Введите трехзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 > 99 && num1 < 1000)
{
int num2 = num1 % 100;
    num2 = num2 / 10;
Console.WriteLine($"{num2} - это вторая цифра числа {num1}");
}
else
{
Console.WriteLine($"Это НЕ трехзначное число");
}