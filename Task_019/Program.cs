// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int a = Prompt("Введите 5-ти значнчное число: ");
int reversed = ReverseNumber(a);

if (a > 9999 && a < 1000000)
{
    if (reversed == a)
    {
        Console.WriteLine("Число является палиндромом.");

    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int number = Convert.ToInt32(value);
    return number;
}

int ReverseNumber(int a)
{
    int revNum = 0;
    int temp = a; // 12321
    while (temp > 0)
    {
        revNum = revNum * 10 + temp % 10;
        temp /= 10;
    }
    return revNum;
}