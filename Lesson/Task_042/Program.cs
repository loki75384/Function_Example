// Задача 42: Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10 

// string val = (Console.ReadLine()!);
// int from = 10;
// int to = 2;

// string binary = Convert.ToString(Convert.ToInt32(val, from), to);// ToString(Int32, Int32)	
// //Преобразует значение заданного 32-битового целого числа со знаком в эквивалентное строковое представление в указанной системе счисления.
// Console.WriteLine(binary);

int num = Prompt("Введите число: ");
Console.WriteLine(BinaryConvert(num));

int Prompt(string message)// работа с пользователем
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

string BinaryConvert(int num)
{
    string newValue = "";
    while (num >= 1)
    {
        newValue = num % 2 + newValue;
        num /= 2;
    }
    return newValue;
}
