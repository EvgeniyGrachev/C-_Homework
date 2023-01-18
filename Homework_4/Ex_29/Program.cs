// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 

int[] array = GetRandomArrey(8, 0, 100);
Console.WriteLine($"[{String.Join (", ", array)}]");

int[] GetRandomArrey(int size, int min, int max)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(min, max);
    }
    return result;
}