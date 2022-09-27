// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int GetDegreeNumber (int n, int d)
{
    if (d == 1)
    {
        return n;
    }

    int result = n * GetDegreeNumber(n, d - 1);
    return result;
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите степень для числа {n}: ");
int d = Convert.ToInt32(Console.ReadLine());

int resultDegree = GetDegreeNumber(n, d);
Console.WriteLine($"Число {n} в степени {d} равно {resultDegree}.");
