// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] myArr = new int[4, 4];

Random ran = new Random();

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i, j] = ran.Next(-5, 5);
        Console.Write(myArr[i, j] + " ");
    }
    Console.WriteLine();
}

int max = myArr[0, 0];
int min = myArr[0, 0];
for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        if (myArr[i, j] > max) max = myArr[i, j];
    }
}
Console.WriteLine(max);

for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        if (myArr[i, j] < min) min = myArr[i, j];
    }
}
Console.WriteLine(min);




int[] myArrX = new int[max-min+1];

for (int a = 0; a < (max-min+1); a++)
{
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            if (myArr[i, j] == (a+min)) myArrX[a] = myArrX[a] + 1;
        }
    }
}

for (int i = 0; i < (max-min+1); i++)
{
    if (myArrX[i] != 0)
    {
        Console.WriteLine($"Элемент {i+min} встречается {myArrX[i]} раз");
    }

}
Console.WriteLine();