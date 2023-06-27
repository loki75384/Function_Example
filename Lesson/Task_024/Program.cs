// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Prompt(string message)//описание метода (введите число)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetSum(int a)// описание метода (найти сумму от 1 до A)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

int number = Prompt("Введите число: ");// кладем в переменную number значение введенное пользователем
int result = GetSum(number);// кладем в переменную result сумму от 1 до A
Console.WriteLine("Сумма чисел от 1 до A = " + result);// печатаем result на консоль

