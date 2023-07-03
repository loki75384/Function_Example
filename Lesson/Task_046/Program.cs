// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int rows = Prompt("Введите кол-во строк: ");
int columns = Prompt("Введите кол-во столбцов: ");
int minValue = Prompt("Введите минимальное значение: ");
int maxValue = Prompt("Введите максимальное значение: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);

int Prompt(string message)// работа с пользователем
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
