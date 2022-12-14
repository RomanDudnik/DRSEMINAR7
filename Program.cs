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
            randomArray [i,j] = Math.Round (new Random().Next(-100,100) + new Random().NextDouble(), 2);
            //случайные элементы заполнения можно ограничить любым отрезком -> new Random(-1000, 1000.Next()
            // а можно не ограничивать -> Random().Next()
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

//вариант 1

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

//Вариант 2

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

void FindElementArray(int [,] array)
{
    Console.WriteLine("Input the position of the element:: ");
    Console.WriteLine("Input position of rows: ");
    int rowPosition = Convert.ToInt32(Console.ReadLine());

    if (rowPosition > array.GetLength(0)-1)
        while (rowPosition > array.GetLength(0)-1)
        {
            Console.WriteLine($"No such row.Pls, input the row number(no more than {array.GetLength(0)-1}):");
            rowPosition = Convert.ToInt32(Console.ReadLine());
        }

    Console.WriteLine("Input position of columns: ");
    int columnPosition = Convert.ToInt32(Console.ReadLine());

    if (columnPosition > array.GetLength(1)-1)
        while (columnPosition > array.GetLength(1)-1)
        {
            Console.WriteLine($"No such column.Pls, input the column number(no more than {array.GetLength(1)-1}):");
            columnPosition = Convert.ToInt32(Console.ReadLine());
        }

    int element = 0;

    for(int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
                if (i == rowPosition && j == columnPosition)
                    element = array[i, j];
    Console.WriteLine($"Еlement at position(row:{rowPosition}, column:{columnPosition}) is {element}");
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
FindElementArray(newArray);
*/

//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Вариант 1 (мой)
/*
int [,] New2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
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

double [] AverageColumns (int [,] array)
{
    double [] averArray = new double [array.GetLength(1)];

    for (int i = 0; i < array.GetLength(1); i++)
        for (int j =0; j < array.GetLength(0); j++)
            averArray[i] += array[j, i];
                    for (int k = 0; k < array.GetLength(1); k++)
                        Console.Write(Math.Round(averArray[k] / array.GetLength(0), 3)  + " | ");
            
    
    return averArray;
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
Console.WriteLine("Average columns is: ");
double [] average = AverageColumns(newArray);
*/

//Вариант 2 (Татьяна)

int [,] New2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] createdArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
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

double [] AverageColumns (int [,] array1)
{
    double [] averArray = new double [array1.GetLength(1)];

    for (int j = 0; j < array1.GetLength(1); j++)
    {
        double sum = 0;
            for (int i =0; i < array1.GetLength(0); i++)
                sum += array1[i, j];
    averArray[j] = Math.Round(sum / array1.GetLength(0), 2);                          
    }
    return averArray;
}

void ShowArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.WriteLine("Input count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] new2dArray = New2dArray(m, n, min, max);
Show2dArray(new2dArray);
double [] avg1dArray = AverageColumns(new2dArray);
ShowArray(avg1dArray);
