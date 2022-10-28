// 44. Найти точку пересечения двух прямых заданных уравнением 
// y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine($"Программа поиска координат точки пересечения двух прямых");

double GetNumber(string index)
{
    Console.Write($"Введите коэффициент уравнения {index}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double[] FindCrossPoint(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k1 * point[0] + b1;
    return point;
}

double b1 = GetNumber("b1");
double k1 = GetNumber("k1");
double b2 = GetNumber("b2");
double k2 = GetNumber("k2");

if (k1 == k2 && b1 != b2)
{
    Console.WriteLine("Прямые параллельны!");
}
else if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают!");
}
else if (k1 != k2)
{
    double[] point = FindCrossPoint(b1, k1, b2, k2);
    Console.WriteLine($"Точка пересечения прямых,заданных уравнением \ny = k1 * x + b1, y = k2 * x + b2 \nx = {point[0]}, y = {point[1]}");
}