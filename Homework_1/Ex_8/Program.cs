Console.Write("Введите целое положительное число: ");
string userInput = Console.ReadLine() ?? "";

int number = int.Parse(userInput);
Console.Write($"{number} -> ");
int index = 1;

while (index <= number)
{
    if (index %2 == 0)
    {        
        Console.Write($"{index}, ");
    }
    index ++;
}
