// Задайте одномерный массив,
// заполненный случайными числами.
// Найдите сумму элементов,
// стоящих на нечетных позициях.

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

int SumOddElements(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (i % 2 != 0) sum = sum + arr[i];
    }
    return sum;
}

Console.Write("Введите количество чисел в массиве => ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива => ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива => ");
int num1 = Convert.ToInt32(Console.ReadLine());
int[] array = CreatArrayRndInt(number,num,num1);
PrintArray(array);
Console.WriteLine($"Сумма элементов нечетных позиций =>  {SumOddElements(array)}");
