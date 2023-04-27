// Задайте прямоугольный двумерный массив.
// Напишите программу,
// которая будет находить строку 
// с наименьшей суммой элементов.

Console.Write("Введите количество строк в массиве => ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве => ");
int column = Convert.ToInt32(Console.ReadLine());
int [,] array2d = CreatMatrixRndInt( line, column, -10, 10);
Console.WriteLine();
PrintMatrix(array2d);
Console.WriteLine();
int [] array = SumRow (array2d, line);
SmallestSumRowElements (array);

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

void   SmallestSumRowElements (int [] arr)
{
int index = 0;
int minSum = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if (arr[i]< minSum) 
    {
        minSum = arr[i];
        index = i;
}
}
Console.WriteLine($"Минимальной суммой будет сумма {index + 1} строки, она равна => {minSum}");
Console.WriteLine();
}

int  [] SumRow (int [,] matrix, int k)
{
    int [] arr = new int [k];
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum = sum + matrix[i,j];
        } 
        arr[i] = sum;
    }
return arr;
}