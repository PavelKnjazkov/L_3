// Задача 40: 
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


string CheckTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && c + b > a)
    {
        return ("Треугольник существует");
    }
    else
    {
        return ("Треугольник не существует");
    }
}
System.Console.WriteLine("Input a");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input b");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input c");
int c = Convert.ToInt32(Console.ReadLine());