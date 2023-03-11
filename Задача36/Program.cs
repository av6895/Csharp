// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] GetArray(int size)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(-100, 101);
  }
  return res;
}

void PrintArray(int[] inArray)
{
  for (int i = 0; i < inArray.Length; i++)
  {
    Console.Write($"{inArray[i]} ");
  }
}

void N(int[] arr)
{
  int sum = 0;
  for(int i = 1; i < arr.Length; i++)
  {
    if( i % 2 == 1)
    {
      sum += arr[i];
    }
  }
  Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");
}


int[] array = GetArray(4);
PrintArray(array);
Console.WriteLine();
N(array);