//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube (int n)
{
int count = 1;
while (count <  n +1)
{
Console.WriteLine("Cubes are : " + count * count * count);
count = count+1;
}
}
Console.Write("Input a number : ");
int n = Convert.ToInt32(Console.ReadLine());
Cube (n);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distanse3D (double x1,double x2,double y1, double y2,double z1,double z2)
{
    double res1 = Math.Pow (x2-x1, 2);
    double res2 =Math.Pow (y2-y1, 2);
    double res3 = Math.Pow (z2-z1, 2);
    double result= Math.Round (Math.Sqrt(res1 + res2 + res3),2);
    return result;
}
Console.Write("input  a first point coordinates: ");
double x1= Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble (Console.ReadLine());

Console.Write("input  a secont point coordinates: ");
double x2= Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("distance " + Distanse3D(x1,y1,x2,y2,z1,z2));
*/

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Polindrom (int number)
{
  while (number> 10000)
    int res1 = number % 10;
    int res2= res1 % 10;
    int res3 = res2 % 10;
    int res4 = res3 % 10;
    if (res1 ==res2 && res3==res4)  Console.Write("Your number is polindrom!");
    else  Console.WriteLine("Your number is not a polindrom");
}

int randNumber = new Random().Next(10000,9999999);
Console.WriteLine ("Current random  number is "+ randNumber);
Console.WriteLine( Polindrom (randNumber));
