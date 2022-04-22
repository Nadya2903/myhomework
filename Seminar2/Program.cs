/*

// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondNumber()
{
    Console.Write("Enter a three-digit number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Second digit of the number " + num + " -> " + (num / 10) % 10);
}

SecondNumber();


// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber()
{
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 99)
    {
        Console.WriteLine("Third digit of the number " + num + " -> " + num % 10);
    }
    else
    {
        Console.WriteLine("There is no third number.");
    }
}

ThirdNumber();


// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfWeek()
{
    Console.Write("Enter a number from 1 to 7: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 1 & num <= 5)
    {
        Console.WriteLine("It's a working day!");
    }
    else if (num > 5 & num < 8)
    {
        Console.WriteLine("It's a day off!");
    }
    else
    {
        Console.WriteLine("Please enter a valid value!");
    }
}

DayOfWeek();

*/