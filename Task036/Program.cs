// 36. Задать массив, заполнить случайными положительными 
// трёхзначными числами. 
// Показать количество нечетных\четных чисел

int[] FillArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

int[] CountNum(int[] array)
{
    int[] nums = { 0, 0 };
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            nums[0]++;
        else
            nums[1]++;
    }

    return nums;
}

int[] ar = FillArray(11);

for (int i = 0; i < ar.Length; i++)
{
    Console.Write($"{ar[i]} ");
}

Console.WriteLine();

int[] nums = CountNum(ar);

Console.WriteLine($"Число четных чисел в массиве = {nums[0]}");
Console.WriteLine($"Число НЕчетных чисел в массиве = {nums[1]}");