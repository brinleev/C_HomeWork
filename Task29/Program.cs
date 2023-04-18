// Напишите программу, которая задает массив
// из 8 элементов и выводит их на экран.

int [] array = new int[8];
NewArray(array);
PrintArray(array);

void NewArray(int[] userArray)
{
for (int i = 0; i < userArray.Length; i++)
{
  userArray[i] = new Random().Next(0,100);  
}
}

void PrintArray(int[] userArray)
{
    Console.WriteLine("Массив из 8 элементов");
    Console.Write("[   ");
    for (int i = 0; i < userArray.Length; i++)
{
  Console.Write($"{userArray[i]}   ");
}
Console.Write("]");
Console.WriteLine();
}