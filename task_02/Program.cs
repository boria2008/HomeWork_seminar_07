Console.Clear();

// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// example:
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (n == 0)
    {
        return FunctionAkkerman(m-1,1);
    }
    else
    {
        return FunctionAkkerman(m-1,FunctionAkkerman(m,n-1));
    }
}
Console.WriteLine(FunctionAkkerman(2,3));