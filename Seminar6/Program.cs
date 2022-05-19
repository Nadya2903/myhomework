/*

// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input " + (i + 1) + " element");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

void PositiveNumber(int[] array)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }

    Console.WriteLine("Entered positive numbers: " + count);
}

int[] MyArray = CreateArray(5);

ShowArray(MyArray);

PositiveNumber(MyArray);


// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void BinarNumber(int number)
{
    int size = 0;
    int[] array = new int[999];

    for (int i = 0; number > 0; i++)
    {
        array[i] = number % 2;
        number = number / 2;
        size++;
    }

    Console.Write("Number in binary system: ");
    
    int[] newArray = new int[size];

    for (int i = 0, j = size - 1; i < size; i++, j--)
    {
        newArray[i] = array[j];
        Console.Write(newArray[i]);
    }
}

Console.Write("Enter a positive integer: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
    Console.WriteLine("Please enter a valid value!");

BinarNumber(num);


// Задача 3: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);     // или " y = k1 * x + b1 (y = k2 * x + b2) "

    Console.WriteLine("Point of intersection of two lines: (" + Math.Round(x,1) + "; " + Math.Round(y,1) + ")");
}

Console.WriteLine("Enter the x-coordinate of the first point: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y-coordinate of the first point: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the x-coordinate of the second point: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y-coordinate of the second point: ");
double k2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);

*/