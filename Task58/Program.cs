// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Write("Введите количество строк матрицы A: ");
int am = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы A: ");
int an = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк матрицы B: ");
int bm = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int bn = int.Parse(Console.ReadLine());

int[,] matrixA = GetArray(am, an, 0, 9);
PrinMtatrix(matrixA);
Console.WriteLine("----");
int[,] matrixB = GetArray(bm, bn, 0, 9);
PrinMtatrix(matrixB);

Console.WriteLine("Матрица C = матрица A * матрица B:");
int[,] matrixC = Multiplication(matrixA, matrixB);
PrinMtatrix(matrixC);

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

void PrinMtatrix(int[,] inArray)
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

int[,] Multiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                result[i, j] += a[i, k] * b[k, j];
            }
        }
    }
    return result;
}