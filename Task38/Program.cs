// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементом массива.

double [] CreatArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray (double [] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i],2,MidpointRounding.ToZero)};  ");
        else Console.Write($"{Math.Round(arr[i],2,MidpointRounding.ToZero)}");
    }
    Console.WriteLine("]");
}

double MaximumElement(double [] arr)
{
    double maxx = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
    if (arr[i] > maxx ) maxx = arr[i];
    }
    return maxx;
}

double MinimumElement(double [] arr)
{
    double minx = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
    if (arr[i] < minx ) minx = arr[i];
    }
    return minx;
}  

  double DifferenceElement(double x, double y)
{
    double dif = x - y;
    dif = Math.Round(dif,2,MidpointRounding.ToZero);
    return dif;
}  

Console.Write("Введите количество чисел в массиве => ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона массива => ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона массива => ");
int num1 = Convert.ToInt32(Console.ReadLine());
double[] array = CreatArrayRndDouble(number,num,num1);
PrintArray(array);
Console.WriteLine($"Максимальный элемент =>  {Math.Round(MaximumElement(array),2,MidpointRounding.ToZero)}");
Console.WriteLine($"Минимальный элемент =>  {Math.Round(MinimumElement(array),2,MidpointRounding.ToZero)}");
Console.WriteLine($"Разница минимального и максимального элемента =>  {DifferenceElement(MaximumElement(array), MinimumElement(array))}");
