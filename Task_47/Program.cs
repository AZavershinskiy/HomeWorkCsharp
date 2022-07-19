// "Задайте двумерный массив размером m×n, заполненный случайными вещественными числами"

int m = InputInt("Введите количество строк: ");
int n = InputInt("Введите количество столбцов: ");
double[,] array = new double[m, n];

FillArrayDouble(array);
PrintArray(array);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int forRnd = new Random().Next(10, 100);
            array[i, j] = Convert.ToDouble(forRnd) / 10;
        }
    }
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}