Console.Clear();
Console.Write("Введите пятизначное цклое число: ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num < 10000 || num > 99999)
{
    Console.WriteLine("Введено не пятизначное целое число");
}
else if (num /10000 % 10 == num % 10 && num /1000 % 10 == num /10 % 10)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}
