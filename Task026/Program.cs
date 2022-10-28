// Возведите число А в натуральную степень B используя цикл

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