// Напишите программу, 
// которая принимает на вход число
// и выдает сумму цифр в числе.


Console.Write("Введите целое число =>  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр числа {n} => {SumDigits (n)}");


int SumDigits(int n1)
{
    int sum = 0;
    while (n1 > 0)
    {
        sum = sum + n1 % 10;
        n1 = n1 / 10;
    }
    return sum;
}