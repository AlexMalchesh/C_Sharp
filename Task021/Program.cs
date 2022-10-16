// 21. Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Программа проверяет пятизначное число на палиндромом");

int GetNum()
{
    Console.Write("Введите целое пятизначное число: ");
    //return Convert.ToInt32(Console.ReadLine());
    return Convert.ToInt32(Console.ReadLine());
}

int a = GetNum();
int temp = a;
int b = 0;
int n = 5;
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    arr[i] = temp % 10;
    temp = temp / 10;
}

for (int i = 0; i < n; i++)
{
    b = b * 10 + arr[i];
}

if (a == b)
    Console.WriteLine($"Число {a} - полиндром");
else Console.WriteLine($"Число {a} НЕ полиндром");