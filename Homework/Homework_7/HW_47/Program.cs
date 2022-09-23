// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
System.Console.WriteLine();

double[,] GetTableDouble(int m, int n)
{
    double[,] table = new double[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().NextDouble() * 100;
        }
    }
    return table;
}

void PrintTable(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            System.Console.Write(tab[i, j] + "   ");
        }
        System.Console.WriteLine();
    }
}

int m = 4;
int n = 3;
double[,] TableDouble = GetTableDouble(m, n);
PrintTable(TableDouble); // как тут сократить кол-во цифр после , ?