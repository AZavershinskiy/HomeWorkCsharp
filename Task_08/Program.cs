﻿// "Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N"

Console.WriteLine("Введите любое число: ");
int numN = Convert.ToInt32(Console.ReadLine());

int min = 2;

while (min < numN)
{
    Console.Write(min + ", ");
    min = min + 2;
}

// Комментарий: 

//Число "1" - нечетное - выводиться не будет. Последнее число также не будет выводиться, т. к. в задаче требуется показать ДО нужного