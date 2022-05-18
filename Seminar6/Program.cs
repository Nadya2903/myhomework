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

void ReverseArray(int number)
{
    int size = 0;
    int[] array = new int[8];

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

Console.Write("Enter a number from 1 to 255: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 1 && num > 255)
    Console.WriteLine("Please enter a valid value!");

ReverseArray(num);

*/