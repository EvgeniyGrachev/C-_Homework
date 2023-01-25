/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

////////////////////////////////////////////////////////////////////////////

Console.Clear();

int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);

int[,] array = GetArray(rows, columns, 0, 100);

Console.Write("Введите индекс строки элемента массива: ");
int iUser = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите индекс столбца элемента массива: ");
int jUser = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintCompareIndex(array);

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

void PrintCompareIndex(int[,] usArray)
{
    if (iUser > usArray.GetLength(0) - 1 || jUser > usArray.GetLength(1) - 1)
    {
        Console.WriteLine($"[{iUser}, {jUser}] -> данного элемента нет в массиве");
    }
    else Console.WriteLine($"[{iUser}, {jUser}] -> индекс элемента {usArray[iUser, jUser]}");
}