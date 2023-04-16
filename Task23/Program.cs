// Напишите программу,
// которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

Console.Write("Введите число =>  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Таблица кубов чисел от 1 до {n}{TableCubeNumbers(n)}");

string TableCubeNumbers(int number)
{
    string cube = "\n";
    for (int i = 1; i <= number; i++)
    {
        cube = cube + $"|{i,7} | {i*i*i,7} | \n"; 
    }

return cube;
}