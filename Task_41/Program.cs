// "Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь"


string numsString = InputString("Введите несколько чисел через запятую: ");
int[] nums = ParseArray(numsString, ',');

PrintArray(nums);

int count = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > 0) count++;
}
Console.WriteLine($"{count} - количество чисел больше 0");

int[] ParseArray(string input, char separator)
{
    int[] nums = new int[GetCountNumsInString(input)];
    string subString = "";
    int numsIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == separator)
        {
            nums[numsIndex++] = Convert.ToInt32(subString);
            subString = "";
        }
        else subString += input[i];
    }
    nums[numsIndex] = Convert.ToInt32(subString);
    return nums;
}
int GetCountNumsInString(string nums)
{
    int countNums = 1;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == ',')
            countNums++;
    }
    return countNums;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(" - получившийся массив");
    Console.WriteLine();
}
string InputString(string output)
{
    Console.Write(output);
    return Console.ReadLine();
}