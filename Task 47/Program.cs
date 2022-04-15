// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int rows = 3;
int columns = 4;
double[,] array = new double [rows, columns];
FillArray();
PrintArray();

void FillArray()
{
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.NextDouble() * 100;
        }
    }
}
void PrintArray()
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}