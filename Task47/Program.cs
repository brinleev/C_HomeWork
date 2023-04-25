// Задайте двумерный массив
// размером m*n,
// заполненный случайными вещественными числами.

Console.Write("Введите количество строк в массиве => ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве => ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array2d = CreatMatrixRndDouble( line, column, -100, 100);
Console.WriteLine();
PrintArray(array2d);
Console.WriteLine();

double [,] CreatMatrixRndDouble(int rows, int colums, int max, int min)
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0;j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintArray (double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write ($"{Math.Round(matrix[i,j],2,MidpointRounding.ToZero),   6}  ");  
        }
        Console.WriteLine();
    }
}
