// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона в массиве: ");
int maxValue = Prompt("Введите максимальное число диапазона в массиве: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
GetSumm(array);

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
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    foreach (int el in arr)
    {
        Console.Write($"{el} ");
    }
}

void GetSumm(int[] array)// находим сумму положительных и отрицательных элементов
{
    int positiveSum = 0;
    int negativeSum = 0;

    foreach (int el in array)// цикл будет проходить по всем элементам массива
    {
        if (el > 0) positiveSum += el;
        if (el < 0) negativeSum += el;
    }

    Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицатльных чисел = {negativeSum}");
}