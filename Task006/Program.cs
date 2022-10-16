//  6. Выяснить является ли число чётным

int GetValue()
{
    Console.WriteLine("Введите числа: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int value = GetValue();

if (value % 2 == 0)
{
    Console.WriteLine("Число " + value + " является четным");
} else {
    Console.WriteLine("Число " + value + " НЕ является четным");
}
