// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элементов массива: ");
int minVal = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элементов массива: ");
int maxVal = int.Parse(Console.ReadLine());

int[,] getArray = GetArray(m, n, minVal, maxVal);
PrintArray(getArray);
int[] sumRow = SumRow(getArray);
Console.WriteLine(String.Join(" ", sumRow));
// int minSumRow = int.Parse(Console.ReadLine());
MinSumRow(sumRow);
// int minSumRow = MinSumRow(sumRow);
// Console.Write($"{minSumRow}");

int[,] GetArray(int m, int n, int minVal, int maxVal)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumRow(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0)];
    int index = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
        }
        result[index] = sum;
        index++;
    }
    return result;
}

void MinSumRow(int[] inArray)
{
    int min = inArray[0];
    int index = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (min > inArray[i])
        {
            min = inArray[i];
            index = i;
        }
    }
    Console.Write($"Номер строки с мимнимальной суммой элементов = {index + 1}");
}