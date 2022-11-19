// 63. Сформировать трехмерный массив не повторяющимися 
//двузначными числами показать его построчно на экран выводя 
//индексы соответствующего элемента

int FillArray3D(int n)
{
    if (n == 0) return 10;
    else return 10 + n;

}

int[,,] GetArray3D(int n, int m, int l)
{
    int length = n * m * l;
    int[] arr = new int[length];
    int[] arrMix = new int[length];
    int[,,] array = new int[n, m, l];
    int row = array.GetLength(0);
    int colls = array.GetLength(1);
    int coll = array.GetLength(2);
    int count = 0;
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        arr[i] = FillArray3D(i);
    }
 
    // mix
    for (int i = 0; i < length; i++)
    {   
        index = new Random().Next(0,length);
        while(arr[index]==-1)
        {
            index = new Random().Next(0,length);
        }
        arrMix[i] = arr[index];
        arr[index] = -1;
    }  

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < colls; j++)
        {
            for (int k = 0; k < coll; k++)
            {
                array[i, j, k] = arrMix[count];
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


int[,,] a = new int[2, 2, 2];

int n = a.GetLength(0);
int m = a.GetLength(1);
int l = a.GetLength(2);
if (n * m * l > 89)
    Console.WriteLine("Размерность массива задана не верно!");
else
{
    a = GetArray3D(n, m, l);
    PrintArray3D(a);
}



