//  2. Даны два числа. Показать большее и меньшее число
int a = 4;
int b = 1;
int max = a;
int min = a;

if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("Максимальное их 2-х чисел = " + max);
Console.WriteLine("Минимальное их 2-х чисел = " + min);