/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] ferstArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(99, 1000);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

int GetNumber(string message)
{
Console.WriteLine(message);
int result = int.Parse(Console.ReadLine());
return result;
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        count++;
    }
    return count;
}
int length = GetNumber("Введите массив трёхзначных чисел");
int[] arr = ferstArray(length);
PrintArray(arr);

int kolvoNumber = CountNumber(arr);

Console.WriteLine($"Количество чётных чисел -> {kolvoNumber} ");
