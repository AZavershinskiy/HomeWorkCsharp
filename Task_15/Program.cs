// "Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным"

Console.WriteLine("Введите номер дня недели: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numN > 0 && numN < 6)
{
    Console.WriteLine($"Номер {numN} - это РАБОЧИЙ день");
}
else if (numN > 5 && numN < 8)
{
    Console.WriteLine($"Номер {numN} - это ВЫХОДНОЙ день");
}
else { Console.WriteLine($"В неделе только 7 дней"); }
