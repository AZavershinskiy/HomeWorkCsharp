// "Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента"

int x = InputInt("Введите размер высоты массива: ");
int y = InputInt("Введите размер ширины массива: ");
int z = InputInt("Введите размер глубины массива: ");

int[,,] threeDimArray = new int[x, y, z];

Fill3DArray(threeDimArray);
Console.WriteLine("3D массив с индексами элементов:");
Print3DArray(threeDimArray);

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void Fill3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                int maxNum = array[0, 0, 0];
                for (int x = 0; x < array.GetLength(0); x++)
                {
                    for (int y = 0; y < array.GetLength(1); y++)
                    {
                        for (int z = 0; z < array.GetLength(2); z++)
                        {
                            if (array[x, y, z] > maxNum)
                            {
                                maxNum = array[x, y, z];
                                for (int d = 0; d < array.GetLength(0); d++)
                                {
                                    for (int e = 0; e < array.GetLength(1); e++)
                                    {
                                        for (int f = 0; f < array.GetLength(2); f++)
                                        {
                                            for (int a = d + 1; a < array.GetLength(0); a++)
                                            {
                                                for (int b = e + 1; b < array.GetLength(1); b++)
                                                {
                                                    for (int c = f + 1; c < array.GetLength(2); c++)
                                                    {
                                                        if (array[d, e, f] == array[a, b, c])
                                                        {
                                                            ++maxNum;
                                                            array[a, b, c] = maxNum;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}