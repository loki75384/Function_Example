// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int size = Prompt("Введите размерность массива: ");
int minValue = Prompt("Введите минимальное число диапазона в массиве: ");
int maxValue = Prompt("Введите максимальное число диапазона в массиве: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.Write(" -> ");
ReplaceEl(array);


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

void ReplaceEl(int[] array)
{
    Console.Write("[");
    foreach (int el in array)// цикл будет проходить по всем элементам массива
    {
        Console.Write($"{el * -1} ");
    }
    Console.Write("]");
}