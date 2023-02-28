// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


void FillArray(int[] array)
{
  int length = array.Length;
  for(int index = 0; index < length; index++)
  {
    array[index] = new Random().Next(1, 10);
  }
}

void PrintArray(int[] mas)
{
  int len = mas.Length;
  for(int i = 0; i < len; i++)
  {
    Console.Write(mas[i] + " ");
  }
}


int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);