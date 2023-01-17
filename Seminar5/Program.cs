/*
int[] CreateArray (int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++);
    {
        Console.Write($"Input an {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());   
    }
    return array;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array;    
}
void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "");
    
    Console.WriteLine();    
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght);
ShowArray(newArray);
*/
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.
/*
int[] GetSumOfNegative (int[]array)
{
    int sum = 0;
    for (int i=0 ;i < array.Length; i++)
        if(array[i]<0) sum+= array[i];
    
    return sum;
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
int[] result = GetSumOfNegative(newArray);
Console.WriteLine("sum of negative elements is " + result);

*/
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array;    
}

int[] GetReverse (int[] array)
{
    for (int i =0 ; i< array.Length; i++)
    array[i] = array[i]*-1;
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "");
    
    Console.WriteLine();    
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
int[] result = GetReverse(newArray);
ShowArray(result);
*/
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array;    
}

bool[] GetSerch (int[] array, int x)
{
    for (int i = 0; i< size; i++)
    {
        if (array[i]==x)  return true;
    }
    return  false;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "");
    
    Console.WriteLine();    
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a serching number: ");
int x= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
int[] result = GetSerch(newArray);
Console.Write(result);
*/


//Задайте  массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array;    
}

int FindNumber (int[] array, int minNum, int maxNum)
{
    int count=0;
    for (int i =0 ; i< array.Length; i++)
    {
        if (array[i]>= minNum && array[i]<=maxNum) count ++;
    }
    return count;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "");
    
    Console.WriteLine();    
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max= Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min number: ");
int minNum= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number: ");
int maxNum= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
int result = FindNumber(newArray, minNum, maxNum);
Console.Write(result);


