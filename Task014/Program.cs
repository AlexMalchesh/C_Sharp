// 14. Найти третью цифру числа или сообщить, что её нет

// char GetTherdNumLeft(int value)
// {
//     return value.ToString()[2];
// }

int GetValue()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int GetTherdNum(int value)
{
    return (value / 100) % 10;
}

int value = GetValue();

if (value < 0)
{
    value = Math.Abs(value);
}
if (value > 99)
{
    Console.WriteLine($"Третья цифра числа = {GetTherdNum(value)}");
}
else
{
    Console.WriteLine($"Третья цифра числа отсутствует");
}
