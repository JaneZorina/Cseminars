
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Numbers(int n)
{
    int count =0;
    while( n!= 0 )
    {
        n = n/10;
        count += 1;
    }
    return count;    
}
Console.Write("input a number:");
int num = Convert.ToInt32(Console.ReadLine());
int result = Numbers(num);
Console.WriteLine($"{result}");
*/

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Multip(int n)
{
int result = 0;
int i = 0;
for( i = 1; i< n; i++);
     result = (i-1) * i;
return result;
}  
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Multip(num);
Console.WriteLine ($"Произведение чисел от 1 до {num}:  {result}" );
