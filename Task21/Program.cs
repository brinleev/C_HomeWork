// Напишите программу, 
// которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D прстранстве.

Console.Write("Введите координату x1 =>  ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y1 =>  ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z1 =>  ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату x2 =>  ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату y2 =>  ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату z2 =>  ");
int z2 = Convert.ToInt32(Console.ReadLine());


Console.Write($"Расстояние между точками = {FindDistance(x1,x2,y1,y2,z1,z2)}");

double FindDistance(int x11, int x21, int y11, int y21, int z11, int z21)
{
    int catet1 = x21 - x11;
    int catet2 = y21 - y11;
    int catet3 = z21 - z11;
double distance = Math.Sqrt(catet1*catet1+catet2*catet2+catet3*catet3);
double distance1 = Math.Round(distance,2,MidpointRounding.ToZero);
return distance1;
}