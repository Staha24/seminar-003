﻿// task19
Console.Write (" Введите пятизначное число: ");
int n = Convert.ToInt32 (Console.ReadLine ());

if (n / 10000 == n % 10 && ( n / 1000) % 10 == (n /10 % 10))
    Console.WriteLine ("да");
else
    Console.WriteLine ("нет");
