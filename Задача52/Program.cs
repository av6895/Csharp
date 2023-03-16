// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetArray(int m, int n)
{
  int[,] result = new int[m,n];
  for(int i = 0; i < m; i++)
  {
    for(int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(0, 20);
    }
  }
  return result;
}

void PrintArray(int[,] inArray)
{
   for(int i = 0; i < inArray.GetLength(0); i++)
  {
    for(int j = 0; j < inArray.GetLength(1); j++)
    {
      Console.Write($"{inArray[i, j]} ");
    }
    Console.WriteLine();
  }
}

double[] NewArray(int[,] arr)
{
  double[] result = new double[arr.GetLength(1)];
  
  for(int j = 0; j < arr.GetLength(1); j++)
  {
    double sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    { 
      sum += arr[i, j];
    }
    result[j] = Math.Round(sum / arr.GetLength(0), 2);
  }
  return result;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);
Console.WriteLine();

double[] averageColumns = NewArray(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", averageColumns)}");