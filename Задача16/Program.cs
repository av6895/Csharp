// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет 

Console.WriteLine("Введите первое число: ");
int numberA =int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB =int.Parse(Console.ReadLine()!);

if(numberA * numberA == numberB || numberB * numberB == numberA)
{
  Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}