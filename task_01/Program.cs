Console.Clear();
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.
// example:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"
int NatureNumber(int start, int end)
{
    if (start == end)
    {
        Console.Write($"{start}");
        return start;
    }
    Console.Write($"{start},");
    return NatureNumber(start + 1, end);
}
NatureNumber(4, 15);