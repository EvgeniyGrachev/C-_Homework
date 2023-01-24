/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223 -> 3 */

Console.Clear();

Console.Write("Введите, сколько чисел планируете указать: ");
int size = int.Parse(Console.ReadLine() ?? "");

int[] array = GetArray(size);
Console.Write(String.Join(", ", array));

int countPositiveElement = GetPositiveElement(array);
Console.WriteLine($" -> {countPositiveElement}");

int[] GetArray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите целое положительное или отрицательное число: ");
        res[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return res;
}

int GetPositiveElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}