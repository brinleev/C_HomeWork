// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.Write("Введите пятизначное целое число =>  ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = Palindrom(number);

int Palindrom(int number)
{
int first = number / 10000;
int second =  number / 1000 % 10;
int fourth = number / 10 % 10;
int fifth = number % 10;
if (first == fifth & second  == fourth)
{
   Console.WriteLine("Это число является палиндромом"); 
}
else
{
   Console.WriteLine("Это число не является палиндромом");  
}
return first;
}