// "Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N"

int N = InputInt("Введите нужное число: ");

int min = 1;

while (min <= N)
{
    int tbl = Cubed(min);
    Console.Write(tbl + " ");
    min++;
}

int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

int Cubed(int num)
{
    return num * num * num;
}