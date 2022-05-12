int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }

    return array;
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Input " + i + " elements");
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

void FindsSumOfElements(int[] array)
{
    int plusSum = 0;
    int minusSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            plusSum += array[i];
        else
            minusSum += array[i];
    }

    Console.WriteLine(plusSum);
    Console.WriteLine(minusSum);
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