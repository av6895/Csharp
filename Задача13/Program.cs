// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number =int.Parse(Console.ReadLine()!);



if (number>99)
{
    while (number > 1000)
    {
      number = number / 10;
    }
    if(number < 1000)
    {
      Console.WriteLine(number%10);
    }

}
else
{
  Console.WriteLine("третьей цифры нет");
}



// ThirdDigit(int number)

// int result = -1;
// if (number >= 100)
// {
//   while (number > 999)
// {
// number = number / 10;
// }
// result = number % 10;
// }
// return result;



// if(number>99)
// {
//   if(number<1000)
//   {
//     Console.WriteLine(number%10);
//   }
//   else
//  {
//     while (number > 10000)
//    {
//       number = number / 10;
//   }

//    //Console.WriteLine(number/10);
//  }
// }
// else
// {
//   Console.WriteLine("Третьей цифры нет");
// }










// int a1 = number % 1000 / 100;
// if(a1 == 0)
// {
//   Console.WriteLine("nhtnmtq wbahs ytn");
// }
// else
// {

//   Console.WriteLine("третья " + a1);
// }






// while(number > 1000)
// {
//   int a1 = number / 10;
//   Console.WriteLine(a1);
  
// }

// break;


// int num1 = number / 1000 % 100;

// if(number <= 99)
// {
//   Console.WriteLine("третьей цифры нет");
// }
// while(number > 1000)
// {
//   number
//   Console.WriteLine(num1);
// }
