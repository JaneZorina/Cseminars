// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num>1) ShowNums(num-1);
    Console.Write(num +" ");
}
ShowNums(5);
*/
// обратный вывод аргументов
/*
void ShowNums(int num)
{
    Console.Write(num +" ");
    if(num>1) ShowNums(num-1);    
}
ShowNums(5);
*/


//Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
/*
int GetSumOfDigits(int num)
{
    if(num!=0) return GetSumOfDigits(num/10)+num%10;
    else return 0;
}
Console.WriteLine(GetSumOfDigits(1234));
*/

//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
    if(m>n)
    {
       Console.Write(m+" ");
       ShowNums(m-1,n);
    }
    else if (m<n)
    {
       Console.Write(n+" ");
       ShowNums(m,n-1);
    }
    else Console.Write( n + " ");
}
ShowNums(3,3);
*/
//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double Method(double a,double b)
{
    if (b>0 ) return a*Method(a,b-1);
    else if(b<0) return 1/a*Method(a,b+1);
    else return 1;

}
Console.WriteLine(Method(2,3));
