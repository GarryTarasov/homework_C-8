// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//1 2 4 7
//2 3 5 9
//2 4 4 8


Console.Clear();

int[,] CreateMatrix(int row, int colum)
{
    int[,] matrix = new int[row, colum];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return matrix;

}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ArrangeAscending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPos = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, minPos]) minPos = k;
            }
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[i, minPos];
            matrix[i, minPos] = tmp;
        }
    }
    return matrix;
}
Console.Write("Введи количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int width = Convert.ToInt32(Console.ReadLine());
PrintArray(ArrangeAscending(CreateMatrix(height, width)));