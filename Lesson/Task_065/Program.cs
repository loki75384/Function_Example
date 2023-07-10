// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int M = Convert.ToInt32(Console.ReadLine());// ввод числа N
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Range(N, M)}");

string Range(int n, int m)// Так как здесь строковый тип, числа склеиваются в обратном порядке
{                  // называется стэк
    if (n == m)
        return M.ToString();
    return Range(n-1, m) + ", " + n;
}