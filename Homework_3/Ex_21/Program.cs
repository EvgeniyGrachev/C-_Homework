Console.Clear();
Console.Write("Введите X для точки A: ");
int xA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите Y для точки A: ");
int yA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите Z для точки A: ");
int zA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите X для точки B: ");
int xB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите Y для точки B: ");
int yB = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите Z для точки B: ");
int zB = int.Parse(Console.ReadLine() ?? "");

double distance = Math.Round((Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2))), 2);

Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) -> {distance}");
