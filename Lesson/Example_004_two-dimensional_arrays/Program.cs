// Двумерные массивы
// string[,] table = new string [2, 3];
// int[,] matrix = new int [5, 8]; первое число кол-во строк, второе кол-во столбцов

//
string[,] table = new string[2, 5];
// String.Empty
// table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4]

table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// строки GetLength(0)
    {
        for (int j = 0; j < matr.GetLength(1); j++)// столбцы GetLength(1)
        {
            matr[i, j] = new Random().Next(1, 10);// [1, 10)
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}
int[,] matrix = new int[3, 4];

