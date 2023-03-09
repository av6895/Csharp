// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int [] GetArray(int size)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(-10, 11);
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

void ReversArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
  {
    array[i] *= -1;
  }
}

int[] array = GetArray(4);
PrintArray(array);
Console.WriteLine();
ReversArray(array);
PrintArray(array);