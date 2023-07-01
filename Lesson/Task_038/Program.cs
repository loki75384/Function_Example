// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] startArray = GetArray(5); // тип double указываем чтобы увидеть значения с плавующей запятой
Console.WriteLine(String.Join("|", startArray));// String.Join позволяет указать разделитель для элементов в массиве
Console.WriteLine($"Разница = {GetDifference(startArray)}");

double[] GetArray(int size)
{
    double[] res = new double[size];// создали новый массив res

    for (int i = 0; i < size; i++)// цикл
    {
        res[i] = new Random().NextDouble() * 10;// генерирует случайное число от 0.1 до 1.0, умножаем на 10
        res[i] = Math.Round(res[i], 3);// сокращает до 3-ех знаков после запятой
    }
    return res;
}

double GetDifference(double[] array)// поиск разницы min и max
{
    double min = array[0];// присваиваем значение 1-ому элементу массива
    double max = array[0];
    foreach (double el in array)
    {
        if (min > el) min = el;// ищем минимальный элемент путем сравнения
        if (max < el) max = el;
    }
    return max - min;// возвращаем разность
}