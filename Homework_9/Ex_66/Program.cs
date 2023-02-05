/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/////////////////////////////////////////////////////////////

Console.Clear();

Console.Write("Введите первое целое положительное число: ");
int oneNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое положительное число: ");
int twoNumber = int.Parse(Console.ReadLine() ?? "");

int sum = GetSumNumbers(oneNumber, twoNumber);
Console.WriteLine($"{oneNumber} - {twoNumber} -> {sum}");

/////////////////////////////////////////////////////////////

int GetSumNumbers(int m, int n)
{
    int sum = m;
    if (n == m) return sum;
    else
    { 
        sum = sum + GetSumNumbers(m + 1, n); 
    }
    return sum;
}