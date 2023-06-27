// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5 

int userNum = Prompt("Введите число: ");
int counter = CountNum(userNum);
Console.WriteLine(counter);

int CountNum(int userNum)
{
    int i = 0;// счетчик

    while (userNum >= 1)// пока введенное число больше 1
    {
        userNum /= 10;// убираем разряд
        i++;// счетчик + 1
    }

    return i;// возвращаем счетчик
}

int Prompt(string message)//описание метода (введите число)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
