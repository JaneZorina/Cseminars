// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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
