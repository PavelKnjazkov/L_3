// Знакомство с языками программирования (семинары), решения на 2-ом семинаре


    // 1-ая задача со 2-го семинара (мы в группе решили иначе)

// void NewTask ()
// {
// int num = new Random().Next (100, 1000);

// int res =  num/100;
// int res1 = num%10;

// Console.WriteLine(num);
// Console.WriteLine($"{res}{res1}");
// }

// NewTask ();


    // 2-ая задача со 2-го семинара (мы в группе решили иначе)

// void numbers(int num1, int num2)
// {
//     if (num1 % num2 == 0) Console.WriteLine("Первое число кратно второму");
//     else Console.WriteLine($"Первое число не кратно второму, остаток {num1 % num2}");

// }

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// numbers(num1, num2);
// Console.WriteLine();


    // 3-я задача со 2-го семинара

// void Compare ()
// {
// int number = int.Parse(Console.ReadLine());
// if (number % 7 == 0 | number % 14 == 0) 
// {
// Console.WriteLine("да");
// }
// else Console.WriteLine("нет");
// }
// Compare();

    // она же но по другому

// void Num (int number)
// {
//     if (number % 7 == 0 & number % 23 == 0)
//     {
//         Console.WriteLine($"Число {number} кратно 7 и 23");
//     }
//     else 
//     {
//         Console.WriteLine($"Число {number} НЕ кратно 7 и 23");
//     }
// }


    // 4ая задача со 2-го семинара

// int number1 = int.Parse(Console.ReadLine());
// int number2 = int.Parse(Console.ReadLine());
// if (number2*number2 == number1) 
// {   
//     Console.Write(number1);
//     Console.Write(number2);
//     Console.Write("второе - квадрат первого");
// }
// else if (number1*number1 == number2) 
// {
//     Console.Write("первое - квадрат второго");
// }
// else 
// {
//     Console.Write("нет");
// }

//она же но по другому

// void Square (int num1, int num2)
// {
//     if (num1*num1 == num2) Console.WriteLine ($"Число {num2} является квадратом числа {num1} ");
//     else if (num2*num2 == num1) Console.WriteLine ($"Число {num1} является квадратом числа {num2} ");
//     else Console.WriteLine ($"Числа {num1} и {num2} не являются квадратами друг друга ");
// }

// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());

// Square (num1, num2);
