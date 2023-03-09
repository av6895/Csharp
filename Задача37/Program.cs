// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int [] GetArray(int size)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(1, 10);
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

int[] NewArray(int[] arr)
{
  int[] mult = new int [arr.Length / 2];
  
  for(int i = 0; i < arr.Length/2; i++)
  {
    mult[i] = arr[i] * arr[arr.Length - 1 - i];
  }
  return mult;
}


int[] array = GetArray(6);
PrintArray(array);
Console.WriteLine();
int[] multArr = NewArray(array);
PrintArray(multArr);