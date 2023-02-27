// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int N (int number)
{
  int i = 0;
  while(number > 0)
  {
    number = number / 10;
    i++;
  }
  return i;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе: {N(number)}");