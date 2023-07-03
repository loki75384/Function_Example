// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int rows = Prompt("Введите кол-во строк: ");
int columns = Prompt("Введите кол-во столбцов: ");
int minValue = Prompt("Введите минимальное значение: ");
int maxValue = Prompt("Введите максимальное значение: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
int sum = GetSum(array);
Console.WriteLine($"Сумма элементов главной диагонали: {sum}");

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
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

int GetSum(int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)// GetLength(0) - кол-во строк
    {
        for (int j = 0; j < arr.GetLength(1); j++)// GetLength(1) - кол-во столбцов
        {
            if (i == j)
            {
                result = result + arr[i, j];
            }
        }
    }
    return result;
}