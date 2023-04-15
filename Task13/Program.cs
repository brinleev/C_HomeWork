// Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает,что третьей цифры нет.



int ThirdDigit(int number)
{
while (number > 999)
{
    number /= 10;
}
return number % 10;
}

int Receipt(string message)
{
Console.Write(message);
string line = Console.ReadLine();
int result = Convert.ToInt32(line);
return result;
}

bool InvalidDigit(int number) 
{
    if (number < 100)
    {
        Console.WriteLine("Третья цифра отсутствует");
        return false;
    }
    return true;
}

int number = Receipt("Введите число - ");
if (InvalidDigit(number))
{
 Console.WriteLine(ThirdDigit(number));   
}