// "Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц"

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
int[,] arrayFirst = new int[m, n];
int[,] arraySecond = new int[m, n];
int[,] arrayProduct = new int[m, n];

FillArray(arrayFirst);
Console.WriteLine("Исходный массив №1:");
PrintArray(arrayFirst);

FillArray(arraySecond);
Console.WriteLine("Исходный массив №2:");
PrintArray(arraySecond);

FillArray(arrayProduct);
ProductArrays(arrayFirst, arraySecond, arrayProduct);
Console.WriteLine("Массив произведений элементов от первых двух массивов:");
PrintArray(arrayProduct);

void ProductArrays(int[,] arrayFirst, int[,] arraySecond, int[,] arrayProduct)
{
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFirst.GetLength(1); j++)
        {
            arrayProduct[i, j] = arrayFirst[i, j] * arraySecond[i, j];
        }
    }
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