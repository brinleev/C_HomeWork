// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

Console.Write("Введите количество строк в матрице №1 => ");
int line1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице №1 => ");
int column1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк в матрице №2 => ");
int line2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице №2 => ");
int column2 = Convert.ToInt32(Console.ReadLine());
int [,] array1 = CreatMatrixRndInt( line1, column1, -10, 10);
Console.WriteLine("Первая матрица:");
PrintMatrix(array1);
int [,] array2 = CreatMatrixRndInt( line2, column2, -10, 10);
Console.WriteLine("Вторая матрица:");
PrintMatrix(array2);
int [,] array3 = new int [line1, column2];
ProductMatrices (array1, array2, array3, column1, line2);



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
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j],  5}");
        } 
        Console.WriteLine();
    }
   Console.WriteLine();
}  

void ProductMatrices (int [,]matrix1, int [,]matrix2,  int [,]array3, int colums, int rows)
{
if ( rows == colums)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
      for (int j = 0; j < array3.GetLength(1); j++)
      {
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
         sum += matrix1[i,k] * matrix2[k,j];
        }
        array3[i,j] = sum;
      }  
    }
     Console.WriteLine("Результат умножения матриц:");
    PrintMatrix(array3);
}    
else
{
     Console.WriteLine("Данные матрицы не могут быть перемножены");
}
}
