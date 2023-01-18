// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int numA = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int numB = GetNumberFromUser("Введите целое число B: ", "Ошибка ввода!");
double degreeNumbers = GetDegreeNumbers(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {degreeNumbers}");

// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
// Возводит число А в степень В
double GetDegreeNumbers(int numberA, int numberB)
{
    double degree = Math.Pow(numA, numB);
    return degree;
}