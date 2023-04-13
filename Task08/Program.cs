// Напишите программу,
// которая на вход принимает число (N),
// а на выходе показывает 
// все четные числа от 1 до N.

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа от 1 до {number}: ");
int count = 1;
while (count<=number)
{
   if (count%2 == 0)
   {
    Console.WriteLine($"  {count}  ");
   } 
   count++;
}
