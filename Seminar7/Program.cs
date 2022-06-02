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
Console.Write("Enter the number of lines: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n];

RandomMatrix(matrix);

*/