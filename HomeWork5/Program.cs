// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array;    
}

int FindEven (int[] array)
{
    int count=0;
    for (int i =0 ; i< array.Length; i++)
    {
        if (array[i]%2==0) count ++;
    }
    return count;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    
    Console.WriteLine();    
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a tree digit min possitive value: ");
int minValue= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a tree digit max possitive value: ");
int maxValue= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, minValue, maxValue);
ShowArray(newArray);
int result = FindEven(newArray);
Console.Write(result);
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array;    
}

int SumIndex(int[] array)
{
    int sum = 0;
    for (int i =1 ; i< array.Length; i = i+2) sum= sum + array[i];
    return sum;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    
    Console.WriteLine();    
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a tree digit min possitive value: ");
int minValue= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a tree digit max possitive value: ");
int maxValue= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, minValue, maxValue);
ShowArray(newArray);
int result = SumIndex(newArray);
Console.Write(result);
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i< size; i++)
        array[i] = minValue + new Random().NextDouble()*(maxValue-minValue);
    return array;    
}

double[] GetDiff (double[] array)
{
   double min =0;
   double max= 0;
   double diff= 0 ;
   for (int i =0 ; i< array.Length; i ++) diff= Math.Round(max-min,2);
   {
        if(array[i] < min) min = array[i];
        if(array[i]> max) max= array[i];
   }
       return diff;
}

void ShowArray(double [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ " ");
    
    Console.WriteLine();    
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a tree digit min possitive value: ");
int minValue= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a tree digit max possitive value: ");
int maxValue= Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(lenght, minValue, maxValue);
ShowArray(newArray);
double result = GetDiff( newArray );
Console.Write(result);
