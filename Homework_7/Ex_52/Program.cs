/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

///////////////////////////////////////////////////////////////////

Console.Clear();

int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);

int[,] array = GetArray(rows, columns, 0, 100);

PrintArray(array);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
GetMeanColumn(array);
Console.WriteLine();

/////////////////////////////////////////////////////////////////////////////

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetMeanColumn(int[,] usArray)
{
    for (int j = 0; j < usArray.GetLength(1); j++)
    {
        double sum = 0;
        double mean = 0;
        for (int i = 0; i < usArray.GetLength(0); i++)
        {
            sum = usArray[i, j] + sum;
            mean = Math.Round(sum / usArray.GetLength(0), 1);
        }
        Console.Write($"{mean}");
        if (j < usArray.GetLength(1) - 1) Console.Write("; ");
        else Console.Write(".");
    }
}