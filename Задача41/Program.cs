// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3        ????? 4 ведь а не 3

void NewArray(string[] args)
{
  Console.Write("Введите количество элементов массива: ");
  int elementsCount = int.Parse(Console.ReadLine());

  int[] myArray = new int[elementsCount];
  
  for(int i = 0; i < myArray.Length; i++)
  {
    Console.Write($"Введите элемент массива под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine());
  }

  Console.WriteLine("Вывод массива: ");
  for(int i = 0; i < myArray.Length; i++)
  {
    Console.Write(myArray[i] + " ");
  }
  
  Console.WriteLine();
  int res = 0;
  for(int i = 0; i < myArray.Length; i++)
  {
    if(myArray[i] > 0) res +=1; 
  }
  Console.Write($"Вы ввели количество чисел больше 0: {res}");
}

NewArray(args);