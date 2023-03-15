// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GetArray(int m, int n)
{
  int[,] result = new int[m,n];
  for(int i = 0; i < m; i++)
  {
    for(int j = 0; j < n; j++)
    {
      result[i, j] = new Random().Next(0, 10);
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
  int sum = 0;
   for(int i = 0; i < arr.GetLength(0); i++)
  {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      
      if(i == j)
      {
        sum += arr[i, j];
      }
     
    }
  }
  Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);
Console.WriteLine();
NewArray(array);
