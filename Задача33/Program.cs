// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



void PrintArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

void N(int[] arr, int num)
{
  bool flag = false;
  for(int i = 0; i < arr.Length; i++)
  {
    
      if(arr[i] == num)
      {
        flag = true;
      }
  }
    if(flag)
    {
      Console.WriteLine("Да");
    }
    else
    {
      Console.WriteLine("Нет");
    }
  
}


int[] arr = {6, 7, 19, 345, 3};

PrintArray(arr);
Console.WriteLine();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
N(arr, num);





//решение группы


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
//     Console.Write($"{inArray[i]} ");
//   }
// }

// void FindIndex(int[] inArray, int index)
// {
//   bool flag = false;
//   for (int i = 0; i < inArray.Length; i++)
//   {
//     if (inArray[i] == index)
//     {
//       flag = true;
//     }
//   }

//   if (flag)
//   {
//     System.Console.WriteLine("Да");
//   }
//   else
//   {
//     System.Console.WriteLine("Нет");
//   }
// }

// int[] array = GetArray(12, -9, 9);
// PrintArray(array);
// System.Console.WriteLine();
// System.Console.Write("Введите число: ");
// int num = int.Parse(System.Console.ReadLine());
// FindIndex(array, num);