// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int num = Prompt("Введите число: ");
Console.WriteLine($"{GetSumDigit(num)}");

int Prompt(string message)// работа с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetSumDigit(int n)
{
    if (n == 0)
        return 0;
    return GetSumDigit(n / 10) + n % 10;    
}

