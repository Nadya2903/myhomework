/*

// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

int Vowel(string[] words)
{
    char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
    int count = 0;

    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (words[i][0] == vowels[j])
                count++;
        }
    }

    return count;
}

string[] words = {"qwe", "wer", "ert", "rty", "tyu"};

Console.WriteLine("Number of words starting with a vowel: " + Vowel(words));


// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

void Merger(string[] words)
{
    for (int i = 0; i < words.Length; i++)
    {
        string pair = "";
        
        if (i % 2 > 0)
        {
            pair = words[i-1] + words[i];
            Console.Write(pair + " ");
        }
    }
}

void PrintArray(string[] arrtxt)
{
    for (int i = 0; i < arrtxt.Length; i++)
    {
        Console.Write(arrtxt[i] + " ");
    }

    Console.WriteLine("\n");
}

string[] words = {"qwe", "wer", "ert", "rty", "tyu", "yui"};

PrintArray(words);

Merger(words);

*/