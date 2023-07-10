// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8 

int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");
Console.WriteLine($"{PowerNums(A, B)}");

int PowerNums(int a, int b)
{
    if (b == 0)
        return 1;
    int tmp = PowerNums(a, b / 2);
    int tmp2 = (b % 2 == 1) ? a : 1;
    return tmp * tmp * tmp2;
}

int Prompt(string message)// работа с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}