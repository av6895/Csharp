// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] GetArray(int size)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(1, 1000);
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

void FindSum(int[] array)
{
  int sum = 0;

  foreach(int el in array)
  {
    if(100 > el)
    {
      sum += 1;
    }
    if(el < 10)
    {
      sum -= 1;
    }
  }
  Console.WriteLine($"Количество элементов = {sum}");
}

int[] array = GetArray(123);
PrintArray(array);
Console.WriteLine();
FindSum(array);




// //решение группы:

// int[] GetArray(int size, int minValue, int maxValue)
// {
//   int[] res = new int[size];
//   for (int i = 0; i < size; i++)
//   {
//     res[i] = new Random().Next(minValue, maxValue + 1);
//   }
//   return res;
// }

// void PrintArray(int[] inArray)
// {
//   for (int i = 0; i < inArray.Length; i++)
//   {
//    Console.Write($"{inArray[i]} ");
//   }
// }

// void FindSumIndex(int[] inArray)
// {
//   int summindex = 0;
//   for (int i = 0; i < inArray.Length; i++)
//   {

//     if (inArray[i] >= 10 && inArray[i] <= 99)
//     {
//      summindex++;
//     }
//   }
//   System.Console.WriteLine($"Сумма элементов = " + summindex);
// }

// System.Console.WriteLine("Введите минимальное и максимальное значение массива: ");
// int minindex = int.Parse(Console.ReadLine());
// int maxindex = int.Parse(Console.ReadLine());
// int[] array = GetArray(10, minindex, maxindex);
// PrintArray(array);
// System.Console.WriteLine();
// FindSumIndex(array);