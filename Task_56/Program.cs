// "Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов"

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
FindMinSumRow(array);
Console.WriteLine(FindMinSumRow(array) + " - номер строки с наименьшей суммой элементов");

int FindMinSumRow(int[,] array)
{
    int minSumRow = int.MaxValue;
    int minRowIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            minRowIndex = i;
        }
    }
    return minRowIndex + 1;
}
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}