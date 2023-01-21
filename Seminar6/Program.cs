// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array;    
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "");
    
    Console.WriteLine();    
}


void ReverceArray(int[] array)
{
    for(int i =0,j = array.Length - 1; i < j ; i++,j--)
    {
        int temp = array[i];
        array[i]= array[j];
        array[j] = temp;
    }
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max= Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght, min, max);
ShowArray(newArray);
ReverceArray(newArray);
ShowArray(newArray);
*/
//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Triangle(int num1, int num2, int num3)
{
   if (num1+num2>num3 && num2+num3>num1 && num1+num3> num2) return true;
   else return false;
   
}

Console.Write("Input a first site size: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a secont site size: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third site size: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write(Triangle (a,b,c));
*/
//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//F(n) = F(n-1) + F(n-2)
/*
int[] FibbonachiArray (int size, int num1, int num2)
{
    int[] array=new int[size];
    array[0]=num1;
    array[1]=num2;
    for( int i=2; i< size; i++)
        array[i] = array[i-2] + array[i-1];
return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "");
    
    Console.WriteLine();    
}

Console.Write("Input a size of Fibbonachi line: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first Fibbonach number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second Fibbonachi number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[] result = FibbonachiArray(size,num1,num2);
ShowArray(result);
*/

//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i< size; i++)
        array[i] = new Random().Next(minValue,maxValue);
    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+ "");
    
    Console.WriteLine();    
}

int[] CopyArray (int[] array, int size)
{
  int[]newArray= new int[size];
  for (int i=0; i<array.Length; i++)
       newArray[i]=array[i];
return newArray;
}

Console.Write("Input a lenght of array: ");
int lenght= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max= Convert.ToInt32(Console.ReadLine());

int[] Array = CreateRandomArray(lenght, min, max);
ShowArray(Array);
int[] result= CopyArray(Array,lenght);
ShowArray(result);


