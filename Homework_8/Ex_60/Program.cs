/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/////////////////////////////////////////////////////////////////////////////

Console.Clear();

Console.Write("Введите количество параметров X: ");
int paramX = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество параметров Y: ");
int paramY = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество параметров Z: ");
int paramZ = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();

double[,,] array = GetArray(paramX, paramY, paramZ);
PrintArray(array);
Console.WriteLine();

/////////////////////////////////////////////////////////////////////////////

double[,,] GetArray(int m, int n, int l)
{
    double[,,] result = new double[m, n, l];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                result[i, j, k] = Convert.ToDouble(rnd.Next(1000, 10000) / 100.0);
            }
        }
    }
    return result;
}

void PrintArray(double[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}