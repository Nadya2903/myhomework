/*

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void palindrom (int N)
{   
    int pal = N;
    int rev = 0;
    int dig = 0;

    if (N > 9999 & N < 100000)
    {
        while (N > 0)
        {
            dig = N % 10;
            rev = rev * 10 + dig;
            N = N / 10;
        }

        if (pal == rev)
        {
            Console.WriteLine("This is a palindrome.");
        }
        else
        {
            Console.WriteLine("It's not a palindrome.");
        }
    }
    else
    {
        Console.WriteLine("Enter a five-digit number!");
    }
}

Console.Write("Enter a five-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

palindrom(num);


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void kub (int N)
{
    int count = 1;

    while (count <= N)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}

Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    kub(num);
}
else
{
    Console.Write("Please enter a positive number!");
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Coords(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}

Console.WriteLine("Enter the x-coordinate of the first point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y-coordinate of the first point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the z-coordinate of the first point: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the x-coordinate of the second point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y-coordinate of the second point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the z-coordinate of the second point: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Coords(x1, y1, z1, x2, y2, z2));

*/