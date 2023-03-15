// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci() 
{
  Console.Write("Введите длину массива: ");
  int length = Convert.ToInt32(Console.ReadLine());

  int[] array = new int[length];  //фиксируем длину массива
  array[0] = 0;
  array[1] = 1;
 
  for (int i = 2; i < length; i++)
  {
    array[i] = array[i - 2] + array[i - 1];
  }
  Console.WriteLine(string.Join(" ", array));
}
Fibonacci();