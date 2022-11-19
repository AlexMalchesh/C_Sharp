// 63. Сформировать трехмерный массив не повторяющимися 
//двузначными числами показать его построчно на экран выводя 
//индексы соответствующего элемента

int[,,] FillArray3D(int n, int m, int l)
{
    int[,,] array = new int[n, m, l];
    int[] arr = new int[n * m * l];

    for (int i = 0; i < n * m * l; i++)
    {
        arr[i] = new Random().Next(10, 31);
        if (i > 0)
        {
            for (int i1 = 0; i1 < i; i1++)
            {
                while (arr[i] == arr[i1])
                {
                    arr[i] = new Random().Next(10, 31);
                    i1 = 0;
                }
            }
        }
    }

    int count = 0;
    int row = array.GetLength(0);
    int colls = array.GetLength(1);
    int coll = array.GetLength(2);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colls; j++)
        {
            for (int k = 0; k < coll; k++)
            {
                array[i, j, k] = arr[count];
                count++;
            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] arr)
{
    int row = arr.GetLength(0);
    int colls = arr.GetLength(1);
    int coll = arr.GetLength(2);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colls; j++)
        {
            for (int k = 0; k < coll; k++)
            {
                Console.WriteLine($"[{i},{j},{k}] = {arr[i, j, k]}");
            }

        }
    }
}

int FillArray(int n)
{
    int[] array = new int[n];
    if (n == 0) return new Random().Next(10, 20);
    else return FillArray(n - 1);
}

int[] GetArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = FillArray(i);
        if (i > 0)
        {
            for (int i1 = 0; i1 < i; i1++)
            {
                while (arr[i] == arr[i1])
                {
                    arr[i] = new Random().Next(10, 20);
                    i1 = 0;
                }
            }
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int[,,] a = FillArray3D(2,2,2);
PrintArray3D(a);

