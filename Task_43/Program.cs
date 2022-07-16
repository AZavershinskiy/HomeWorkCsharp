// "Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем"

double k1 = InputInt("Введите значение k1: ");
double b1 = InputInt("Введите значение b1: ");
double k2 = InputInt("Введите значение k2: ");
double b2 = InputInt("Введите значение b2: ");

if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Координаты точки пересечения прямых: x({x}), y({y})");

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
double InputInt(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}