/*

// Задача 1: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumOfElements(int m, int n)
{
    int sum = 0;
    int temp = 0;

    if (m > n)
    {
        for (int i = 0; i <= m - n; i++)
        {
            temp = n + i;
            sum += temp;
        }
    }
  
    if (n > m)
    {
        for (int i = 0; i <= n - m; i++)
        {
            temp = m + i;
            sum += temp;
        }
    }

    return(sum);
}

int m = 4;
int n = 8;

Console.WriteLine("The sum of natural elements between " + m + " and " + n + " is equal to " + SumOfElements(m, n));


// Задача 2: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfNumbers(int num)
{
    int mod = 0;
    int sum = 0;

    for (int i = 0; num > 0; i++)
    {
        mod = num % 10;
        num /= 10;
        sum += mod;
    }

    sum += num;

    return sum;
}

Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

SumOfNumbers(num);

Console.Write("The sum of the digits in a number: " + SumOfNumbers(num));

*/