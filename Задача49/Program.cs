//  Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void NewArray(int[,] arr)
{
   for(int i = 0; i < arr.GetLength(0); i++)
  {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      if(i % 2 == 0 && j % 2 == 0)
      {
        arr[i, j] *= arr[i, j];
      }
    }
  }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);
Console.WriteLine();
NewArray(array);
PrintArray(array);