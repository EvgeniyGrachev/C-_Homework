/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/////////////////////////////////////////////////////////////////////////////

Console.Clear();

Console.Write("Введите количество строк первого массива: ");
int rowsA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов первого массива: ");
int columnsA = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество строк второго массива: ");
int rowsB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов второго массива: ");
int columnsB = int.Parse(Console.ReadLine() ?? "");

int[,] arrayA = GetArray(rowsA, columnsA, 0, 10);
int[,] arrayB = GetArray(rowsB, columnsB, 0, 10);

Console.WriteLine("Первый массив:");
PrintArray(arrayA);

Console.WriteLine("Второй массив:");
PrintArray(arrayB);
Console.WriteLine();

GetMultArray(arrayA, arrayB);

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

void GetMultArray(int[,] arrA, int[,] arrB)
{
    if (arrA.GetLength(1) != arrB.GetLength(0))
    {
        Console.WriteLine("Перемножение не возможно");
    }
    else
    {
        int[,] result = new int[arrA.GetLength(0), arrB.GetLength(1)];
        for (int i = 0; i < arrA.GetLength(0); i++)
        {
            for (int j = 0; j < arrB.GetLength(1); j++)
            {
                for (int k = 0; k < arrB.GetLength(0); k++)
                {
                    result[i, j] += arrA[i, k] * arrB[k, j];
                }
            }
        }
        Console.WriteLine("Результат умножения массивов:");
        PrintArray(result);
    }
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