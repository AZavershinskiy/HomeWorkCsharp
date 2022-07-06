// "Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве"

int x1 = InputInt("Введите координату X 1-й точки: ");
int y1 = InputInt("Введите координату Y 1-й точки: ");
int z1 = InputInt("Введите координату Z 1-й точки: ");

int x2 = InputInt("Введите координату X 2-й точки: ");
int y2 = InputInt("Введите координату Y 2-й точки: ");
int z2 = InputInt("Введите координату Z 2-й точки: ");

int xx1 = x1 - x2;
int yy1 = y1 - y2;
int zz1 = z1 - z2;

double distance = Math.Sqrt(Quadro(xx1) + Quadro(yy1) + Quadro(zz1));
Console.WriteLine($"{distance} - расстояние между точками");

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Quadro(int num)
{
    return num * num;
}