Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ?? "";

int number = int.Parse(userInput);

if (number % 2 == 0) 
{
    Console.WriteLine($"{number} -> чётное");
}
else
{
    Console.WriteLine($"{number} -> нечётное");;
}