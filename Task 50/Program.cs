/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет. */

int rows = 3;
int columns = 4;
int[,] array = new int[rows, columns];
FillArray();
PrintArray();
Console.WriteLine();
FindValue();

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
void FindValue()
{
    Console.WriteLine("Введите номер строки:");
    int currentRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер колонки");
    int currentColumn = Convert.ToInt32(Console.ReadLine());
    if (currentRow >= rows || currentColumn >= columns)
    {
        Console.WriteLine("Такого элемента нет в массиве");
    }
    else Console.WriteLine(array[currentRow, currentColumn]);
}