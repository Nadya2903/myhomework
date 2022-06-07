/*

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

int[,] RandomMatrix(int[,] doublearray)
{    
    for (int i = 0; i < doublearray.GetLength(0); i++)
    {
        for (int j = 0; j < doublearray.GetLength(1); j++)
        {
            doublearray[i,j] = new Random().Next(1,9);
            Console.Write(doublearray[i,j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    return doublearray;
}

int[,] SortMatrix(int[,] doublearray)
{
    int temp = 0;

    for (int i = 0; i < doublearray.GetLength(0); i++)
    {
        for (int j = 0; j < doublearray.GetLength(1); j++)
        {
            for (int k = j + 1; k < doublearray.GetLength(1); k++)
            {
                if (doublearray[i,j] > doublearray[i,k])
                {
                    temp = doublearray[i,k];
                    doublearray[i,k] = doublearray[i,j];
                    doublearray[i,j] = temp;
                }
            }
            Console.Write(doublearray[i,j] + " ");
        }
        Console.WriteLine();
    }

    return doublearray;
}

int[,] matrix = new int[3,4];

RandomMatrix(matrix);
SortMatrix(matrix);

*/