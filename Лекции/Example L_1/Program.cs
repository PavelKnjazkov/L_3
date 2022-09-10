// Знакомство с языками программирования ЛЕКЦИ, решения ПРОГРАММ из 1-ой лекции.

// Первая программа из 1 лекции СЛОЖЕНИЕ ЧИСЕЛ

// int numberA = 28;
// int numberB = 49;
// Console.WriteLine(numberA + numberB);


// Она же но через result

// int numberA = 28;
// int numberB = 49;
// int result = numberA + numberB;
// Console.WriteLine(result);


// Вторая программа из 1 лекции ДЕЛЕНИЕ

// int numberA = 28;
// int numberB = 4;
// int result = numberA / numberB;
// Console.WriteLine(result);


// Вторая программа из 1 лекции ДЕЛЕНИЕ но вещественные числа (double)

// double numberA = 28;
// double numberB = 46;
// double result = numberA / numberB;
// Console.WriteLine(result);


//Третья программа из 1 лекции - сложение двух случайных чисел

// int numberA = new Random().Next(1,10); // 123...9
// Console.WriteLine (numberA);
// int numberB = new Random().Next(1,10);
// Console.WriteLine (numberB);
// Console.WriteLine(numberA + numberB);


//Четвертая программа из 1 лекции МАША IF - ELSE

// Console.Write ("Введите имя пользователя: ");
// string username = Console.ReadLine();
// if(username == "Маша")
// {
//     Console.WriteLine("Ура Маша!))");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }


// Она же но с ToLower

// Console.Write ("Введите имя пользователя: ");
// string username = Console.ReadLine();
// if(username.ToLower() == "маша")
// {
//     Console.WriteLine("Ура МАША!))");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }


// 5/6-ая программа - приер с гирями (найти наибольшее число)

// int a = 1;
// int b = 2;
// int c = 3;
// int d = 4;
// int e = 5;

// int max = a;

// if (a > max ) max = a;
// if (b > max ) max = b;
// if (c > max ) max = c;
// if (d > max ) max = d;
// if (e > max ) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);

// 7-ая программа - Magic
//Запоминаем команды: 
Console.Clear();

Console.SetCursorPosition(10, 4);
Console.WriteLine("+");

int xa = 40, ya = 1,
xb = 1, yb = 30,
xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;

while (count < 10000)

{
    int what = new Random().Next(0, 3); // 1 2 3
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // или count +=1; или count++;
}

//        !!!END!!!