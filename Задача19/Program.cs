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










// Console.WriteLine("Введите пятизначное число: ");
// int N = int.Parse(Console.ReadLine()!);

// int N1 = 0;
// // while(N > 0)
// // {
// //   N1 = N1* 10 + N % 10;
// //   N /= 10;
// // }

// // if( N=N1)
// // {
// //   Console.WriteLine("да");
// // }
// // else
// // {
// //   Console.WriteLine("нет");
// // }

