//34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = GetArray(6, 100, 1000);
int evenNumbers = GetEvenNumbers(array);
Console.WriteLine($"[{String.Join(" ", array)}] -> {evenNumbers}");

//////////////////////////////////////////////////////////////////////////////////

// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

// Возвращает количество чётных чисел массива arr

int GetEvenNumbers(int[] arr)
{
    int evenNum = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) evenNum ++;
    }
    return evenNum;
}