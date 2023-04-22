// Задайте массив, заполненный 
// случайными положительными трехзначными числами.
// Напишите программу, которая покажет
// количество четных чисел в массиве.

int [] CreatArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray (int [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int NumberEvenNumbers(int [] arr)
{
    int num = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (arr[i] % 2 == 0) num = num + 1;
    }
    return num;
}

Console.Write("Введите количество чисел в массиве => ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreatArrayRndInt(number,100,1000);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве =>  {NumberEvenNumbers(array)}");
