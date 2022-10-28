// 27. Определить количество цифр в числе

int GetNum()
{
    Console.Write("Введите целое число: ");
    return Convert.ToInt32(Console.ReadLine());
}

// double GetNum2()
// {
//     Console.Write("Введите целое число: ");
//     return Convert.ToDouble(Console.ReadLine());
// }

int num = Math.Abs(GetNum());

int count = 0;
while (num != 0)
{
   
    num = num /10; 
    ++count;
}

Console.WriteLine($"количество цифр в числе = {count}");
