// 24. Найти кубы чисел от 1 до N

int GetN()
{
    Console.Write("Введите целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Cube(int n)
{
    return n * n * n;
}

int n = GetN();

for (int i=1;i<=n;i++){
    Console.WriteLine($"{i}^3 = {Cube(i)}");
}