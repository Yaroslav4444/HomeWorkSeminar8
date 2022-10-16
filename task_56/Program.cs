/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int MostMinimalSumString(int[,] inputArray)
{
    int sum = 0;
    int count = 0;
    int max = int.MaxValue;
    int min = 0;
    for (int i = 0; i <= inputArray.GetLength(1); i++)
    {
        for (int j = 0; j < inputArray.GetLength(0) - 1; j++)
        {
            sum += inputArray[i, j];
        }
        if (max > sum)
        {
            max = sum;
            min = count;
        }
        count++;
        sum = 0;
    }
    return min;
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
}

int[,] array = Generate2dArray(5, 4, 1, 10);
Console.WriteLine("Задан прямоугольный двумерный массив : ");
Print2DArray(array);
int minimal = MostMinimalSumString(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minimal} ");