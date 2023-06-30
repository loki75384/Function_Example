// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона в массиве: ");
int maxValue = Prompt("Введите максимальное число диапазона в массиве: ");
int userNum = Prompt("Введите искомое число: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.Write(": ");
GetResult(array, userNum);




int Prompt(string message)// работа с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetArray(int size, int minValue, int maxValue)// заполнение массива
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[] arr)// печать массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");

}

void GetResult(int[] array, int UserNum)
{
    bool temp = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != UserNum)
        {
            temp = false;
        }
        else
        {
            temp = true;
        }
    }
    if (temp = true)
    {
        Console.Write("Да");
    }
    else
    {
        Console.Write("Нет");
    }
}