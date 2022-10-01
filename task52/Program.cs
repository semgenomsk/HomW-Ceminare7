// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int rows, int cols, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

double[] AVGElementsInCols(int[,] matrix)
{
    double[] res = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            res[j] += matrix[i, j];
        }
        //res[j] = Math.Round(res[j] / matrix.GetLength(0), 1);
        res[j] = res[j] / matrix.GetLength(0);
    }
    return res;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int[,] matr = GetMatrix(m, n);
Console.WriteLine("Двумерный массив: ");
PrintMatrix(matr);
//Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", AVGElementsInCols(matr))}");
Console.WriteLine($"Среднеарифметическое элементов столбцов составляет: {string.Join(", ", AVGElementsInCols(matr)):f2}");