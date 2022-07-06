// "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве"

Console.WriteLine("Введите координату X 1-й точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y 1-й точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z 1-й точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X 2-й точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y 2-й точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z 2-й точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

int xx1 = x1 - x2;
int yy1 = y1 - y2;
int zz1 = z1 - z2;

double distance = Math.Sqrt(xx1 * xx1 + yy1 * yy1 + zz1 *zz1);
Console.WriteLine($"{distance} - расстояние между точками");