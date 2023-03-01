//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите два числа. Число первое: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Число второе: ");
int number2 = int.Parse(Console.ReadLine()!);

int num2 = number2;
int num1 = number1;
int num = num1;

int N (int number)
{
  
  for (int i=0; i < num2-1; i++)
  {
    
    num= num*num1;
  }
  return num;
}

Console.WriteLine($"Число {number1} , возведенное в степень {number2}, равно {N(num)}");