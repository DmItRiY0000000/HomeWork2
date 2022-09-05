//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Pack(int num)
{
    int res;
    res = num/10 % 10;
    return res;
}

 int randNum = new Random().Next(100, 1000);
 int res = Pack(randNum);
 Console.WriteLine($"В трёхзначном числе {randNum} вторая цифра является {res} ");

*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
  Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 && number > -100) 
{
    Console.WriteLine("третьей цифры нет");
}
else
{

    int num = number;
    while (num > 1000)
    {

        num = num / 10;

    }

    Console.WriteLine($" Третья цифра числа {number} -> {num % 10 }");

}
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

DayOfTheWeek(dayNumber);
*/