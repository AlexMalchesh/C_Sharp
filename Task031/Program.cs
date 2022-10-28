// Задача 31/29: Напишите метод, который задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}

// for (int i = 0; i < n; i++)
// {
//     if (i == 0)
//     {
//         Console.Write($"[{array[i]} ,");
//     }
//     else if (i == n - 1)
//     {
//         Console.Write($"{array[i]}]");
//     }
//     else
//     {
//         Console.Write($"{array[i]} ,");
//     }
// }

int[] array = FillArray(8);

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");

}