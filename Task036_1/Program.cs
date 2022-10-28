// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

int SumOddPos(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2!=0) sum+=array[i];
    }
    return sum;
}

int[] arr = FillArray(8);
Console.WriteLine(string.Join(' ', arr));

Console.WriteLine();
Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях = {SumOddPos(arr)}");