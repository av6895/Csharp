// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);               // 12821
int num = 0;
int temp = number;

while (temp > 0)                                           //number > 0
{
  num = num * 10 + temp % 10;                              // num = 0*10 + number % 10  =0+1=1      num = 1*10+2=12   num=12*10+12=132   num=132*10+1=1321  num=  ??????
  temp = temp / 10;                                        // number = 1282                         number=128        number=12          number=1
}

if (number == num)
{
  Console.WriteLine("Число палиндром");
}
else
{
  Console.WriteLine("Число не палиндром");
}








//рассмотрели вариант решения из другой группы


// int Prompt(string message)
// {
//   Console.Write(message);
//   string value = Console.ReadLine();
//   int number = Convert.ToInt32(value);
//   return number;
// }

// int ReverseNumber(int a)
// {
//   int revNum = 0;
//   int temp = a;                        //12321
//   while (temp > 0)
//   {
//     revNum = revNum * 10 + temp % 10;  //0+1 //10+2=12 //120+3=123 // 1230+2 // 12320 +1 // 12321
//     temp /= 10;                        //            1232      123         12         1          0

//   }
// return revNum;
// }

// int a = Prompt("Введите 5-и значное число: ");
// int reversed = ReverseNumber(a);

// if (a > 9999 && a < 1000000)
// {
//   if (reversed == a)
//   {
//     Console.WriteLine("Число является палиндромом.");
//   }
//   else
//   {
//   Console.WriteLine("Число НЕ является палиндромом.");
//   }
// }

