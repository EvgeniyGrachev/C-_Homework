Console.Write("Введите трёхзначное целое число: ");
string userInput = Console.ReadLine() ?? "";

int num = int.Parse(userInput);

if (num >= 100 && num < 1000)
{
    int a = num / 10 % 10;
    Console.WriteLine($"{num} -> {a}");
}
else
{
    Console.WriteLine("Введёно не трёхзначное целое число");
}
