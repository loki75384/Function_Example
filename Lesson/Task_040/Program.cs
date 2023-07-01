// Задача 40: Напишите программу, которая принимает на
// вход три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int a = Prompt("Введите число 1: ");
int b = Prompt("Введите число 2: ");
int c = Prompt("Введите число 3: ");

if (TriangleInequality(a, b, c))
    Console.WriteLine($"Треугольник со сторонами такой длины может существовать");
else
    Console.WriteLine($"Треугольник со сторонами такой длины не может существовать");

bool TriangleInequality(int a, int b, int c)
{
    bool inequality = true;

    if (a >= (b + c)) inequality = false;
    if (b >= (a + c)) inequality = false;
    if (c >= (b + a)) inequality = false;

    return inequality;

}


int Prompt(string message)// работа с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}