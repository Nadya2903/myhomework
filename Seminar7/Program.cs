/*

// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void RandomMatrix(double[,] doublearray)
{
    for (int i = 0; i < doublearray.GetLength(0); i++)
    {
        for (int j = 0; j < doublearray.GetLength(1); j++)
        {
            doublearray[i,j] = new Random().Next(-10,10);
            Console.Write(doublearray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Enter the number of lines: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

RandomMatrix(matrix);


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void CreateDoubleArray(int[,] doublearray)
{
    for (int i = 0; i < doublearray.GetLength(0); i++)
    {
        for (int j = 0; j < doublearray.GetLength(1); j++)
        {
            doublearray[i,j] = new Random().Next(0,10);
            Console.Write(doublearray[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int sizelines = 3;
int sizecolumns = 3;

int[,] matrix = new int[sizelines,sizecolumns];

CreateDoubleArray(matrix);

Console.Write("Enter line number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter column number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < sizelines & n < sizecolumns)
    Console.WriteLine("Searched element: " + matrix[m,n]);
else
    Console.WriteLine("There is no such element!");

*/