// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

const int ROW = 5;
const int COL = 5;
const int MIN = 1;
const int MAX = 9;

int[,] matrix = GetRandomMatrix(ROW, COL, MIN, MAX);
PrintArray(matrix);
ReplaceRow(matrix);
Console.WriteLine();
PrintArray(matrix);


void ReplaceRow(int[,] matrix)// поменяли местами строки
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i] ;
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

int[,] GetRandomMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random random = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
            matrix[i, j] = random.Next(min, max + 1);

    return matrix;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)// GetLength(0) - кол-во строк
    {
        for (int j = 0; j < arr.GetLength(1); j++)// GetLength(1) - кол-во столбцов
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}