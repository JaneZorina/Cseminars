/*
int CutNumber(int number)
{
 int sot = number / 100;
 int ed = number % 10;
 int result = sot *10 + ed;
 return result;
}

int randNumber = new Random().Next(100,1000);
Console.WriteLine("Current random tree-digit number is  " + randNumber);
int NewNumber = CutNumber(randNumber);
Console.WriteLine("New version of number is  " + NewNumber);
*/
//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа
/*
int CompareNumber (int number)
{
    int des = number / 10;
    int ed = number % 10;
    int max = 0;
        if (des > ed)
    {
        max = des;
    }
    else
    {
        max = ed;
    }
    return max;
}
int randNumber = new Random().Next(10,100);
Console.WriteLine ("Current random two-digital number is "+ randNumber);
int NewNumber = CompareNumber(randNumber);
Console.WriteLine("biggest digit is "+NewNumber);
*/
//Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому

/*
bool Method ( int num1 , int num2)
{
if (num2 %  num1 == 0) return true;
else return false;
}
Console.WriteLine ("input a first  number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second  number: ");
int num2= Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ( Method(num1,num2) );
 
 */

 //Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого


bool QuadNumber ( int num1 , int num2)
{
if (num1 == num2*num2 || num2==num1*num1) return true;
else return false;
}
Console.WriteLine ("input a first  number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input a second  number: ");
int num2= Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ( QuadNumber(num1,num2) );

