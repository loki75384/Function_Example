// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int rows = Prompt("Введите кол-во строк: ");
int columns = Prompt("Введите кол-во столбцов: ");


int[,] array = GetArray(rows, columns);
PrintArray(array);

int Prompt(string message)// работа с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
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
