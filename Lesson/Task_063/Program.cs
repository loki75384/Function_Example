// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int N = Convert.ToInt32(Console.ReadLine());// ввод числа N
Console.WriteLine($"{Range(N)}");

string Range(int n)
{
    if (n == 1)
        return "1";
    return Range(n-1) + ", " + Convert.ToInt32(n);
}