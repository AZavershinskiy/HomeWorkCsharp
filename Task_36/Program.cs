// "Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях"

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
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

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) { sum += array[i]; }
}

Console.Write(" - получившийся массив");
Console.WriteLine();
Console.WriteLine($"{sum} - сумма чисел на нечётных позициях");