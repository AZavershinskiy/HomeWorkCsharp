// "Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B"

int numA = new Random().Next(1, 9);
int numB = new Random().Next(1, 9);

int res = numA;

for (int count = 1; count < numB; count++)
{
    res *= numA;
}
Console.WriteLine($"{res} = {numA} в степени {numB}");