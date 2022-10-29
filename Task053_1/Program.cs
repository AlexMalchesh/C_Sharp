// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
    return array;
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

string GetUserNumber()
{
    Console.WriteLine("Введите позицию элемента в двумерном массиве: ");
    return Console.ReadLine();
}

bool CorrectUserNum(string num)
{
    return num.Length == 2;
}

int[] GetPosition(int number)
{
    int[] pos = new int[2];
    pos[1] = number % 10;
    pos[0] = number / 10;
    return pos;
}

int GetNumByPosition(int[,] array, int[] posUser)
{
    int num = -1;
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == posUser[0] && j == posUser[1])
            {
                num = array[i, j];
            }
        }
    }
    return num;
}


int[,] arr = FillArray(3, 5);

PrintArray(arr);

string userNum = GetUserNumber();
int posNum = 0;
if (CorrectUserNum(userNum))
{
    posNum = Convert.ToInt32(userNum);

    int[] position = GetPosition(posNum);

    int num = GetNumByPosition(arr, position);

    if (num == -1)
        Console.WriteLine($"Числа на позиции [{position[0]}, {position[1]}] НЕТ в массиве.");
    else
        Console.WriteLine($"Число на позиции [{position[0]}, {position[1]}] = {num}.");

}
else
    Console.WriteLine("Введены неподходящие данные для позиции масива");
