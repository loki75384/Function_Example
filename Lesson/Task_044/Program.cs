// Задача 44: Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int N = Prompt("Введите число N: ");
Fibonacci(N);

int Prompt(string message)// работа с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void Fibonacci(int N)
{
    int next = 0;
    int actual = 1;
    int previous = 0;

    Console.Write($"Если N = {N} -> ");
    for (int i = 0; i < N; i++)
    {
        Console.Write($"{next} ");
        previous = next;
        next = next + actual;
        actual = previous;
    }
}