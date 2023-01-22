//38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76

Console.Clear();
int[] array = GetArray(6, -100, 101);
int maxElement = GetMaxElement(array);
int minElement = GetMinElement(array);
Console.WriteLine($"[{String.Join(" ", array)}] -> {maxElement - minElement}");

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

// Возвращает максимальный элемент массива arr

int GetMaxElement(int[] arr)
{
    int maxEl = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxEl)
        {
            maxEl = arr[i];
        }
    }
    return maxEl;
}

// Возвращает минимальный элемент массива arr

int GetMinElement(int[] arr)
{
    int minEl = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minEl)
        {
            minEl = arr[i];
        }
    }
    return minEl;
}