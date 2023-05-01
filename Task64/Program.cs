// Задайте значение N.
// Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое положительное число => ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
    NuturalNumbers(N);
else
Console.WriteLine("Вы ввели некорректное число");

void NuturalNumbers(int num)
{
    if (num == 0) return;
     Console.Write($"{num}  ");
    NuturalNumbers(num-1);
}