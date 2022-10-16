//  8. Показать четные числа от 1 до N
// int n = 12;
// int index = 1;
// while (index<=n){
//     if(index%2 == 0){
//         Console.Write(index + " ");       
//     }
//     index++;
// }

int GetValue()
{
    Console.WriteLine("Введите числа: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

bool IsEven(int index)
{
    if (index % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintEvent(int n)
{
    int index = 1;
    while (index <= n)
    {
        if (IsEven(index))
        {
            Console.Write(index + " ");
        }
        index++;
    }
}

int value = GetValue();
PrintEvent(value);

