// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

void FillArray(int[] massiv)
{
  for (int i = 0; i < massiv.Length; i++)
  {
    Random rnd = new Random();
    massiv[i] = rnd.Next(1, 100);
  }
}

void PrintArray(int[] massiv)
{
  for (int i = 0; i < massiv.Length; i++)
  {
    Console.WriteLine($"[{i}] = {massiv[i]}");
  }
  Console.WriteLine();
}


int[] GetArray(int[] massiv)
{
  int length = massiv.Length;            // Старый массив
  int[] massiv1 = new int[length];       // Новый массив

  for (int i = 0; i < length; i++)
  {
    massiv1[i] = massiv[i];
  }
  return massiv1;
}

void DeepCopy()
{
  int[] massiv = new int[10];
  FillArray(massiv);                              // Заполнение массива
  System.Console.WriteLine("\nНаш массив:");
  PrintArray(massiv);                             // Вывод массива
  
  int[] newMassiv = GetArray(massiv);
  System.Console.WriteLine("\nНовый массив:");
  PrintArray(newMassiv);                          // Вывод массива
}

DeepCopy();