// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Math.Sqrt() - корень

// AB = √(xb - xa)2 + (yb - ya)2

Console.Write("Введите координаты точки А: x = ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки А: y = ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки В: x = ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки B: y = ");
int Y2 = int.Parse(Console.ReadLine()!);


int X = (X2 - X1)*(X2 - X1);
int Y = (Y2 - Y1)*(Y2 - Y1);
int n = X + Y;

double AB = Math.Sqrt(n);

Console.Write(Math.Round (AB, 2));        //Math.Round - округление после запятой до указанного количества цифр, чтоб убрать длинный хвост