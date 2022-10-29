// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] AvSum(int[,] arr)
{
    double[] res = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        res[j] = Math.Round(sum / arr.GetLength(0),2);
    }
    return res;
}

int[,] array = FillArray(3, 4);
PrintArray(array);
double[] res = AvSum(array);

Console.WriteLine();
Console.WriteLine("Cреднее арифметическое каждого из столбцов:");
for (int i = 0; i < res.Length; i++)
{    
    Console.Write($"{res[i]}\t");
}