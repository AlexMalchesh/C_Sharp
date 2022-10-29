// 61. Найти произведение двух матриц

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 4);
        }
    }
    return array;
}

int[,] MultArray(int[,] ar1, int[,] ar2)
{
    int[,] res = new int[ar1.GetLength(0), ar2.GetLength(1)];

    for (int i = 0; i < ar1.GetLength(0); i++)
    {
        for (int j = 0; j < ar2.GetLength(1); j++)
        {
            for (int k = 0; k < ar2.GetLength(0); k++)
            {
                res[i, j] += ar1[i, k] * ar2[k, j];
            }
        }
    }
    return res;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ar1 = FillArray(3, 2);
int[,] ar2 = FillArray(2, 4);

PrintArray(ar1);
Console.WriteLine();
PrintArray(ar2);
Console.WriteLine();
if (ar1.GetLength(0) != ar2.GetLength(1))
{
    Console.Write("Матрицы нельзя перемножить, количество строк первого массива равно колличеству столбцов второго");
}
else
{
    PrintArray(MultArray(ar1, ar2));
}
