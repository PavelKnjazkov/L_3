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


// Вторая программа из 1 лекции ДЕЛЕНИЕ но вещественные числа

// double numberA = 28;
// double numberB = 46;
// double result = numberA / numberB;
// Console.WriteLine(result);


//Третья программа из 1 лекции

// int numberA = new Random().Next(1,10); // 123...9
// Console.WriteLine (numberA);
// int numberB = new Random().Next(1,10);
// Console.WriteLine (numberB);
// Console.WriteLine(numberA + numberB);


//Четвертая программа из 1 лекции ИМЯ

Console.Write ("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username == "Маша")
{
    Console.WriteLine("Ура Маша!))");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}