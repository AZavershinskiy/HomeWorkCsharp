// "Задайте двумерный массив. Напишите программу, которая упорядочит по УБЫВАНИЮ элементы каждой строки двумерного массива"

int m = InputInt("Введите колличество строк: ");
int n = InputInt("Введите колличество столбцов: ");
int[,] array = new int[m, n];

FillArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
SortRowsArray(array);
Console.WriteLine("Отсортированные строки массива по убыванию:");
PrintArray(array);

void SortRowsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int t = 0; t < array.GetLength(1); t++)
            {
                if (array[i, j] > array[i, t])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, t];
                    array[i, t] = temp;
                }
            }
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
}