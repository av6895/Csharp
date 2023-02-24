// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите координаты точки А: x = ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки А: y = ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки А: z = ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки В: x = ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки B: y = ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки А: z = ");
int Z2 = int.Parse(Console.ReadLine()!);

int X = (X2 - X1)*(X2 - X1);
int Y = (Y2 - Y1)*(Y2 - Y1);
int Z = (Z2 - Z1)*(Z2 - Z1);
int n = X + Y + Z;

double AB = Math.Sqrt(n);

Console.Write(Math.Round (AB, 2));