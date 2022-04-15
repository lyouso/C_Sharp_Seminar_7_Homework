// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];
int[] average = new int[4];
FillArray();
PrintArray();
Console.WriteLine();
FindAverage();



void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FindAverage()
{
    for (int j = 0; j < columns; j++)
    {
        int average = 0;
        for (int i = 0; i < rows; i++)
        {
            average += array[i, j];
        }
        Console.Write(average/ rows + " ");
    }
    Console.WriteLine();
}