// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// РЕШЕНИЕ 1 не через метод)))
// Почему далее ругается и выводит только через double.Parse!?

// int x = 3;
// int stepen = 5;
// Console.WriteLine("3^5 = " + Math.Pow(x, stepen));

// РЕШЕНИЕ 2 МЕТОД ЧЕРЕЗ MATH

double Exponentiation(double numberA, double numberB) // название метода: возведение в степень - exponentiation
{
    double result = Math.Pow(numberA, numberB); // мат формула возведения в степень
    return result;
}
// ввод числа и степени пользователем и считывание их в переменные duoble = double.Parse
Console.Write("Введите число которое хотите возвести в степень: ");
double numberA = double.Parse(Console.ReadLine());
Console.Write("Введите степень для возведения вашего числа: ");
double numberB = double.Parse(Console.ReadLine());

//  тут я не понимаю что тут происходит и зачем result - как сюда попадают данные из result!!!
double exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Вот результат введения вашего числа в обозначенную степень: " + exponentiation);

// РЕШЕНИЕ ЦИКЛОМ

// int Exponentiation(int numberA, int numberB)
// {
//     int result = 1;
//     for (int i = 1; i <= numberB; i++)
//     {
//         result = result * numberA;
//     }
//     return result;
// }
// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation(numberA, numberB);
// Console.WriteLine("Ответ: " + exponentiation);