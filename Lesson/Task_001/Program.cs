// Вид 1 - ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор Андрей");
}
//Method1();// вызов метода




// Вид 2 - что то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; // увеличение счетчика на единицу называют инкрементом, уменьшение декрементом
    }
}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "Новый текст");

// Вид 3 - ничего не принимают, что то возвращают

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4 - что то принимают, что то возвращают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;// значение result - пустая строка

//     while (i < count)
//     {
//         result = result + text;
//         i++;

//     }
//     return result;
// }
// string res = Method4(10, "z");// определение переменной для использования метода
// Console.WriteLine(res);

// Цикл for
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i)
// }

string Method4(int count, string text)
{

    string result = String.Empty;// значение result - пустая строка
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");// определение переменной для использования метода
Console.WriteLine(res);

//Цикл внутри цикла
// for(int i = 0;i < 10;i++)
// {
//     for(int j = 0;j < 10;j++)
//     {
//         Console.WriteLine(i*j);
//     }
//     Console.WriteLine();
// }

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} X {j} = {i * j}");
    }
    Console.WriteLine();
}
//