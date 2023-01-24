// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Прямые, заданны уравнениями y = k1 * x + b1 и y = k2 * x + b2");
Console.WriteLine();

Console.Write("Введите целое число b1: ");
double b1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число b2: ");
double b2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число k1: ");
double k1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите целое число k2: ");
double k2 = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения этих прямых -> ({x}; {y})");