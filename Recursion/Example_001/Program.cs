// собрать строку с числами от a до b, a <= b;


string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return string.Empty;
}
Console.WriteLine(NumbersRec(1, 10));