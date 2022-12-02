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



//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
