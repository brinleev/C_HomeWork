//  Напишите программу, 
//  которая заполнит спирально массив.

Console.Write("Введите размер массива =>");
int size = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[size, size];
CreateArray(array, size);
PrintArray(array);

void CreateArray(int[,] matrix, int x)
{
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= x * x)
    {
        matrix[i, j] = num;
        if (i <= j + 1 && i + j < x - 1)
        ++j;
        else if (i < j && i + j >= x - 1)
        ++i;
        else if (i >= j && i + j > x - 1)
         --j;
        else
        --i;
        ++num;
    }
}

void PrintArray(int[,] matrix)
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