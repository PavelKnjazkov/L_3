﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// РЕШЕНИЕ:
// сохраняем число в переменной num
// num сохраняем в переменной t, чтобы проверить его, когда исходное число было перевернуто
// делаем реверс числа
// сравнил равно ли исходное число с его реверсом t==sum

int num, r, sum = 0, t;
Console.WriteLine("Привет, попробуй введи пятизначное число! Посмотрим, вдруг это палиндром!?))");
num = Convert.ToInt32(Console.ReadLine());
for (t = num; num != 0; num = num / 10)
{
    r = num % 10; // я не понимаю данную операцию(
    sum = sum * 10 + r; // и эту тоже( где про них почитать?
}
if (t == sum)
    Console.Write("{0} - вот молодец! Да это ОН!!!", t);
else
    Console.Write("{0} - ну вот, попробуй ещё раз!", t);

// Если слова!?

// Console.WriteLine("Привет, попробуй введи слово! Посмотрим, вдруг это палиндром!?))");
// string str = Console.ReadLine(); // Вводим строку
// string reverseStr = ""; // здесь будет наша перевернутая строка
// for(int i = str.Length-1; i>=0 ;i--) // условие для i - что в данном случае i?
// {
// reverseStr+=str[i]; // переворачиваем строку
// }
// if (str==reverseStr)
// Console.WriteLine("Введенная строка является палиндромом.");
// else
// Console.WriteLine("Введенная строка не является палиндромом.");