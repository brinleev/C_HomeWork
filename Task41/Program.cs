// Пользователь вводит с клавиатуры М чисел.
// Посчитайте, сколько чисел больше нуля
// ввел пользователь.


int length = Prompt("Сколько чисел требуется ввести => ");
int[] array = EnterNumbers(length);
PrintArray(array);
Console.WriteLine($"Количество введеннных положительных чисел  =>  {NumberPositiveNum (array)}");

int [] EnterNumbers ( int length)
{
     int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i+1} число => ");
    }
    return  array;
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

int NumberPositiveNum ( int[] array)
{
   int N = 0;
   for (int i = 0; i < array.Length; i++)
   {
     if (array[i] > 0)
     {
        N = N + 1;
     }
   }
   return N;
}

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
