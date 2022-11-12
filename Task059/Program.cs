// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

double[,] FillArray(int row, int col)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int collumns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] findSumRows(double[,] array)
{
    int rows = array.GetLength(0);
    int collumns = array.GetLength(1);
    double[] sum = new double[array.GetLength(0)];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns; j++)
        {
            sum[i] += array[i, j];
        }
    }

    return sum;
}

int findRowWithMinSum(double[] sumArray)
{
    int rowWithMinSum = 0;
    for (int i = 0; i < sumArray.Length; i++)
    {
        if (sumArray[rowWithMinSum] > sumArray[i])
            rowWithMinSum = i;
    }
    return rowWithMinSum;
}

double[,] arr = FillArray(4, 2);
PrintArray(arr);
Console.WriteLine();

double[] sum = findSumRows(arr);
for (int i = 0; i < arr.GetLength(0); i++)
{
    Console.WriteLine(Math.Round(sum[i], 2));
}
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {findRowWithMinSum(sum)}");

for (int j = 0; j < arr.GetLength(1); j++)
{
    Console.Write($"{arr[findRowWithMinSum(sum), j]} ");
}
Console.WriteLine();