// "Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)"

Console.WriteLine("Введите любое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 2 == 0)
{
    Console.WriteLine($"Число {num1} является четным");
}
else
{
    Console.WriteLine($"Число {num1} НЕ является четным");
}