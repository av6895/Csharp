// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
  double[] res = new double[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().NextDouble();
  }
  return res;
}

void PrintArray(double[] inArray)
{
  for (int i = 0; i < inArray.Length; i++)
  {
    Console.Write($"{inArray[i]} ");
  }
}

void N(double[] arr)
{
  Console.WriteLine("Минимальный элемент массива = " + arr.Min());
  Console.WriteLine("Максимальный элемент массива = " + arr.Max());
  double diff = arr.Max() - arr.Min();
  Console.WriteLine("Разница между ними = " + diff);
}



double[] array = GetArray(5);
PrintArray(array);
Console.WriteLine();
N(array);