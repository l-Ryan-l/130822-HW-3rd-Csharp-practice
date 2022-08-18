// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double GetDistance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = 1;
    double dx = x2 - x1;
    double dy = y2 - y1;
    double dz = z2 - z1;
    distance = Math.Sqrt(Math.Pow(dx,2) + Math.Pow(dy,2) + Math.Pow(dz,2));
    return distance;
}

Console.WriteLine("Введите координату x1: ");
double x1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z1: ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату x2: ");
double x2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z2: ");
double z2 = double.Parse(Console.ReadLine()!);

double distance = GetDistance (x1, y1, z1, x2, y2, z2); 
Console.WriteLine($"{distance:f2}"); 