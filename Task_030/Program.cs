// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

const int ARRAYSIZE = 8;// const - константа (неизменное значение), пишется капсом
int[] randomBinaryArray = RandomBinaryArray();
PrintArray(randomBinaryArray);

int[] RandomBinaryArray()// [] - массив типа int
{
    int[] array = new int[ARRAYSIZE];// слева создали массив = справа указали его размер
    Random random = new Random();// обьект рандомного числа

    for (int i = 0; i < ARRAYSIZE; i++)// цикл подбирающий рандомное значение
        array[i] = random.Next(0, 2);

    return array;
}

void PrintArray(int[] array)
{
    foreach (var element in array)
        Console.Write($"{element} ");

    Console.WriteLine();
}

// Metanit.com - полезная ссылка