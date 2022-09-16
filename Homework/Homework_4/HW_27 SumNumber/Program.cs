// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// РЕШЕНИЕ: 

// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int numberN)
// {
//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;
//     for (int i = 0; i < counter; i++)
//     {
//         advance = numberN - numberN % 10;
//         result = result + (numberN - advance);
//         numberN = numberN / 10;
//     }
//     return result;
// }
// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// РЕШЕНИЕ:

Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0; // 0 - для sum - старт для счетцика!

while (i > 0) // пока введенное число i > 0 будет происходить операция ниже!  
{
int num = i % 10; // остаток при делении получили и записали в num! 351%10=1 35%10=5 3%10=3
i = i / 10; // целочисленный int при делении отбросил последнюю часть! 351/10=35
sum = sum + num; // ЦИКЛ тут к 0 прибавляем остаток от деления !))) и получаем итоговую сумму пока i>0 цикл 1+5+3=9
}
Console.WriteLine("Сумма всех цифр в числе равна: " + sum); // вывод значения на экран!
