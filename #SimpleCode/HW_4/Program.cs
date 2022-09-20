// СУММА И КОЛИЧЕСТВО ЧЕТНЫХ И НЕЧЕТНЫХ ЧИСЕЛ В ДИАПАЗОНЕ | C# ДОМАШНИЕ ЗАДАНИЯ | #4

uint oddNumbers = 0; // нечетные числа
uint evenNumbers = 0; // четные числа

int oddNumbersSum = 0; // нечетные числа результат сложения
int evenNumbersSum = 0; // четные числа результат сложения

//предел чисел
Console.WriteLine("Введите начало диапазона");
int currentValue = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конец диапазона");
int limit = int.Parse(Console.ReadLine());

while (currentValue <= limit)
{
    if (currentValue % 2 == 0)
    {
        evenNumbers++;
        evenNumbersSum += currentValue; //сокращенная форма
    }
    else
    {
        oddNumbersSum = oddNumbersSum + currentValue; //полная форма
        oddNumbers++;
    }
    currentValue++;
}

Console.WriteLine("Количество нечетных чисел:" + oddNumbers);
Console.WriteLine("Количество четных чисел:" + evenNumbers);

Console.WriteLine("Сумма нечетных чисел:" + oddNumbersSum);
Console.WriteLine("Сумма четных чисел:" + evenNumbersSum);

Console.ReadLine();