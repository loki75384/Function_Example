// Факториал числа

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n -1);
}
Console.WriteLine(FactorialRec(10)); // 3628800

// Возвести a в степень n

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n -1) * a;
}
Console.WriteLine(PowerRec(2,10));// 1024

// Перебор слов.