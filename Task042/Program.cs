// 42. Определить сколько чисел больше 0 введено с клавиатуры

string[] UserInputNums()
{
    Console.WriteLine("Введите чисела через запятую: ");
    return Console.ReadLine()!.Split(",");
}

int CountPositiveNums(string[] array)
{
    int length = array.Length;
    int[] nums = new int[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        nums[i] = Convert.ToInt32(array[i]);
        if (nums[i] > 0) count++;
    }
    return count;
}

string[] arr = UserInputNums();

Console.WriteLine($"Количество чисел > 0, введенных с клавиатуры = {CountPositiveNums(arr)}");