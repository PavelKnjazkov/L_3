// Знакомство с языками программирования (семинары), решения на 3-ем семинаре
// Определение четверти точки

// int GetPointArea(int x, int y)
// {
//     if (x > 0 && y > 0) {
//         return 1;
//     }

//     if (x < 0 && y > 0) {
//         return 2;
//     }

//     if (x < 0 && y < 0) {
//         return 3;
//     }

//     if (x > 0 && y < 0) {
//         return 4;
//     }

//     return 0;
// }

// Console.WriteLine("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int areaNum = GetPointArea(x, y);
// Console.WriteLine ("Area = {areaNum}");

//Задача 8:
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y)

// void GetPointArea(int area)
// {
//     if (area == 1) Console.WriteLine("X > 0 and Y > 0");
//     if (area == 2) Console.WriteLine("X < 0 and Y > 0");
//     if (area == 3) Console.WriteLine("X < 0 and Y < 0");
//     if (area == 4) Console.WriteLine("X > 0 and Y < 0");
// }

// Console.Write ("Input Area: ");
// int area = Convert.ToInt32(Console.ReadLine());
// GetPointArea(area);

// другой вариант
// String GetNumberQuarter(int n)
// {
//     if (n==1) return "х>0, Y>0";
//     if (n==2) return "х>0, Y<0";
//     if (n==3) return "х<0, Y<0";
//     if (n==4) return "х<0, Y>0";
//     return "не номер четверти";
// }
// Console.WriteLine("введите четверть");
// int quarter = Convert.ToInt32( Console.ReadLine() );
// Console.WriteLine (GetNumberQuarter(quarter));

// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Enter coordinates point А: ");
Console.WriteLine("Enter x: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y: ");
int Ay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter coordinates point B: ");
Console.WriteLine("Enter x: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter y: ");
int By = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow(Ax - Bx, 2) + Math.Pow(Bx - By, 2)));
Console.WriteLine(distance);

