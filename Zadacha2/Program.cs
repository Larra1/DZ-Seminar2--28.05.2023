﻿// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает , что третьей цифры нет

// 645 -> 5
// 78 -> третьей цифры нет

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());

 if (A>-1000 &&  A<-99 || A>99 && A<1000)
{
// if (A>-1000 &&  A<-99)
// {
     int B =Math.Abs(A%10);
          Console.WriteLine($"Третья цифра в этом числе {B}");
// }
// else if (A>99 && A<1000)
// {
//     int B = A%10;
//     Console.WriteLine($"Третья цифра в этом числе {B}");
// }
}
else
{
    Console.WriteLine("Извините, но третьей цифры нет, попробуйте перезапустить компьютер");
}
