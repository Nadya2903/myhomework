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


// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void SmallestSumOfElements(int[,] summatrix)
{
    int summin = 0;
    int sum1 = 0;
    int sum2 = 0;
    int index = 0;

    int temp = 0;
    int itemp = 0;

    for (int i = 0; i < summatrix.GetLength(0); i++)
    {
        sum2 = 0;
        
        for (int j = 0; j < summatrix.GetLength(1); j++)
        {            
            sum2 += summatrix[i,j];
        }

        if (i == 0)
        {
            temp = sum2;
            itemp = i;
        }

        if (sum2 < sum1)
        {
            summin = sum2;
            index = i;
        }
        
        sum1 = sum2;
    }

    if (temp < summin)
    {
        summin = temp;
        index = itemp;
    }

    Console.WriteLine("Line No: " + (index+1));
    Console.WriteLine("Sum of elements: " + summin);
    for (int i = 0; i < summatrix.GetLength(1); i++)
        Console.Write(summatrix[index,i] + " ");
}

int[,] matrix = {{1,4,7,2},
                 {5,9,2,3},
                 {8,4,2,4},
                 {5,2,6,7}};

SmallestSumOfElements(matrix);

*/