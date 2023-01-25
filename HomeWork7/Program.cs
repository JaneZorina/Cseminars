// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a nuber of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a nuber of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
   // Console.Write("Input a min value number: ");
   // double minValue = Convert.ToDouble(Console.ReadLine());
    //Console.Write("Input a max value number: ");
    //double maxValue= Convert.ToDouble(Console.ReadLine());

    double[,] array= new double [rows,colums];

    for (int i=0; i<rows; i++)
        for(int j=0; j<colums; j++)
            array[i,j]= new Random().NextDouble();

    return array;
}

void Show2dArray(double[,]array)
{
    for (int i=0; i< array.GetLength(0); i++)
    {
        for(int j=0; j< array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows,int colums,int minValue, int maxValue)
{
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

Console.Write("Input a nuber of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a nuber of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value number: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value number: ");
int maxValue= Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows,colums,minValue,maxValue);
Show2dArray(myArray);
Console.Write("Input a nuber of row for searching element: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a nuber of colum for searching element: ");
int j = Convert.ToInt32(Console.ReadLine());
if( i<= rows  && j<=colums) Console.Write(myArray[i,j]);
else Console.write("no element with input parameters found");
*/
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows,int colums,int minValue, int maxValue)
{
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

Console.Write("Input a nuber of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a nuber of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value number: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value number: ");
int maxValue= Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(rows,colums,minValue,maxValue);
Show2dArray(myArray);
double sum=0;
for (int j=0; j< colums; j++)
    {
        for(int i=0; i< rows; i++)
            sum=sum + myArray[i,j];
            double SumAverage=sum/colums;
            Console.Write(SumAverage+ " ");

        Console.Write(" ");
    }
  
*/
