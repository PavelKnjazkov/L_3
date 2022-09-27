// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N (+ их сумму).
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int GetSumNumbers (int m, int n)
{
    if (n == m)
    {
        return m;
    }

    int sum = n + GetSumNumbers(m, n - 1);
    return sum;
}


string ShowNumbersToN (int m, int n)
{
    if (n == m)
    {
        return $"{m}";
    }
    string result = ShowNumbersToN(m, n - 1) + " " + n;

    return result;
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

string resultString = ShowNumbersToN(n, m);
Console.WriteLine($"Числа от {n} до {m}: {resultString}");

int result = GetSumNumbers(n, m);
Console.WriteLine($"Сумма всех чисел от {n} до {m} = {result}");
