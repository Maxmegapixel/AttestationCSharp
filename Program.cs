// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

PrintMessage("Введите значение M:");
int M = GetValue();
PrintMessage("Введите значение N:");
int N = GetValue();
PrintMessage($"Сумма в промежутке от {M} до {N}:");
PrintMessage($"{GetSumm(M, N)}");

int GetValue() => int.Parse(Console.ReadLine()!);
void PrintMessage(string value) => Console.WriteLine(value);

int GetSumm(int start, int end)
{
    if (start == end) return start;
    return (start + GetSumm(start + 1, end)); 
}

