//  Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void ReversArray(int[,] arr)
{
  int temp = 0;
  for(int j = 0; j < arr.GetLength(1); j++)
  {
    temp = arr[0, j];
    arr[0, j] = arr[arr.GetLength(0)-1, j];
    arr[arr.GetLength(0)-1, j] = temp;
  }
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);
Console.WriteLine();

ReversArray(array);
PrintArray(array);