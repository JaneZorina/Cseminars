/*
void GetDiapazone(int quadrant)
{
    if (quadrant ==1) Console.WriteLine("x > 0 and y >0 ");
    else if (quadrant ==2) Console.WriteLine("x <0 and y >0 ");
    else if (quadrant ==3) Console.WriteLine("x <0 and y < 0 ");
    else if (quadrant==4) Console.WriteLine("x >0 and y <0 ");
    else Console.WriteLine("Wrong input!");
}
Console.Write("Input a number of quadrant: ");
int quanNum = Convert.ToInt32(Console.ReadLine());
GetDiapazone(quanNum);
*/

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
/*
int GetQundrant (int x, int y)
{
   int quadrant =-1;
    if (x>0 && y>0 ) quadrant =1;
    else if (x<0 && y>0) quadrant =2;
    else if (x<0 && y<0) quadrant =3;
    else if (x>0 && y<0) quadrant=4;;
    return quadrant;
}
Console.Write("Input coordinates X and Y : ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (GetQundrant(x,y) ==-1) Console.WriteLine("Wrong input!");
else Console.WriteLine(" Qunrant number"+ GetQundrant(x,y));
*/

//Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.
/*
void Quad(int n)
{
int count = 1;
while (count <  n +1)
{
Console.WriteLine("Quads are : " + count * count);
count = count+1;
}
}
Console.Write("Input a number : ");
int n = Convert.ToInt32(Console.ReadLine());
Quad (n);
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Distanse (double x1,double x2,double y1, double y2)
{
    double res1 = Math.Pow (x2-x1, 2);
    double res2 =Math.Pow (y2-y1, 2);
    double result= Math.Sqrt(res1 + res2);
    return result;
}
Console.Write("input  a first point coordinates: ");
double x1= Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("input  a secont point coordinates: ");
double x2= Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("distance " + Distanse(x1,y1,x2,y2));
*/

