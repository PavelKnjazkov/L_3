// Знакомство с языками программирования (семинары), решения на 4-ом семинаре


// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int GetSum(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// Console.Write("Input A: ");
// int a = int.Parse(Console.ReadLine());
// int sum = GetSum(a);
// Console.WriteLine(sum);

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int Count(int number)
// {
//     number = Math.Abs(number);
//     int count = 0;
//     while (number > 0)
//     {
//         count++;
//         number /= 10;
//     }
//     return count;
// }

// Console.Write("Введите целое число: ");
// int num = int.Parse(Console.ReadLine());

// int result = Count(num);
// Console.WriteLine(result);
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int GetMult(int number)
// {
//     int mult = 1;
//     for (int i = 1; i <= number; i++)
//     {
//         mult = mult * i; //mult*=i
//     }
//     if (number < 0)
//     {
//         for (int i = -1; i >= number; i--)
//         {
//             mult *= i; // mult = mult * i
//         }
//     }
//     return mult;
// }
// Console.Write("Input A: ");
// int a = int.Parse(Console.ReadLine());
// int mult = GetMult(a);
// Console.WriteLine(mult);
