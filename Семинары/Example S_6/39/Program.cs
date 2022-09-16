// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int [] GetReversArray1(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }

    return result;
}

int[] array = new int[] {1, 2, 3, 4, 5};
int[] result = GetReversArray1(array);

Console.ReadKey();