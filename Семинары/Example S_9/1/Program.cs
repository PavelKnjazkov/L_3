// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N (+ их сумму).
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int GetSumNembers (int n)
{
    if (n == 0)
    {
        return 0;
    }

    int sum = n + GetSumNembers(n - 1);
    return sum;
}


string ShowNumbersToN (int n)
{
    if (n == 1)
    {
        return "1";
    }
    string result = ShowNumbersToN(n - 1) + " " + n;
    return result;
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

string resultString = ShowNumbersToN(n);
Console.WriteLine($"Числа от 1 до {n}: {resultString}");

int result = GetSumNembers(n);
Console.WriteLine($"Сумма всех чисел от 1 до {n} = {result}");
