// Задайте значения M и N. 
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое положительное число => ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое положительное число => ");
int M = Convert.ToInt32(Console.ReadLine());
if ((N > 0)&&(M > 0))
{
    Console.Write($"Сумма элементов в промежутке от {N} до {M} = ");
    Console.WriteLine(SumNumbers(N,M));
}   
else
{
Console.WriteLine("Вы ввели некорректные числа");
}

int SumNumbers(int numN, int numM)
{
    if (numN == numM) return numM;
    else if (numN > numM) return numM + SumNumbers(numM+1, numN);
         else   return numN + SumNumbers(numN+1, numM); 
}   