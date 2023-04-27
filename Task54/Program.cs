// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

Console.Write("Введите количество строк в массиве => ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве => ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array2d = CreatMatrixRndInt( line, column, -100, 100);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
SortingArray(array2d);
Console.WriteLine("Обработанный массив: ");
PrintMatrix(array2d);


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

void SortingArray(int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       for (int k = 0; k < matrix.GetLength(1)-1; k++)
       {
        if (matrix[i,k] < matrix[i, k+1])
        {
        int temp = matrix[i, k+1];
        matrix[i,k+1] = matrix[i,k];
        matrix[i,k] = temp;
        }
       } 
    }  
}
}