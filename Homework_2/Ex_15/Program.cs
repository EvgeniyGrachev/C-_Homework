Console.Write("Введите целое число от 1 до 7: ");
string userInput = Console.ReadLine() ?? "";

int number = int.Parse(userInput);

if (number > 0 && number <= 5) 
{
    Console.WriteLine($"{number} -> Будний день :(");
}
else if (number == 6 || number == 7) 
{
    Console.WriteLine($"{number} -> Выходной! :)");
}
else 
{
    Console.WriteLine("Введёное число не входит в диапазон от 1 до 7");
}
