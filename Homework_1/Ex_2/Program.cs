Console.Write("Введите первое целое число: ");
string userInput_1 = Console.ReadLine() ?? "";
Console.Write("Введите второе целое число: ");
string userInput_2 = Console.ReadLine() ?? "";

int number_1 = int.Parse(userInput_1);
int number_2 = int.Parse(userInput_2);

if (number_1 > number_2) 
{
    Console.WriteLine($"a = {number_1}, b = {number_2} -> max = {number_1}");
}
else 
{
    Console.WriteLine($"a = {number_1}, b = {number_2} -> max = {number_2}");
}
