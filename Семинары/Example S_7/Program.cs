// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int n = 0;

// int m = 0;

// Console.WriteLine("Введите кол-во срок (N): ");
// bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN); //спарсить в намберс
// if (!parseNIsOk)
// {
//     Console.WriteLine("Введено значение некорректного формата (N)");
//     return;
// }
// else
// {
//     n = numberN;
// }
// Console.WriteLine("Введите кол-во столбцов (M): ");
// bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM); //спарсить в намберс
// if (!parseMIsOk)
// {
//     Console.WriteLine("Введено значение некорректного формата (M)");
//     return;
// }
// else
// {
//     m = numberM;
// }

// int[,] array = new int[n, m];

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         Console.WriteLine($"{i}, {j}");
//     }
// }
// Console.ReadKey();



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int n = 0; // количество строк
// int m = 0; // количество столбцов

// Console.WriteLine("Введите количество строк (N): ");
// n = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите количество строк (M): ");
// m = Convert.ToInt32 (Console.ReadLine());


// void GetArray(int n, int m)
// {
//     int [,] array = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             array [i, j] = i + j;
//         }
//     }

//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             Console.Write($"{array [i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// GetArray(n, m);


// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// int n = 0; // количество строк
// int m = 0; // количество столбцов

// Console.WriteLine("Введите количество строк (N): ");
// n = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine("Введите количество строк (M): ");
// m = Convert.ToInt32 (Console.ReadLine());

// int [,] array = new int[n, m];

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         array [i, j] = new Random().Next(1, 10);
//     }
// }

// for (int i = 0; i < n; i++) // выводим исходный массив
//     {
//         for (int j = 0; j < m; j++)
//         {
//             Console.Write($"{array [i, j]} ");
//         }
//         Console.WriteLine();
//     }
// Console.WriteLine();   

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             array [i, j] *= array [i, j]; 
//         }
//     }
// }

// for (int i = 0; i < n; i++) // выводим измененный массив
//     {
//         for (int j = 0; j < m; j++)
//         {
//             Console.Write($"{array [i, j]} ");
//         }
//         Console.WriteLine();
//     }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
