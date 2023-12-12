// Console.Clear();

// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// example:
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

Random rand = new Random();
int[] CreateArray(int size, int minInt, int maxInt)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minInt, maxInt + 1);
    }
    return array;
}


void PrintArray(int i, int[] arr)
{
    if (i == 0)
    {
        Console.Write(arr[0]);
        return;
    }
    Console.Write($"{arr[i]}, ");
    PrintArray(i - 1, arr);
}

int[] arr = CreateArray(5, -10, 10);
Console.WriteLine($"Array before:[{string.Join(", ", arr)}]");
int i = arr.Length - 1;
Console.Write("Array after:[");
PrintArray(i, arr);
Console.Write("]");