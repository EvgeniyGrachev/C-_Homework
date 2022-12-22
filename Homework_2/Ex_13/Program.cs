Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";

int num = int.Parse(userInput);
Console.Write($"{num}");

if (num < 100)
{
    Console.Write($" -> третьей цифры нет");
}
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    int a = num % 10;
    Console.Write($" -> {a}");
}
