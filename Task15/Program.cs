// Напишите программу,
// которая принимает на вход цифру, 
// обозначающую день недели,
// и проверяет,
// является отот день выходным.

bool HolidayDay(int number)
{
    if (5 < number && number > )
    {
   
return true;
    }
    return false;
}

bool WrongDay(int number)
{
    if (0 < number && number <= 7)
    {
  
      return true;
    }
Console.WriteLine("К сожалению в неделе только семь дней");   
    return false;
}

int Receive(string message)
{
Console.Write(message);
string dayweek = Console.ReadLine();
int result = Convert.ToInt32(dayweek);
return result;
}

int number = Receive("Введите число - ");
if (WrongDay(number))
{
 if (HolidayDay(number))
 {
     Console.WriteLine("УРА, это выходной");
 }

else
{
 Console.WriteLine("Работаем, это не выходной");    
}
}
  
