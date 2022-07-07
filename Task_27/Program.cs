// "Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе"

int numN = InputInt("Введите нужное число: ");
int digit = numN;
int sum = 0;

while (digit > 0)
{
    sum += digit % 10;
    digit = digit / 10;
}
Console.WriteLine($"{sum} = сумма цифр числа {numN}");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}