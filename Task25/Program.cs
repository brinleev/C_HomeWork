// Напишите цикл, который принимает на вход
// два числа (А и В)
// и возводит число А в натуральную степень В.

Console.Write("Введите число =>  ");
double n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число - степень числа =>  ");
double y = check(Convert.ToInt32(Console.ReadLine()));
Console.Write($"Число {n} в степени {y} =>  {DegreeNumber(n,y)}");

double DegreeNumber(double n1, double y1)
{
  
    n1 = Math.Pow(n1, y1);
  
 return n1;
}

double check( double y2)
{
  if (y2 < 0)
  {
    Console.WriteLine("Cтепень числа, должна быть положительным числом"); 
    Console.Write("Повторите ввод степени числа =>  "); 
    y2 = Convert.ToInt32(Console.ReadLine());
  }
  return y2;
}