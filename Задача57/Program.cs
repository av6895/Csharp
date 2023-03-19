/* Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных 

1,2,3
4,6,1
2,1,6

1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/

// int[,] GetArray(int m, int n)
// {
//   int[,] result = new int[m,n];
//   for(int i = 0; i < m; i++)
//   {
//     for(int j = 0; j < n; j++)
//     {
//       result[i, j] = new Random().Next(0, 10);
//     }
//   }
//   return result;
// }

// void PrintArray(int[,] inArray)
// {
//    for(int i = 0; i < inArray.GetLength(0); i++)
//   {
//     for(int j = 0; j < inArray.GetLength(1); j++)
//     {
//       Console.Write($"{inArray[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// void NewArray(int[,] arr)
// {
  
//   int sum = 0;
//   for(int j = 0; j < arr.GetLength(1); j++)
//   {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     { 
//       if(arr[i,j] == arr[i,j]) sum += 1;
//       else Console.WriteLine($"{arr[i,j]} = {sum}");
//     }
    
//   }
  
// }
// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(rows, columns);

// PrintArray(array);
// Console.WriteLine();

// NewArray(array);



/*
Задача 59. Задайте двумерный массив из целых чисел.Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
например задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7


Задача 61. Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника */