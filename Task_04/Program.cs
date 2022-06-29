// "Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел"

Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNum = num1;

if (maxNum < num2)
{
    maxNum = num2;
    if (maxNum < num3)
    {
        maxNum = num3;
    }
}
Console.WriteLine($"Максимальное число: {maxNum}");
