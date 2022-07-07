// "Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран"

int N = new Random().Next(2, 50);
int[] nums = new int[N];

for (int indx = 0; indx < nums.Length; indx++)
{
    nums[indx] = new Random().Next(1, 99);
    Console.Write(nums[indx] + ", ");
}
Console.WriteLine($" - массив из {N} элементов"); // <= для эстетики в консоли