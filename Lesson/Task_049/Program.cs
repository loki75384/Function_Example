// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4


int rows = Prompt("Введите кол-во строк: ");
int columns = Prompt("Введите кол-во столбцов: ");
int minValue = Prompt("Введите минимальное значение: ");
int maxValue = Prompt("Введите максимальное значение: ");

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
int[,] newArray = NewArray(array);
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

int[,] NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)// GetLength(0) - кол-во строк
    {
        for (int j = 0; j < array.GetLength(1); j++)// GetLength(1) - кол-во столбцов
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
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