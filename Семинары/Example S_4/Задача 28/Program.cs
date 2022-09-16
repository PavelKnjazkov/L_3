// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetFactorial(int number)
{
    // Результат произведения
    int mult = 1;
    if (number > 0)
    {
        // Перебор всех чисел от 1 до number
        for (int i = 1; i <= number; i++)
        {
            // Произведение 
            mult = mult * i;
        }
    }
    else
    {
        mult = 0;
    }

    return mult;
}

Console.Write("Imput N: ");
int n = int.Parse(Console.ReadLine());

int factorial = GetFactorial(n);
Console.WriteLine($"{n}! = {factorial}");