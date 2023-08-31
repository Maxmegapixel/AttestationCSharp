// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

PrintMessage("Введите значение N:");
int num = int.Parse(Console.ReadLine()!);
PrintMessage($"Натуральные числа в промежутке от {num} до 1:");
PrintMessage(GetNumbers(num));

void PrintMessage(string value) => Console.WriteLine(value);
string GetNumbers(int value)
{
    if (value == 1) return "1";
    return (value + ", " + GetNumbers(value - 1)); 
}

