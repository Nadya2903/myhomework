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

void PrintArray(string[] arrtxt)
{
    for (int i = 0; i < arrtxt.Length; i++)
    {
        Console.Write(arrtxt[i] + " ");
    }

    Console.WriteLine("\n");
}

void Merger(string[] words)
{
    string[] newwords = new string[words.Length/2];
    int count = 0;
    
    for (int i = 0; i < words.Length; i++)
    {   
        if (i % 2 > 0)
        {
            newwords[count] = words[i-1] + words[i];
            Console.Write(newwords[count] + " ");
            count++;
        }
    }
}

string[] words = {"qwe", "wer", "ert", "rty", "tyu", "yui"};

PrintArray(words);

Merger(words);

*/