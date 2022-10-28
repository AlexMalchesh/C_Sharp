// Возведите число А в натуральную степень B используя цикл

// int[] GetNums()
// {
//     int[] arr = new int[2];
//     for (int i = 0; i < 2; i++)
//     {
//         Console.WriteLine("Введите целое число: ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// int[] arr = GetNums();

// int result = 1;
// if (arr[1] == 0)
// {
//     result = 1;
// }
// if (arr[1] > 0)
// {
//     for (int i = 1; i <= arr[1]; i++)
//     {
//         result = result * arr[0];
//     }
// }
// Console.WriteLine($"Число {arr[0]} в степени {arr[1]} = {result}");

int GetA()
{
    Console.WriteLine("Введите целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int GetB()
{
    Console.WriteLine("Введите целое число - степень: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Degree(int a, int n)
{
    int result = 1;
    if (n == 0) result = 1;
    if (n > 0)
    {
        for (int i = 0; i < n; i++)
        {
            result = result * a;
        }
    }
    return result;
}

int a = GetA();
int n = GetB();

Console.WriteLine($"Число {a} в степени {n} = {Degree(a, n)}");