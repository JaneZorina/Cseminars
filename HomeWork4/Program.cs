// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Method(int a, int b)
{
int result = 1; 
int i = 0;   
while (i<b)
 {
    i++; result = result * a;
 } 
return result;
}
Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input secont number:");
int num2= Convert.ToInt32(Console.ReadLine());
int current= Method(num1, num2);
Console.WriteLine($"First number in degree of secont number is {current}");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum(int a)
{
int result = 0;
while (a>=1)
{
    int current = a % 10;
    a = (a-current)/10;
    result = result + current;
}
return result;
}
Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = Sum(num);
Console.WriteLine($"Sum of numbers is {current}");
*/

//Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


