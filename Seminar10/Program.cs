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

Console.WriteLine(Vowel(words));

*/