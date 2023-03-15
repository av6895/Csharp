//  Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// 1 метод. изменяет массив безвозвратно
int [] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for(int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue);
  }
  return res;
}

void ReverseArray1(int[] inArray)
{
  for(int i = 0; i < inArray.Length/2; i++)
  {
    int k = inArray[i];
    inArray[i] = inArray[inArray.Length - 1 - i];
    inArray[inArray.Length - 1 - i] = k;
  }
}


//2 метод который перезаписывает,сохраняется изначальный массив
int[] ReverseArray2(int[] inArray)
{
  int[] result = new int[inArray.Length];
  for(int i = 0; i < inArray.Length; i++)
  {
    result[i] = inArray[inArray.Length - 1 - i];
  }
  return result;
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine(string.Join(" ", array));        //работает только с одномерными массивами
// ReverseArray1(array);        //1метод
int[] reverseArray = ReverseArray2(array);
// Console.WriteLine(string.Join(" ", array));  //1 метод
Console.WriteLine(string.Join(" ", reverseArray));