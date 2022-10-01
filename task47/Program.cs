// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetMatrix(int rows, int cols, double leftRange = -10.0, double rightRange = 10.0)
{
    Random rand = new Random();
    double[,] matrix = new double[rows, cols];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //matrix[i,j]=rand.Next(leftRange,rightRange+1);
            matrix[i, j] = Math.Round(rand.NextDouble() * 20 - 10, 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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
double[,] matr = GetMatrix(m, n);
Console.Write($"Двумерный массив с вещественными числами составляет {matr:f2}");
PrintMatrix(matr);