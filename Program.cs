// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце

int[,] GettwoArray()
{
    int m = new Random().Next(10, 10);
    int n = new Random().Next(10, 10);
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
        }
    }
    return inArray;
}
void PrinttwoArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void Average(int[,] array)
{
    double sum = 0;
    double[] res = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        res[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    Console.WriteLine($"[{String.Join("; ", res)}]");
}
Console.Clear();
int[,] Arr = GettwoArray();
PrinttwoArray(Arr);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
Average(Arr);
