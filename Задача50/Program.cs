// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// [1,7] -> по данным индексам такого числа в массиве нет

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

void SearchArray(int[,] arr)
{
  Console.Write("Введите искомый индекс строки: ");
  int m = int.Parse(Console.ReadLine()!);

  Console.Write("Введите искомый индекс столбца: ");
  int n = int.Parse(Console.ReadLine()!);
  
  bool flag = false;
  for(int i = 0; i < arr.GetLength(0); i++)
  {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      if(m == i && n == j)
      {
        flag = true;
        Console.WriteLine($"По данным индексам находится число {arr[i,j]}");
      } 
    }
  }
  if(flag)
    {
      Console.WriteLine();
    }
    else
    {
      Console.WriteLine("По данным индексам числа в массиве нет");
    }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);
Console.WriteLine();
SearchArray(array);