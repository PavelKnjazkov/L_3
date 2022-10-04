// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N (+ их сумму).
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
/*
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
*/
/*
Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

///Метод вывода натуральных чисел от N до 1:
void NumberCounter (int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter (number - 1);
}

NumberCounter(number);
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(number, count);


void NaturalToLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
    }
}