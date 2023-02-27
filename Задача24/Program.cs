//  Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSumNums(int number)
{
  int sum = 0;
  while(number > 0)
  {
    sum = sum + number;
    number--;
  }
  return sum;
}

Console.Clear();
Console.Write("Введите число 1: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3: ");
int num3 = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
Console.WriteLine($"Сумма цифр = {GetSumNums(num2)}");
Console.WriteLine($"Сумма цифр = {GetSumNums(num3)}");


// int sumOne = GetSumNums(num);
// Console.WriteLine(sumOne);