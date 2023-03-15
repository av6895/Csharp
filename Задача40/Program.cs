//  Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void GetTriangle(int a, int b, int c)
{
  if (a > 0 && b > 0 && c > 0)
  {
    if (a < b + c && b < a + c && c < a + b)
    {
      System.Console.WriteLine("Да");
    }
    else
    {
     System.Console.WriteLine("нет");
    }
  }
}

System.Console.WriteLine("Введите стороны треугольника: ");
int num1 = int.Parse(System.Console.ReadLine());
int num2 = int.Parse(System.Console.ReadLine());
int num3 = int.Parse(System.Console.ReadLine());
GetTriangle(num1, num2, num3);