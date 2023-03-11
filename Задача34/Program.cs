//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int [] GetArray(int size)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(100, 1000);
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

  foreach(int el in arr)
  {
    if(el % 2 == 0)
    {
      sum += 1;
    }
    
  }
  Console.WriteLine($"Количество четных чисел в массиве = {sum}");
}


int[] array = GetArray(4);
PrintArray(array);
Console.WriteLine();
N(array);