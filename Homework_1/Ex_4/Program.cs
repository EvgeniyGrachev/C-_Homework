Console.Write("Введите первое целое число: ");
string userInput_1 = Console.ReadLine() ?? "";
Console.Write("Введите второе целое число: ");
string userInput_2 = Console.ReadLine() ?? "";
Console.Write("Введите третье целое число: ");
string userInput_3 = Console.ReadLine() ?? "";

int number_1 = int.Parse(userInput_1);
int number_2 = int.Parse(userInput_2);
int number_3 = int.Parse(userInput_3);

if (number_1 > number_2) 
{
    if (number_1 > number_3)
    {
        Console.WriteLine($"{number_1}, {number_2}, {number_3} -> max = {number_1}");
    }
    else if (number_3 > number_2)
    {
        Console.WriteLine($"{number_1}, {number_2}, {number_3} -> max = {number_3}");
    }
    else if (number_3 < number_2)
    {
        Console.WriteLine($"{number_1}, {number_2}, {number_3} -> max = {number_1}");
    }
    else
    {
        Console.WriteLine($"{number_1}, {number_2}, {number_3} -> max = {number_3}");
    }
}
else if (number_2 > number_3)
{
    Console.WriteLine($"{number_1}, {number_2}, {number_3} -> max = {number_2}");
}
else
{
    Console.WriteLine($"{number_1}, {number_2}, {number_3} -> max = {number_3}");
}