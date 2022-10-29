// 22. Найти расстояние между точками в пространстве 2D/3D

double GetX(int i)
{
    Console.Write($"Введите координату X точки {i}: ");
    return Convert.ToDouble(Console.ReadLine());
}

double GetY(int i)
{
    Console.Write($"Введите координату Y точки {i}: ");
    return Convert.ToDouble(Console.ReadLine());
}
double GetZ(int i)
{
    Console.Write($"Введите координату Z точки {i}: ");
    return Convert.ToDouble(Console.ReadLine());
}

// double GetDist2D(double x1, double y1, double x2, double y2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
// }

double GetDist3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}

// double ax = GetX(1);
// double ay = GetY(1);
// double bx = GetX(2);
// double by = GetY(2);

// double res = GetDist2D(ax, ay, bx, by);

// Console.WriteLine($"Растояние между точкой ({ax} , {ay})  и ({bx} ,{by}) = {res}");


double ax = GetX(1);
double ay = GetY(1);
double az = GetZ(1);
double bx = GetY(2);
double by = GetX(2);
double bz = GetZ(2);

double res = GetDist3D(ax, ay, az, bx, by, bz);

Console.WriteLine($"Растояние между точкой ({ax} , {ay} , {az})  и ({bx} , {by} , {bz}) = {res}");

