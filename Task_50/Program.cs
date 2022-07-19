// "Напишите программу, которая на вход принимает позиции элемента в двумерном массиве 
// и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9"

int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);

string text = InputInt("Введите позицию искомого элемента в данном двумерном массиве: ");
int size = text.Length;
int position = Convert.ToInt32(text);
int row = position / 10;
int column = position % 10;

if (size != 2) Console.WriteLine("ОШИБКА! Позиция элемента должна состоять из двухзначного числа!");
else if (row <= m && column <= n)
{
    Console.WriteLine($"{array[row, column]} - значение элемента на позиции {row}{column}");
}
else Console.WriteLine("Такой позиции в массиве нет");

string InputInt(string output)
{
    Console.Write(output);
    return Console.ReadLine();
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
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
