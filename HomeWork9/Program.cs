// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num +" ");
    if(num>1) ShowNums(num-1);    
}
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);

*/
//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ShowSum(int m, int n)
{
    if(m>n) return m+ShowSum(m-1,n);
        else if(m<n) return n+ShowSum(m,n-1);
                else return m; 
    
}
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowSum(num1,num2));
