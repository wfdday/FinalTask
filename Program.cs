﻿Console.Clear();

Console.Write("Введите элементы массива через запятую: ");
string[] inputArr = Console.ReadLine().Split(',');

string[] resultArr = FilterStrings(inputArr);

Console.WriteLine("[" + string.Join(", ", inputArr) + "] → [" + string.Join(", ", resultArr) + "]");

static string[] FilterStrings(string[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArr = new string[count];
    int index = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArr[index] = arr[i];
            index++;
        }
    }

    return resultArr;
}
