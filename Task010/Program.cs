// 10. Показать вторую цифру трёхзначного числа

// int value = 475;

// int result = (value / 10) % 10;

// Console.WriteLine(result);

int GetValue()
{
    Console.WriteLine("Введите трехзначное число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetSecondNum(int value)
{
    return (value / 10) % 10;
}

void PrintResult(int res)
{
    Console.WriteLine("Вторая цифра числа = " + res);
}

int value = GetValue();
int result = GetSecondNum(value);
PrintResult(result);