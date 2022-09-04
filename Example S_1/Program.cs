//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

//РЕШЕНИЕ:

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

//получение квадрата входного числа
int result = number * number; 
Console.WriteLine($"Квадрат числа {number} = {result}");

//получение квадрата входного числа математической функцией
int result_2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {result_2}");