// "Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран"

int N = new Random().Next(2, 50); 
int[] nums = new int[N]; // Так как задача и примеры к ней расходятся в размере массива, то задал размер случайным

for (int indx = 0; indx < nums.Length; indx++)
{
    nums[indx] = new Random().Next(1, 99);
    Console.Write(nums[indx] + ", ");
}
Console.WriteLine($" - массив из {N} элементов"); // <= для эстетики в консоли