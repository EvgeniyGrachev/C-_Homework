/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/////////////////////////////////////////////////////////////

Console.Clear();

Console.Write("Введите первое целое неотрицательное число: ");
int oneNumber = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе целое неотрицательное число: ");
int twoNumber = int.Parse(Console.ReadLine() ?? "");

int fAkkerman = GetAkkerman(oneNumber, twoNumber);
Console.WriteLine($"{oneNumber} - {twoNumber} -> {fAkkerman}");

/////////////////////////////////////////////////////////////

int GetAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return GetAkkerman(m - 1, 1);
    }
    else
    {
        return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    }
}