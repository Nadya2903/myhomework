/*

// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("The first number is greater than the second.");
}
else
{
    Console.WriteLine("The second number is greater than the first.");
}


// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second integer number: ");
int max = num1;

int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third integer number: ");
if (num2 > max)
{
    max = num2;
}
    
int num3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third integer number: ");
if (num3 > max)
{
    max = num3;
}

Console.WriteLine("Biggest number: " + max);


// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = num % 2;

if (a == 0)
{
    Console.WriteLine("Even number");
}
else
{
    Console.WriteLine("The number is odd");
}


// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

if (num < 0)
{
    num = num * (-1);
}

while (current <= num)
{
    int a = current % 2;

    if (a == 0)
        {
            Console.Write(current + " ");
        }
    current++;
}

*/