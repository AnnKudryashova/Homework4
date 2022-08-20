// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Summ(int number)
{
     var result = 0;

     int X = 0;

     while(number > 0)
     {
          X = number%10;
          result = result + X;
          number = number/10;
     }     
   return result;
}

Console.WriteLine("Введите число");

int number = int.Parse(Console.ReadLine());

var result = Summ(number);

Console.WriteLine(result);

