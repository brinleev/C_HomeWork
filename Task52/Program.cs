// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов
// в каждом столбце.

Console.Write("Введите количество строк в массиве => ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве => ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array2d = CreatMatrixRndInt( line, column, -10, 10);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
ArithmeticMeanColumn( array2d, line, column);

int [,] CreatMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] = rnd.Next(min, max + 1); 
        }
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j],  5}");
        } 
        Console.WriteLine();
    }
}  

double [] ArithmeticMeanColumn(int [,] matrix, int rows, int colums)

{ double[] arr = new double[colums];
 double asum = 0;
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum+= matrix[i,j];
        asum = sum / matrix.GetLength(0);

    }
    arr[j] = asum;
}
Console.WriteLine("Среднее арифметическое элементов каждого столбца:");
Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i],2,MidpointRounding.ToZero)};  ");
        else Console.Write($"{Math.Round(arr[i],2,MidpointRounding.ToZero)}");
    }
    Console.WriteLine("]");
return arr;
}


