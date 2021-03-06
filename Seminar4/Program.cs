/*

// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

void EvenElements(int[] array)
{
    int count = 0;
        
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }

    Console.WriteLine("Number of even elements in the array: " + count);
}


int[] myArray = CreateRandomArray(12, 100, 999);

ShowArray(myArray);

EvenElements(myArray);


// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

void SumOfOddPositions(int[] array)
{
    int sum = 0;
        
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }

    Console.WriteLine("The sum of elements in odd positions: " + sum);
}


int[] myArray = CreateRandomArray(12, -50, 50);

ShowArray(myArray);

SumOfOddPositions(myArray);


// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void DifferenceMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    double difference = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
    }

    difference = max - min;

    Console.WriteLine("Difference between maximum and minimum array element: " + difference);
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}


double[] myArray = {2, 73, 98, 22, 3};

ShowArray(myArray);

DifferenceMinMax(myArray);

*/