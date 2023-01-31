// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a nuber of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a nuber of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value number: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value number: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[,] array= new int[rows,colums];

    for (int i=0; i<rows; i++)
        for(int j=0; j<colums; j++)
            array[i,j]= new Random().Next(minValue,maxValue+1);

    return array;
}

void Show2dArray(int[,]array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeNumbers(int[,]array)
{
    for( int i=0; i<=array.GetLength(0)-1; i++) 
    for(int j=0,k=0; k<=array.GetLength(0)-1; k ++)
        {
            for (j=0; j<=array.GetLength(0)-2; j++)
            if (array[i,j] < array[i,j+1])
            {
                int temp = array[i,j];
                array[i,j]=array[i,j+1];
                array[i,j+1] = temp;
            }  
                
        }      
}

int[,]newArray = CreateRandom2dArray();
Show2dArray(newArray);
ChangeNumbers(newArray);
Show2dArray(newArray);
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a nuber of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a nuber of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value number: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value number: ");
    int maxValue= Convert.ToInt32(Console.ReadLine());

    int[,] array= new int[rows,colums];

    for (int i=0; i<rows; i++)
        for(int j=0; j<colums; j++)
            array[i,j]= new Random().Next(minValue,maxValue+1);

    return array;
}

void Show2dArray(int[,]array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumInRows(int[,]array)
{
    int[]SumArray = new int[array.GetLength(0)];

    int Sum=0;
    for(int i=0; i<=array.GetLength(0)-1; i++)
    {

    for(int j=0,k=0; k<=array.GetLength(0)-1; k ++)
        {
            for (j=0, Sum=array[i,j]; j<=array.GetLength(0)-2; j++)
            Sum=Sum+array[i,j+1];
            
        } 
        SumArray[i]=Sum;
        Console.Write(SumArray[i]);
        Console.Write(" ");

    }

    int MinSum=SumArray[0];
    int MinRow=1;
    for (int i=0; i<=array.GetLength(0)-1; i++)
    if (SumArray[i]<MinSum)
    {
        MinSum=SumArray[i];
        MinRow=i+1;
    }
        Console.WriteLine();
        Console.Write("Min sum = ");
        Console.Write(MinSum);
        Console.WriteLine();
        Console.Write("Row min sum ");
        Console.Write(MinRow);

}

int[,]newArray = CreateRandom2dArray();
Show2dArray(newArray);
SumInRows(newArray);
*/


//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
/*
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
