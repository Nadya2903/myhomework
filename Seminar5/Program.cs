/*

// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void NaturalDegree()
{
    Console.WriteLine("Enter the first number: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    int b = Convert.ToInt32(Console.ReadLine());

    int degree = a;

    for (int i = 0; i < b - 1; i++)
    {
        a *= degree;
    }

    Console.WriteLine("The first number to the power of the second: " + a);
}

NaturalDegree();


// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumOfNumbers (int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    Console.WriteLine("The sum of the digits of the number is " + sum);
}

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

SumOfNumbers(num);


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

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
    Console.Write("[");
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length - 1))
        {
            Console.Write(array[i]);
        }
        else
            Console.Write(array[i] + ", ");
    }

    Console.Write("]");

    Console.WriteLine();
}

int[] MyArray = CreateRandomArray(8, 0, 20);

ShowArray(MyArray);

*/