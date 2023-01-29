/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

/////////////////////////////////////////////////////////////////////////////

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetSpiralArray(rows, columns);
PrintArray(array);

/////////////////////////////////////////////////////////////////////////////

int[,] GetSpiralArray(int n, int m)
{
    int[,] result = new int[n, m];
    int row = 0;
    int column = 0;
    int paramX = 1;
    int paramY = 0;
    int change = 0;
    int set = m;
    for (int i = 0; i < result.Length; i++)
    {
        result[row, column] = i + 1;
        if (--set == 0)
        {
            set = m * (change % 2) + n * ((change + 1) % 2) - (change / 2 - 1) - 2;
            int temp = paramX;
            paramX = -paramY;
            paramY = temp;
            change++;
        }
        column += paramX;
        row += paramY;
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] < 10) Console.Write($"0{inArray[i, j]} ");
            else Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}