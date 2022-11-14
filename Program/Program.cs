// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых меньше либо равна 3 символа

using static System.Console;
Clear();
string[] arrayFirst = new string[5] { "99", "hey", "world", "19833", "002" };
string[] arraySecond = new string[arrayFirst.Length];
ConvertedArray(arrayFirst, arraySecond);
PrintArray(arraySecond);



void ConvertedArray(string[] array1, string[] array2)
{
    int n = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[n] = array1[i];
            n++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}