//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*
double [,] Create2dArray(int row, int column)
{
    double [,] randomArray = new double [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            randomArray [i,j] = Math.Round (new Random().Next(-1000, 1000) + new Random().NextDouble(), 2);  //случайные элементы заполнения с ограничением -1000/+1000(можно менять))
    return randomArray;
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();

        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Input count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());


double [,] newArray = Create2dArray(m, n);
Show2dArray(newArray);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

/*
int [,] Create2dArray(int row, int column, int minVal, int maxVal) 
{
    int [,] createdArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            createdArray [i,j] = new Random().Next(minVal, maxVal + 1);
    return createdArray;
}

void Show2dArray(int [,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindElementArray(int [,] array)
{
    Console.WriteLine("Input position of rows: ");
    int rowsPosition = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input position of columns: ");
    int columnsPosition = Convert.ToInt32(Console.ReadLine());
    int element = 0;

    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
                if (i == rowsPosition && j == columnsPosition)
                    element = array[i, j];
    return element;
}

Console.WriteLine("Input count of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Create2dArray(rows, columns, min, max);
Show2dArray(newArray);

int findelement = FindElementArray(newArray);
if (findelement == 0)
    Console.WriteLine("No element at this position");
else
    Console.WriteLine($"Element found: {findelement} ");
*/

//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] New2dArray (int row, int column, int minValue, int maxValue)
{
    int [,] createdArray = new int [row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            createdArray [i,j] = new Random().Next(minValue, maxValue + 1);
    return createdArray;
}

void Show2dArray (int [,] array)
{
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");  
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double AverageColumns (int [,] array)
{
    double sumColumns = 0;
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            sumColumns = 0;
            sumColumns += array[i, j];
            count += 1;
        }
    }        
    return sumColumns/count;
}

Console.WriteLine("Input count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


int [,] newArray = New2dArray(m, n, min, max);
Show2dArray(newArray);
double average = AverageColumns(newArray);

Console.WriteLine($"Average {average} ");
