// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

string GetToInt2 (int number)
{
    string result = null;
    while(number > 0)
    {
        result = result + (number % 2).ToString (); // метод перевода р-та в строку
        number = number / 2;
    }
    for (int i = 0; i < result.Length; i++)
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());