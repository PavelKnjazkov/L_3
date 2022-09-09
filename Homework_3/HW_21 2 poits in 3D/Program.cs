// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Подход: формула для расстояния между двумя точками в 3-х измерениях, 
// т.е. (x1, y1, z1) и (x2, y2, z2) была получена из теоремы Пифагора, которая такова:
// Расстояние = $ \ sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} $ 


Console.WriteLine("Enter coordinates point А: ");
Console.WriteLine("Enter x: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates point B: ");
Console.WriteLine("Enter x: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter z: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double Decision = Math.Sqrt (Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
Console.WriteLine($"Длина отрезка  {Decision}");

