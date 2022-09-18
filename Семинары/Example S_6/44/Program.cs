// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int [] GetFibonacci (int size)
{
    int [] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        if (i == 0)
        {
            array[i] = 0;
        }
        else if (i == 1 || i == 2)
        {
            array[i] = 1;
        }
        else
        {
            array[i] = array [i - 2] + array [i - 1];
        }
    }
        return array;
}

Console.WriteLine("Input number");
int size = Convert.ToInt32(Console.ReadLine());

int [] fibonacci = GetFibonacci(size);

Console.WriteLine("[{0}]", string.Join(", ", fibonacci));