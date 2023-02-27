// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Mult(int number)
{
  int result = 1;
  while(number > 0)
  {
    result = result * number;
    number--;
  }
  return result;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел = {Mult(num)}");