// 69. Найти сумму элементов от M до N, N и M заданы

int GetUserNum(String text)
{
    Console.WriteLine($"Введите целое положительное число {text}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int NaturNums(int n)
{
    if (n == 1) return 1;
    else return NaturNums(n - 1) + 1;
}

int SumNums(int n, int m)
{
    int sum = 0;
    for (int i = n; i <= m; i++)
    {
        sum+=NaturNums(i);
    }
    return sum;
}

Console.WriteLine("Программа выводит сумму чисел от M до N, N и M задаются пользователем");

int n = GetUserNum("N");
int m = GetUserNum("M");

Console.WriteLine($"Сумма чисел от {n} до {m} = {SumNums(n,m)}");