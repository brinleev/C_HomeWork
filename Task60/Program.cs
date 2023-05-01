// Сформируйте трёхмерный массив
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет 
// построчно выводить массив,
// добавляя индексы каждого элемента.


Console.Write("Введите количество строк в матрице  => ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице  => ");
int column = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину матрицы => ");
int depth = Convert.ToInt32(Console.ReadLine());
int[,,] array3D = new int[line, column, depth];
CreateArray(array3D);
WriteArray(array3D);


void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

void WriteArray(int[,,] inArray)
{
    int i = 0;
    int j = 0;
    int k = 0;
    Console.WriteLine();
        for (i = 0; i < inArray.GetLength(0); i++)
        {
            for (j = 0; j < inArray.GetLength(1); j++)
            {
                for (k = 0; k < inArray.GetLength(2); k++)
                {
                    Console.Write($"{inArray[i, j, k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    Console.WriteLine();
}
