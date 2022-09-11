// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Возведения числа в степень ф-ция: Math.Pow() 
// В аргументных скобках через запятую указываются два аргумента (1-ый аргумент - число, которое возводим в степень, 
// 2-ой – степень, в которую возводим число).

// РЕШЕНИЕ №1

// Console.Write("Введите любое число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= num; i++)
// Console.Write($"{Math.Pow(i, 3)}, ");
// Console.WriteLine(" ");

// РЕШЕНИЕ №2 через МЕТОД
// НЕ РАБОТАЕТ через Math.Pow !!!((((

int[] GetCubesNumbers(int numer) // название метода
{
    int[] CubesNumbers = new int[numer];

    for (int i = 1; i <= numer; i++) // заполнение массива результа
    {
        CubesNumbers[i - 1] = i * i * i; // как запустить через Math.Pow(i, 3) ?
    }
    return CubesNumbers;
}
Console.Write("Введите целое число: ");
int num = int.Parse(Console.ReadLine());

int[] result = GetCubesNumbers(num); 
for (int i = 0; i < result.Length; i++) // условие для массива - длинна и начальный элемент
{
    Console.Write($"{result[i]}, "); // как тут убрать последнюю запятую в выводе результата в строке?
}