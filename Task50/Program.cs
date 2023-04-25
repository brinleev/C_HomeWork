// Напишите программу, количество на вход принимает
// позиции элемента  в двумерном массиве,
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

Console.Write("Введите количество строк в массиве => ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве => ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array2d = CreatMatrixRndInt( line, column, -10, 10);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
Console.Write("Введите номер строки искомого элемента => ");
int lineX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента=> ");
int lineY = Convert.ToInt32(Console.ReadLine());
ElementValue (lineX, lineY, array2d, line, column);

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

void  ElementValue(int x, int y, int [,] matrix, int i, int j)
{
    if (i>=x && j >= y)
    {
         Console.Write($"Искомый элемент => {matrix[x,y]}");
    }
    else
    {
        Console.Write("Такой элемент не существует ");
    }
        Console.WriteLine();
}
