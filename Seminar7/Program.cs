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

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] Create2dArray()
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
            array[i,j]= i+j;

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

int[,] myArray = Create2dArray();
Show2dArray(myArray);

*/

//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
/*
int[,] Create2dArray()
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
            array[i,j]= new Random().Next(minValue,maxValue+1) ;

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

int[,] IsEvenArray (int[,]array)
{
    for (int i=0; i< array.GetLength(0); i+=2)
    {
        for(int j=0; j< array.GetLength(1); j+=2) 
            array[i,j]= array[i,j]*array[i,j];
    }
    return array;
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
int[,] myNewArray= IsEvenArray(myArray);
Show2dArray(myNewArray);
*/


//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
int[,] Create2dArray()
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
            array[i,j]= new Random().Next(minValue,maxValue+1) ;

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

int Sum (int[,]array)
{
    int result=0;
    for (int i=0; i< array.GetLength(0); i++)
        result += array[i,i];
    return result;
}

int[,] myArray = Create2dArray();
Show2dArray(myArray);
int a = Sum(myArray);
Console.Write(a);
