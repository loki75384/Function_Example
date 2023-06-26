// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int N = Prompt("Введите число: ");
int result = ProductNum(N);
Console.WriteLine($"{N} -> {result}");

int ProductNum(int N)// описание метода нахождения произведения
{
    int product = 1;
    for (int i = 1; i <= N; i++)// пока i меньше N , N умножаем на i+1
    {
        product *= i;
    }
    return product;
}

int Prompt(string message)//описание метода (введите число)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
