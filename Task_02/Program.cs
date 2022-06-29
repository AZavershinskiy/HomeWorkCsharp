// "Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее"

Console.WriteLine("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} БОЛЬШЕ числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} МЕНЬШЕ числа {num2}");
}
else
{
    Console.WriteLine($"Число {num1} РАВНО числу {num2}");
}