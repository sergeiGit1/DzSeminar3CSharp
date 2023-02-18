﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine("Введите координату точки А по оси X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А по оси Z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));

Console.WriteLine(Math.Round(result, 2));