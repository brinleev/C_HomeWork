// Напишите программу,
// которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number;
if (number1 > max)
{
  max = number1;  
}
if (number2 > max)
{
 max = number2;   
}
Console.WriteLine($"Максимальное число - {max}");
