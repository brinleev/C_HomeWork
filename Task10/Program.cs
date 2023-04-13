// Напишите программу, 
// которая на вход принимает трехзначное число
// и на выходе показывает вторую цифру этого числа.

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число - {randomNumber}");
Console.WriteLine($"Вторая цифра числа - {SecondDigit(randomNumber)}");

int SecondDigit(int randomNum)
{
    int SecondDigit = randomNum % 100 / 10;
    return SecondDigit;
}