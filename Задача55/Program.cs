// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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

int[,] ReversArray(int[,] arr)
{
  int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
  for(int i = 0; i < arr.GetLength(0); i++)
  {
    for(int j = 0; j < arr.GetLength(1); j++)
    {
      newArr[j, i] = arr[i,j];
    }
  }
  return newArr;
}

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);

PrintArray(array);
Console.WriteLine();

int[,] reversArray = ReversArray(array);
PrintArray(reversArray);