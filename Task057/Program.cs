// 57. Написать программу, 
// упорядочивания по убыванию элементы каждой строки двумерной массива.

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
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] SortedArray(double[,] array)
{
    int rows = array.GetLength(0);
    int collumns = array.GetLength(1);
    double temp=0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collumns-1; j++)
        {
            for(int k=j+1; k<collumns;k++)
            {
                if(array[i,j]<array[i,k])
                {
                temp = array[i,j];
                array[i,j] = array[i,k];
                array[i,k] = temp;     
                }
               
            }
        }
    }
    return array;
}

double[,] arr = FillArray(5,3);
PrintArray(arr);
Console.WriteLine();
double[,] sortedArr = SortedArray(arr);
PrintArray(sortedArr);