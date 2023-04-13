// Напишите программу,
// которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number > number1)
{
  Console.WriteLine($"Первое число - {number}, больше второго - {number1}");  
}
else
{
   Console.WriteLine($"Второе число - {number1}, больше первого - {number}");   
}
