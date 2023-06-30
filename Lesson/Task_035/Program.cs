// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int size = 123;
int minValue = 0;
int maxValue = 200;
int[] array = GetArray(size, minValue, maxValue);
int count = 0;
PrintArray(array);
Console.Write(" -> ");
FindNums(count, array);

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

void FindNums(int count, int[] arr)// поиск количества элементов в отрезке [10, 99] в массиве
{
    count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }
    }
    Console.Write(count);
}