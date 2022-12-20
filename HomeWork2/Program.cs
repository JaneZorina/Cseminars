// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNum (int number)
{
  int des = number / 10;
  int need= des % 10;

  return need;
}
int randNumber = new Random().Next(100,999);
Console.WriteLine ("Current random three-digital number is "+ randNumber);
int NewNumber = SecondNum(randNumber);
Console.WriteLine("second digit is "+NewNumber);
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
/*
int ThirdNum (int number)
{
  if (number>99)
  {
    int des = number % 10;
    int need= des % 10;
    return need;
  }
  else
  {
    int need = 0;
    Console.WriteLine("No trird digit in random number");
    return need;
      }
}
int randNumber = new Random().Next(1,999);
Console.WriteLine ("Current random  number is "+ randNumber);
int NewNumber = ThirdNum(randNumber);
Console.WriteLine("third digit is "+NewNumber);
*/

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool Weekend (int number)
{
  if (number==7 || number== 6) return true;
  else return false;
  }
int randNumber = new Random().Next(1,8);
Console.WriteLine ("Current random  number is "+ randNumber);
Console.WriteLine( Weekend (randNumber));
*/
