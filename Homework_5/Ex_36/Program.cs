//36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = GetArray(6, -100, 101);
int sumEvenPosition = GetSumEvenPosition(array);
Console.WriteLine($"[{String.Join(" ", array)}] -> {sumEvenPosition}");

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

// Возвращает сумму элементов, стоящих на нечётных позициях массива arr

int GetSumEvenPosition(int[] arr)
{
    int sumPosition = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sumPosition = sumPosition + arr[i];
    }
    return sumPosition;
}