﻿// task21
Console.WriteLine("Введите координату точки A: ");
double xa = Convert.ToDouble (Console.ReadLine());
double ya = Convert.ToDouble (Console.ReadLine());
double za = Convert.ToDouble (Console.ReadLine());
Console.WriteLine("Введите координату точки B: ");
double xb = Convert.ToDouble (Console.ReadLine());
double yb = Convert.ToDouble (Console.ReadLine());
double zb = Convert.ToDouble (Console.ReadLine());

double result = Math.Sqrt ( Math.Pow (xa - xb, 2) + Math.Pow (ya - yb, 2)+ Math.Pow (za -zb, 2));

Console.Write ($"Расстояние между точками: {Math.Round(result, 2)}");
