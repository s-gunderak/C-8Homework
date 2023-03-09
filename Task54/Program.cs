// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
SortArray(getArray);
Console.WriteLine("--------");
PrintArray(getArray);

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

void SortArray(int[,] inArray)
{
    int temp = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i, j] < inArray[i, k])
                {
                    temp = inArray[i, j];
                    inArray[i, j] = inArray[i, k];
                    inArray[i, k] = temp;
                }
            }

        }
    }
}