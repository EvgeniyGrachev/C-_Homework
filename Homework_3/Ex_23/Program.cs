Console.Clear();
Console.Write("Введите целое положительное число: ");
int num = int.Parse(Console.ReadLine() ?? "");
int index = 1;
Console.Write($"{num} ->");

if (num < 1)
{
    Console.Write(" Введено не целое положительное число");
}

while (index <= num)
{
    double cube = Math.Pow(index, 3);
    Console.Write($" {cube},");
    index++;
}
