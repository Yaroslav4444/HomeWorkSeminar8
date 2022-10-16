/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] Generate2dArray(int height, int width, int minValue, int maxValue)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return twoDArray;
}
int[] SortedLengthArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = 0; j < inputArray.Length - 1; j++)
        {
            if (inputArray[j] < inputArray[j + 1])
            {
                int temp = inputArray[j + 1];
                inputArray[j + 1] = inputArray[j];
                inputArray[j] = temp;
            }
        }
    }
    return inputArray;
}
int[,] CreateSortedArray(int[,] inputArray)
{
    int max = inputArray[0, 0];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int[] tempArray = new int[inputArray.GetLength(1)];

        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            tempArray[j] = inputArray[i, j];
        }
        int[] sortedArray = SortedLengthArray(tempArray);
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i, j] = sortedArray[j];
        }
    }
    return inputArray;
}
void PrintColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(data);
    Console.ResetColor();
}
void Print2DArray(int[,] arrayToPrint)
{
    Console.Write(" \t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        PrintColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        PrintColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Задан массив :");
int[,] array = Generate2dArray(4, 4, 1, 10);
Print2DArray(array);
Console.WriteLine("Заданный массив отсортирован :");
int[,] sortedArray = CreateSortedArray(array);
Print2DArray(sortedArray);