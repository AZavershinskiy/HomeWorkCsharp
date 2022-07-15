// "Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве"

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int size = InputInt("Задайте размер массива: ");
int[] array = new int[size];

FillArray(array);
PrintArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) {count++;}
}

Console.Write(" - получившийся массив");
Console.WriteLine();
Console.WriteLine($"{count} - количество четных чисел в массиве");