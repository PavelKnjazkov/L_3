//       !!!  ДОМАШНЯЯ РАБОТА  !!!

// Урок 1. Знакомство с языком программирования С#

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//РЕШЕНИЕ:

// первый вариант с произвольным числом от 1 до 1000

// Console.WriteLine ("Сейчас я загадаю два числа и покажу тебе какое из них будет или больше, или меньше!:))");
// int numberA = new Random().Next(1,100); // 123... 1000
// Console.WriteLine ("Моим первым число будет: " + numberA);
// int numberB = new Random().Next(1,100); // 123... 1000
// Console.WriteLine ("А на второе я выбрал: " + numberB);
// int max = numberA;
// int min = numberB;
// if (numberA > max ) max = numberA;
// if (numberB > max ) max = numberB;
// if (numberA < min ) min = numberA;
// if (numberB < min ) min = numberB;
// Console.WriteLine ("Большим будет - " + max);
// Console.WriteLine ("Ну а поменьше - " + min);
// Console.WriteLine ("А тебе так слабо!?");

// второй вариант, где ввод чисел производит пользователь:

// int a, b;
// Console.WriteLine("А сейчас мы определим какое из двух чисел больше!");
// Console.WriteLine("Для этого введите первое число: ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("И ещЁ одно число: ");
// b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
// Console.WriteLine("{0} - наибольшее число!", a);
// Console.WriteLine("{0} - наименьшее число!", b);
// }
// else
// {
// Console.WriteLine("{0} - наибольшее число!", b);
// Console.WriteLine("{0} - наименьшее число!", a);
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// РЕШЕНИЕ:

// int a, b, c;

// Console.WriteLine("На этот раз мы определим какое из трех чисел больше!");
// Console.Write("Для этого введите первое число: ");
// a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Теперь второе число: ");
// b = Convert.ToInt32(Console.ReadLine());
// Console.Write("И наконец третье число: ");
// c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;

// Console.WriteLine("А вот и все наши числа: " + a + ", "  + b + ", " + c + ", " + "где большим будет: " + max);
// Console.WriteLine("Ура!!!");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да 1 до N.

// -3 -> нет
// 7 -> нет

// РЕШЕНИЕ:

// int x;

// Console.WriteLine("А сейчас мы определим является ли число четным!");
// Console.WriteLine("Для этого введите любое число: ");
// x = Convert.ToInt32(Console.ReadLine());

// if (x % 2 == 0) //тут вопрос какая разница с (x % 2 == 1)
// {
// Console.WriteLine(x + " четное число");
// }
// else
// {
// Console.WriteLine(x + " нечетное число!");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

//РЕШЕНИЕ:

int x = new Random().Next(1, 10); // 123... 10
Console.WriteLine("А сейчас я сам загадаю число!");
Console.WriteLine("И определю чет или нечет :)");

if (x % 2 == 0) //тут вопрос какая разница с (x % 2 == 1)
{
Console.WriteLine(x + " четное число");
}
else
{
Console.WriteLine(x + " нечетное число!");
}
 x += 2;
 Console.Write(x);
