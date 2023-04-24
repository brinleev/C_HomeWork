// Напишите программу, 
// которая найдет точку пересечения прямых,
// заданных уравнениями 
// y = k1*x + b1,
// y = k2*x + b2;
// значения b1,k1,b2,k2 задаются пользователем.

Console.Write("Введите число b1 => ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1 => ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 => ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2 => ");
double k2 = Convert.ToDouble(Console.ReadLine());
double X = Math.Round(CoordinateX(b1, b2, k1, k2),2,MidpointRounding.ToZero);
double Y = Math.Round(CoordinateY(b1, k1),2,MidpointRounding.ToZero);
Console.Write($"Координаты точки пересечения прямых ({X} ; {Y} )");

double CoordinateX(double b1,double b2,double k1,double k2)
{
double x0 = (b2 - b1) / (k1 - k2);
  return x0;
}

 double CoordinateY(double b1,double k1)
{
double y0 = k1 * CoordinateX(b1, b2, k1, k2) + b1;
  return y0;  
}
