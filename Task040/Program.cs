// 40. В Указанном массиве вещественных чисел 
// найдите разницу между максимальным и минимальным элементом

double[] FillArray(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
    return array;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double[] arr = FillArray(9);
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
Console.WriteLine("");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {FindMax(arr) - FindMin(arr)}");