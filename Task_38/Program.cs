// "Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива"

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
void FillArrayDouble(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int forRnd1 = new Random().Next(-99, 100);
        array[i] = Convert.ToDouble(forRnd1) / 10;
    }
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
}

int size = InputInt("Задайте размер массива: ");
double[] array = new double[size];

FillArrayDouble(array);
PrintArray(array);

double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i]) { max = array[i]; }
    else if (min > array[i]) { min = array[i]; }
}
double diff = max - min;

Console.Write(" - получившийся массив");
Console.WriteLine();
Console.WriteLine($"{max} -  МАКСимальный  элемент массива");
Console.WriteLine($"{min} -  МИНимальный  элемент массива");
Console.WriteLine($"{diff} -  разница между максимальным и минимальным элементами массива");