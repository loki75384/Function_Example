// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int size = 5;
int minValue = 1;
int maxValue = 11;
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.Write(" -> ");
PrintArray(FindProductEl(array));

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

int[] FindProductEl(int[] arr)
{
    int index = 0;
    int[] resArr = new int[(arr.Length + 1) / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        resArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1)
    {
        resArr[(arr.Length - 1) / 2] = arr[(arr.Length - 1) / 2];
    }
    return resArr;
}

